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
    public partial class Warrantys : Form
    {
        public string username;
        public int billID;
        public int cusID;
        public Warrantys()
        {
            InitializeComponent();
        }

        public Warrantys(string Username) : this()
        {
            username = Username;
            InitLoad();
        }

        void InitLoad()
        {
            DateTime time = DateTime.Now;
            datWaReceive.Value = new DateTime(time.Year, time.Month, time.Day);

            using (var ctx = new PhoneStoreManageEntities())
            {
                var emp = (from em in ctx.Accounts where em.Username == username select em).FirstOrDefault();
                txtWaEmpID.Text = emp.MaNV.ToString();
                txtWaEmpName.Text = emp.NhanVien.TenNV.ToString();
            }
        }

        void LoadCustomers()
        {
            dgvWaBills.DataSource = null;
            dgvWaPhoneBill.DataSource = null;

            using (var ctx = new PhoneStoreManageEntities())
            {
                var customer = from c in ctx.KhachHangs where c.SoDienThoai == txtWaPhoneNum.Text select c;
                try
                {
                    txtWaCustomer.Text = (from c in customer select c.TenKH).FirstOrDefault().ToString();
                    datWaBirth.Value = (from c in customer select c.NgaySinh).FirstOrDefault().Value;
                    txtWaEmail.Text = (from c in customer select c.Email).FirstOrDefault().ToString();
                    txtWaAdress.Text = (from c in customer select c.DiaChi).FirstOrDefault().ToString();

                    if ((from c in customer select c.GioiTinh).FirstOrDefault().ToString() == "Nam")
                        radWaMale.Checked = true;
                    else
                        radWaFemale.Checked = true;


                    cusID = (from c in customer select c.MaKH).FirstOrDefault();
                    var bill = from b in ctx.HoaDons
                               where b.MaKH == cusID
                               select new
                               {
                                   b.MaHD,
                                   b.MaKH,
                                   b.NhanVien.TenNV,
                                   b.NgayMua,
                                   b.HanBH,
                                   b.Tongtien
                               };
                    dgvWaBills.DataSource = bill.ToList();
                    dgvWaBills.Columns[0].HeaderText = "Mã HD";
                    dgvWaBills.Columns[1].HeaderText = "Mã KH";
                    dgvWaBills.Columns[2].HeaderText = "Nhân viên";
                    dgvWaBills.Columns[3].HeaderText = "Ngày mua";
                    dgvWaBills.Columns[4].HeaderText = "Hạn bảo hành";
                    dgvWaBills.Columns[5].HeaderText = "Tổng tiền";
                    dgvWaBills.Refresh();

                }
                catch
                {
                    txtWaCustomer.Text = "";
                    datWaBirth.Value = new DateTime(2000, 1, 1);
                    txtWaEmail.Text = "";
                    txtWaAdress.Text = "";
                    radWaMale.Checked = false;
                    radWaFemale.Checked = false;

                    DialogResult answer = MessageBox.Show("Không tìn thấy khách hàng. Bạn có muốn tạo mới không?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        var lastCusID = (from cus in ctx.KhachHangs orderby cus.MaKH descending select cus.MaKH).FirstOrDefault();
                        var newCus = new KhachHang { MaKH = lastCusID + 1, SoDienThoai = txtWaPhoneNum.Text };
                        cusID = lastCusID + 1;
                        ctx.KhachHangs.Add(newCus);
                        ctx.SaveChanges();
                    }
                }
            }
        }

        void LoadDetailBill(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvWaBills.CurrentRow.Selected = true;
                billID = Int32.Parse(dgvWaBills.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
                using (var ctx = new PhoneStoreManageEntities())
                {
                    var debills = from db in ctx.ChiTietHoadons where db.MaHD == billID
                                  select new
                                  {
                                      db.DienThoai.MauDienThoai.TenDT,
                                      db.DienThoai.Mau,
                                      db.DienThoai.Gia
                                  };

                    dgvWaPhoneBill.DataSource = debills.ToList();
                    dgvWaPhoneBill.Columns[0].HeaderText = "Điện thoại";
                    dgvWaPhoneBill.Columns[1].HeaderText = "Màu";
                    dgvWaPhoneBill.Columns[2].HeaderText = "Giá";
                }
            }
        }

        void CheckedInfor(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvWaPhoneBill.CurrentRow.Selected = true;

                txtWaPhoneName.Text = dgvWaPhoneBill.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();


                using (var ctx = new PhoneStoreManageEntities())
                {
                    cbbWaPayMethod.SelectedItem = (from b in ctx.HoaDons where b.MaHD == billID select b.PTThanhToan).FirstOrDefault();
                }
            }
        }

        void CreateWarranty()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {

                var cus = (from c in ctx.KhachHangs where c.SoDienThoai == txtWaPhoneNum.Text select c).FirstOrDefault();
                cus.TenKH = txtWaCustomer.Text;
                cus.GioiTinh = radWaMale.Checked ? "Nam" : "Nữ";
                cus.NgaySinh = datWaBirth.Value;
                cus.Email = txtWaEmail.Text;
                cus.DiaChi = txtWaAdress.Text;

                var lastWaID = (from wa in ctx.SuaChuas orderby wa.MaSC descending select wa.MaSC).FirstOrDefault();

                try
                {
                    if(billID != 0)
                        ctx.pro_CreateWarrantys(lastWaID + 1, txtWaPhoneName.Text, datWaReceive.Value, Int32.Parse(txtWaCharge.Text),
                            cbbWaPayMethod.SelectedItem.ToString(), txtWaNotices.Text, cusID, Int32.Parse(txtWaEmpID.Text), billID);
                    else
                        ctx.pro_CreateWarrantys(lastWaID + 1, txtWaPhoneName.Text, datWaReceive.Value, Int32.Parse(txtWaCharge.Text),
                            cbbWaPayMethod.SelectedItem.ToString(), txtWaNotices.Text, cusID, Int32.Parse(txtWaEmpID.Text), null);

                    MessageBox.Show("Thêm thành công!","Information",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công\n Hãy kiểm tra lại các trường thông tin!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ctx.SaveChanges();
            }
        }

        private void btnWaPhoneNumFill_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void dgvWaBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDetailBill(e);
        }

        private void dgvWaPhoneBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CheckedInfor(e);
        }

        private void btnWaCreate_Click(object sender, EventArgs e)
        {
            CreateWarranty();
        }
    }
}
