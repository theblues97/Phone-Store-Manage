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
    public partial class Home : Form
    {
        public string username;
        public int billID;
        public Home()
        {
            InitializeComponent();

            
        }

        public Home(string Username) : this()
        {
            username = Username;
            lblUsernames.Text = username;

        }

        #region Methods
        void LoadComboBox()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var brands = from b in ctx.HangDienThoais select b.TenHDT;
                foreach (var brand in brands)
                {
                    cbbBrand.Items.Add(brand);
                }

                var colors = from c in ctx.DienThoais group c by c.Mau into sc select sc.Key;
                foreach (var color in colors)
                {
                    cbbColors.Items.Add(color);
                }
            }
        }

        void LoadPhones()
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
                              Mau = p.Mau,
                              SoLuong = p.SoLuong,
                              Gia = p.Gia,
                              KhuyenMai = p.MauDienThoai.KM

                          };

                //var query = (from pb in ctx.HangDienThoais
                //             join mp in ctx.MauDienThoais on pb.MaHDT equals mp.MaHDT
                //             join p in ctx.DienThoais on mp.MaMDT equals p.MaMDT
                //             select new
                //             {
                //                 TenHang = pb.TenHDT,
                //                 MaMauDienThoai = mp.MaMDT,       
                //                 TenDienThoai = mp.TenDT,
                //                 MaDienThoai = p.MaDT,
                //                 Mau = p.Mau,
                //                 SoLuong = p.SoLuong,
                //                 Gia = p.Gia,
                //                 KhuyenMai = mp.KM
                //             });

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

                dgvPhones.DataSource = result.ToList();
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

                if (txtPhoneSearch.Text != "")
                {
                    var proc = ctx.pro_SearchPhones(txtPhoneSearch.Text);
                    var res = from pr in proc
                               join q in query on pr.MaDT equals q.MaDienThoai
                               select new
                               {
                                   MaDienThoai = pr.MaDT,
                                   TenDienThoai = pr.TenDT,
                                   Mau = pr.Mau,
                                   SoLuong = pr.SoLuong,
                                   Gia = pr.Gia,
                                   KhuyenMai = pr.KM
                               };

                    dgvPhones.DataSource = res.ToList();
                    dgvPhones.Columns[0].Visible = false;
                    dgvPhones.Columns[5].Visible = false;
                    dgvPhones.Refresh();
                }
            }
        }

        void LoadEmployee()
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

        void LoadCustomers()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var customer = from c in ctx.KhachHangs where c.SoDienThoai == txtPhoneNum.Text select c;
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
                }
                catch
                {
                    txtCustomer.Text = "";
                    datBirth.Value = new DateTime(2000, 1, 1);
                    txtEmail.Text = "";
                    txtAdress.Text = "";
                    radMale.Checked = false;
                    radFemale.Checked = false;

                    DialogResult answer =  MessageBox.Show("Không tìn thấy khách hàng. Bạn có muốn tạo mới không?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        var lastCusID = (from cus in ctx.KhachHangs orderby cus.MaKH descending select cus.MaKH).FirstOrDefault();
                        var lastID = (from hd in ctx.HoaDons orderby hd.MaHD descending select hd.MaHD).FirstOrDefault();
                        var newCus = new KhachHang { MaKH = lastCusID + 1, SoDienThoai = txtPhoneNum.Text };
                        ctx.KhachHangs.Add(newCus);
                        ctx.SaveChanges();
                    }
                }
            }
        }

        void CreateBills()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var cus = (from c in ctx.KhachHangs where c.SoDienThoai == txtPhoneNum.Text select c).FirstOrDefault();
                cus.TenKH = txtCustomer.Text;
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

        void ChoosePhones()
        {
            var cRow = dgvPhones.CurrentCell.RowIndex;
            var PhoneID = Int32.Parse(dgvPhones.Rows[cRow].Cells[0].FormattedValue.ToString());
            using (var ctx = new PhoneStoreManageEntities())
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

                //var countPhone = (from db in ctx.ChiTietHoadons where db.MaHD == billID && db.MaDT == PhoneID select db).Count();

                var detailBill = (from db in ctx.ChiTietHoadons
                                  where db.MaHD == billID
                                  select new
                                  {
                                      db.DienThoai.MaDT,
                                      //db.MaHD,
                                      db.DienThoai.MauDienThoai.TenDT,
                                      db.DienThoai.Mau,
                                      db.DienThoai.Gia
                                  });//.Distinct();
                dgvDetailBillPhones.DataSource = detailBill.ToList();
                dgvDetailBillPhones.Columns[0].Visible = false;
                dgvDetailBillPhones.Refresh();
                dgvPhones.Refresh();
            }
        }

        void FillPhone(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvPhones.CurrentRow.Selected = true;
                txtPhone.Text = dgvPhones.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtColor.Text = dgvPhones.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtAvailble.Text = dgvPhones.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtPrice.Text = dgvPhones.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtGift.Text = dgvPhones.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            }
        }

        #endregion

        #region Events
        private void hoaĐơnBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlSalebills.Visible = true;
            LoadEmployee();
            LoadComboBox();
            LoadPhones();
        }

        private void hoaĐơnSuaChuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Warrantys warrantys = new Warrantys();
            warrantys.Show();
        }

        private void thôngTinTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informations accounts = new Informations(username);
            accounts.Show();
        }

        private void quanLyTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {

        }

        private void cbbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPhones();
        }

        #endregion

        private void cbbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPhones();
        }

        private void btnPhoneNumFill_Click(object sender, EventArgs e)
        {
            LoadCustomers();
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            CreateBills();
            tabMainBill.SelectedTab = tabDetailBill;
        }

        private void txtPhoneSearch_Enter(object sender, EventArgs e)
        {
            LoadPhones();
        }
    }
}
