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
        public Home()
        {
            InitializeComponent();
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
                                 q.MaMauDienThoai,
                                 q.TenDienThoai,
                                 q.Mau,
                                 q.SoLuong,
                                 q.Gia,
                                 q.KhuyenMai
                             };

                dgvPhones.DataSource = result.ToList();
                dgvPhones.Columns[0].Visible = false;
                dgvPhones.Refresh();

                if (txtPhoneSearch.Text != "")
                {
                    var proc = ctx.pro_SearchPhones(txtPhoneSearch.Text);
                    var res = from pr in proc
                                  //join q in query on pr.tendt equals q.tendienthoai
                              select new
                              {
                                  MaMauDienThoai = pr.MaMDT,
                                  TenDienThoai = pr.TenDT,
                                  Mau = pr.Mau,
                                  SoLuong = pr.SoLuong,
                                  Gia = pr.Gia,
                                  KhuyenMai = pr.KM
                              };

                    dgvPhones.DataSource = res.ToList();
                    dgvPhones.Columns[0].Visible = false;
                    dgvPhones.Refresh();
                }
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

        void LoadBillList()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var query = from q in ctx.HoaDons
                            select new
                            {
                                MaHD = q.MaHD,
                                MaKH = q.MaKH,
                                MaNV = q.MaNV,
                                NgayMua = q.NgayMua,
                                HanBaoHanh = q.HanBH,
                                PTMuaHang = q.PTMuaHang,
                                PTThanhToan = q.PTThanhToan,
                                TongTien = q.Tongtien
                            };
                dgvBillList.DataSource = query.ToList();
                dgvBillList.Refresh();
            }
        }
        #endregion

        #region Events
        private void hoaĐơnBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlSalebills.Visible = true;
            pnlBillList.Visible = true;
            LoadBillList();
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
            Accounts accounts = new Accounts();
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
                txtPhone.Text = dgvPhones.Rows[e.RowIndex].Cells["TenDienThoai"].FormattedValue.ToString();
                txtColor.Text = dgvPhones.Rows[e.RowIndex].Cells["Mau"].FormattedValue.ToString();
                txtAvailble.Text = dgvPhones.Rows[e.RowIndex].Cells["SoLuong"].FormattedValue.ToString();
                txtPrice.Text = dgvPhones.Rows[e.RowIndex].Cells["Gia"].FormattedValue.ToString();
                txtGift.Text = dgvPhones.Rows[e.RowIndex].Cells["KhuyenMai"].FormattedValue.ToString();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            pnlBillList.Visible = true;
        }
    }
}
