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
                var phonebrands = ctx.HangDienThoais;
                var modelphones = ctx.MauDienThoais;
                var phones = ctx.DienThoais;

                var query = (from pb in phonebrands
                             join mp in modelphones on pb.MaHDT equals mp.MaHDT
                             join p in phones on mp.MaMDT equals p.MaMDT
                             select new
                             {
                                 TenHang = pb.TenHDT,
                                 MaMauDienThoai = mp.MaMDT,       
                                 TenDienThoai = mp.TenDT,
                                 MaDienThoai = p.MaDT,
                                 Mau = p.Mau,
                                 SoLuong = p.SoLuong,
                                 Gia = p.Gia,
                                 KhuyenMai = mp.KM
                             });


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
                                  //join q in query on pr.tendt equals q.tendienthoai
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
                }
            }
        }

        void ChoosePhones()
        {
            var cRow = dgvPhones.CurrentCell.RowIndex;
            var PhoneID = dgvPhones.Rows[cRow].Cells[0].FormattedValue.ToString();

            using (var ctx = new PhoneStoreManageEntities())
            {

            }
        }

        #endregion

        #region Events
        private void hoaĐơnBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlSalebills.Visible = true;
            LoadEmployee();
        }

        private void hoaĐơnSuaChuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Warrantys warrantys = new Warrantys();
            warrantys.Show();
        }

        private void thôngKêKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngKêBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngKêĐiênThoaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informations accounts = new Informations();
            accounts.Show();
        }

        private void quanLyTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            pnlPhoneArea.Visible = true;
            LoadComboBox();
            LoadPhones();
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

        private void btnList_Click(object sender, EventArgs e)
        {
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
