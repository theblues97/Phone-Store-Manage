using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneStore
{
    public partial class Bills : Form
    {
        private string username;
        private int billID;
        private bool createdBill;
        private bool cusInforChanged;

        public Bills()
        {
            InitializeComponent();
        }

        public Bills(string Username) : this()
        {
            username = Username;

            LoadEmployee();
            LoadComboBox();
            LoadPhones();

            createdBill = false;
            cusInforChanged = false;
            cbbBuyMethod.SelectedIndex = 0;
            cbbPayMethod.SelectedIndex = 0;
            ((Control)this.tab2).Enabled = false;
        }
        
        #region Methods

        private void ClearControls()
        {
            txtSearchCus.Text = "";
            txtCustomer.Text = "";
            datBirth.Value = new DateTime(2000, 1, 1);
            txtEmail.Text = "";
            txtAdress.Text = "";
            radMale.Checked = false;
            radFemale.Checked = false;
        }

        private void LoadCustomers()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var customer = from c in ctx.KhachHangs where c.SoDienThoai == txtSearchCus.Text select c;
                try
                {
                    txtCustomer.Text = (from c in customer select c.TenKH).FirstOrDefault().ToString();
                    datBirth.Value = (from c in customer select c.NgaySinh).FirstOrDefault().Value;
                    txtEmail.Text = (from c in customer select c.Email).FirstOrDefault().ToString();
                    txtAdress.Text = (from c in customer select c.DiaChi).FirstOrDefault().ToString();

                    if ((from c in customer select c.GioiTinh).FirstOrDefault().ToString() == "Nam")
                        radMale.Checked = true;
                    else
                        radFemale.Checked = true;
                    btnSelect.Enabled = true;
                }
                catch
                {
                    ClearControls();

                    DialogResult answer = MessageBox.Show("Không tìn thấy khách hàng. Bạn có muốn tạo mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        var lastCusID = (from cus in ctx.KhachHangs orderby cus.MaKH descending select cus.MaKH).FirstOrDefault();
                        var newCus = new KhachHang { MaKH = lastCusID + 1, SoDienThoai = txtSearchCus.Text };
                        ctx.KhachHangs.Add(newCus);
                        ctx.SaveChanges();
                        btnSelect.Enabled = true;
                    }
                    else
                        btnSelect.Enabled = false;
                }
            }
        }

        private void LoadComboBox()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var brands = from b in ctx.HangDienThoais select b.TenHDT;

                cbbBrand.Items.AddRange(brands.ToArray());

                var colors = from c in ctx.DienThoais group c by c.Mau into sc select sc.Key;
                cbbColors.Items.AddRange(colors.ToArray());
            }
        }

        private void LoadPhones()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var query = from p in ctx.DienThoais
                            select new
                            {
                                TenHang = p.MauDienThoai.HangDienThoai.TenHDT,
                                MaMauDienThoai = p.MauDienThoai.MaMDT,
                                TenDienThoai = p.MauDienThoai.TenDT,
                                MaDienThoai = p.MaDT,
                                p.Mau,
                                p.SoLuong,
                                Gia = p.GiaBan,
                                KhuyenMai = p.MauDienThoai.KM
                            };

                if (cbbBrand.SelectedIndex > -1)
                {
                    query = from q in query
                            where
                            q.TenHang == cbbBrand.SelectedItem.ToString()
                            select q;
                }

                if (cbbColors.SelectedIndex > -1)
                {
                    query = from q in query
                            where
                            q.Mau == cbbColors.SelectedItem.ToString()
                            select q;
                }

                var result = from q in query
                             select new
                             {
                                 q.MaDienThoai,
                                 q.TenDienThoai,
                                 q.Mau,
                                 q.SoLuong,
                                 q.Gia,
                                 q.KhuyenMai
                             };

                if (txtSearchPhone.Text == "")
                    dgvPhones.DataSource = result.ToList();
                else
                {
                    var proc = ctx.pro_SearchPhones(txtSearchPhone.Text);
                    var res = from pr in proc
                              join q in query on pr.MaDT equals q.MaDienThoai
                              select new
                              {
                                  MaDienThoai = pr.MaDT,
                                  TenDienThoai = pr.TenDT,
                                  pr.Mau,
                                  pr.SoLuong,
                                  Gia = pr.GiaBan,
                                  KhuyenMai = pr.KM
                              };

                    dgvPhones.DataSource = res.ToList();
                }

                dgvPhones.Columns[0].Visible = false;
                dgvPhones.Columns[5].Visible = false;
                dgvPhones.Columns[1].HeaderText = "Tên điện thoại";
                dgvPhones.Columns[2].HeaderText = "Màu";
                dgvPhones.Columns[3].HeaderText = "Số lượng";
                dgvPhones.Columns[4].HeaderText = "Giá";
                dgvPhones.Columns[1].FillWeight = 150;
                dgvPhones.Columns[2].FillWeight = 50;
                dgvPhones.Columns[3].FillWeight = 70;
                dgvPhones.Columns[4].FillWeight = 70;
                dgvPhones.Refresh();
            }
        }

        private void LoadEmployee()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var employee = from emp in ctx.NhanViens
                               join acc in ctx.Accounts on emp.MaNV equals acc.MaNV
                               where acc.Username == username
                               select emp;
                txtEmployeeID.Text = (from emp in employee select emp.MaNV).FirstOrDefault().ToString();
                txtEmployeeName.Text = (from emp in employee select emp.TenNV).FirstOrDefault().ToString();

                DateTime time = DateTime.Now;
                datBuy.Value = new DateTime(time.Year, time.Month, time.Day);
                datWarranty.Value = new DateTime(time.Year + 1, time.Month, time.Day);
            }
        }

        private void CreateBills()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var cus = (from c in ctx.KhachHangs where c.SoDienThoai == txtSearchCus.Text select c).FirstOrDefault();
                cus.TenKH = txtCustomer.Text;
                cus.GioiTinh = radMale.Checked ? "Nam" : "Nữ";
                cus.NgaySinh = datBirth.Value;
                cus.Email = txtEmail.Text;
                cus.DiaChi = txtAdress.Text;

                var lastBillID = (from bill in ctx.HoaDons orderby bill.MaHD descending select bill.MaHD).FirstOrDefault();
                var newbill = new HoaDon
                {
                    MaHD = lastBillID + 1,
                    MaKH = cus.MaKH,
                    MaNV = Int32.Parse(txtEmployeeID.Text),
                    NgayMua = datBuy.Value,
                    HanBH = datWarranty.Value,
                    PTMuaHang = cbbBuyMethod.SelectedItem.ToString(),
                    PTThanhToan = cbbPayMethod.SelectedItem.ToString(),
                    Tongtien = 0
                };
                ctx.HoaDons.Add(newbill);
                ctx.SaveChanges();

                billID = lastBillID + 1;
            }
        }

        private void ChoosePhones()
        {
            var cRow = dgvPhones.CurrentCell.RowIndex;
            var PhoneID = Int32.Parse(dgvPhones.Rows[cRow].Cells[0].FormattedValue.ToString());
            using (var ctx = new PhoneStoreManageEntities())
            {
                var check = (from p in ctx.DienThoais where p.MaDT == PhoneID select p.SoLuong).FirstOrDefault();
                if (check > 0)
                {
                    var lastDBillID = (from db in ctx.ChiTietHoadons orderby db.MaCTHD descending select db.MaCTHD).FirstOrDefault();
                    var newDeBill = new ChiTietHoadon
                    {
                        MaCTHD = lastDBillID + 1,
                        MaHD = billID,
                        MaDT = PhoneID
                    };
                    ctx.ChiTietHoadons.Add(newDeBill);
                    ctx.SaveChanges();

                    LoadPhones();
                    dgvPhones.CurrentCell = dgvPhones[1, cRow];
                    dgvPhones.Rows[cRow].Selected = true;

                    var detailBill = (from b in ctx.ChiTietHoadons
                                      select new
                                      {
                                          b.MaHD,
                                          b.MaDT,
                                          b.DienThoai.MauDienThoai.TenDT,
                                          b.DienThoai.Mau,
                                          b.DienThoai.GiaBan
                                      }).Distinct();

                    var countList = from db in ctx.ChiTietHoadons
                                    join p in ctx.DienThoais on db.MaDT equals p.MaDT
                                    join b in ctx.HoaDons on db.MaHD equals b.MaHD
                                    group db by new { db.MaHD, db.MaDT, db.DienThoai.GiaBan } into dbs
                                    orderby dbs.Key.MaHD
                                    select new
                                    {
                                        dbs.Key,
                                        Count = dbs.Count(),
                                        Total = dbs.Count() * dbs.Key.GiaBan
                                    };

                    var query = from bill in detailBill
                                join list in countList on
                                new { bill.MaHD, bill.MaDT } equals
                                new { list.Key.MaHD, list.Key.MaDT }
                                into result
                                from r in result.DefaultIfEmpty()
                                where bill.MaHD == billID
                                select new
                                {
                                    bill.TenDT,
                                    bill.Mau,
                                    bill.GiaBan,
                                    r.Count,
                                    r.Total
                                };

                    dgvDetailBillPhones.DataSource = query.ToList();
                    dgvDetailBillPhones.Columns[0].HeaderText = "Điện thoại";
                    dgvDetailBillPhones.Columns[1].HeaderText = "Màu";
                    dgvDetailBillPhones.Columns[2].HeaderText = "Giá";
                    dgvDetailBillPhones.Columns[3].HeaderText = "Số lượng";
                    dgvDetailBillPhones.Columns[4].HeaderText = "Thành tiền";
                    dgvDetailBillPhones.Refresh();

                    lblTotalMoney.Text = (from q in ctx.HoaDons where q.MaHD == billID select q.Tongtien).FirstOrDefault().ToString();
                }
            }
        }

        private void DeleteDetailBill()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var dbill = from db in ctx.ChiTietHoadons where db.MaHD == billID select db;
                var bill = (from b in ctx.HoaDons where b.MaHD == billID select b).FirstOrDefault();
                if (bill != null)
                {
                    foreach (var db in dbill)
                    {
                        var phone = (from p in ctx.DienThoais
                                        where p.MaDT == db.MaDT
                                        select p).FirstOrDefault();
                        phone.SoLuong += 1;
                    }
                    ctx.ChiTietHoadons.RemoveRange(dbill);
                    ctx.SaveChanges();

                    dgvDetailBillPhones.DataSource = null;
                    dgvDetailBillPhones.Refresh();
                }
            }
        }

        private void DeleteBill()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                DeleteDetailBill();
                var bill = (from b in ctx.HoaDons where b.MaHD == billID select b).FirstOrDefault();
                if (bill != null)
                {
                    ctx.HoaDons.Remove(bill);
                    ctx.SaveChanges();
                    MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FillPhone(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvPhones.CurrentRow.Selected = true;
                txtPhoneFilled.Text = dgvPhones.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtColor.Text = dgvPhones.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtAvailble.Text = dgvPhones.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtPrice.Text = dgvPhones.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtGift.Text = dgvPhones.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            }
        }

        #endregion

        #region Events

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cusInforChanged)
            {
                DialogResult answer = MessageBox.Show("Thông tin khách hàng đã được sửa, bạn có muốn lưu thông tin và tiếp tục không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    CreateBills();

                    ((Control)this.tab2).Enabled = true;
                    tabMainBill.SelectedTab = tab2;
                    btnDel.Enabled = true;
                    btnAdd.Enabled = true;
                }
                else if (answer == DialogResult.No)
                {
                    btnRefesh.PerformClick();
                }
            }
            else
            {
                CreateBills();

                ((Control)this.tab2).Enabled = true;
                tabMainBill.SelectedTab = tab2;
                btnDel.Enabled = true;
                btnAdd.Enabled = true;
            }
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Các thông tin thay đổi chưa được lưu, bạn có muốn tiếp tục không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                DeleteBill();
                ClearControls();
                tabMainBill.SelectedTab = tab1;
                ((Control)this.tab2).Enabled = false;
                btnDel.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Bạn có muốn hủy hóa đơn thật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                DeleteBill();
                tabMainBill.SelectedTab = tab1;
                ((Control)this.tab2).Enabled = false;
                btnAdd.Enabled = false;
                btnDel.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Bạn có muốn đặt lại hóa đơn thật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                DeleteDetailBill();
                LoadPhones();
                lblTotalMoney.Text = "0";
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Bạn có muốn tạo hóa đơn thật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                createdBill = true;
                dgvDetailBillPhones.DataSource = null;
                dgvDetailBillPhones.Refresh();
                ClearControls();
                tabMainBill.SelectedTab = tab1;
                lblTotalMoney.Text = "0";
                ((Control)this.tab2).Enabled = false;
                btnDel.Enabled = false;
                MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPhoneNumFill_Click(object sender, EventArgs e)
        {
            LoadCustomers();

            txtSearchCus.TextChanged += txtHeadle_KeyPress;
            txtCustomer.TextChanged += txtHeadle_KeyPress;
            txtEmail.TextChanged += txtHeadle_KeyPress;
            txtAdress.TextChanged += txtHeadle_KeyPress;
        }

        private void cbbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPhones();
        }

        private void cbbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPhones();
        }

        private void txtSearchPhone_TextChanged(object sender, EventArgs e)
        {
            LoadPhones();
        }

        private void btnPhoneSearch_Click(object sender, EventArgs e)
        {
            LoadPhones();
        }

        private void dgvPhones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillPhone(e);
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            ChoosePhones();
        }

        private void pnlSalebills_Leave(object sender, EventArgs e)
        {
            if (!createdBill && tabMainBill.SelectedTab == tab2)
            {
                MessageBox.Show("Các thông tin thay đổi chưa được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeleteBill();
            }
        }

        private void txtHeadle_KeyPress(object sender, EventArgs e)
        {
            btnRefesh.Enabled = true;
            cusInforChanged = true;
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            btnRefesh.Enabled = false;
            cusInforChanged = false;
            LoadCustomers();
        }
        #endregion
    }
}
