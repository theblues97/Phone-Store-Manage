﻿using System;
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
    public partial class ManagePhones : Form
    {
        public string username;
        private bool addFlag;
        private int phoneSampleID;

        private string nameBrand;
        private string nameColor;

        public ManagePhones()
        {
            InitializeComponent();
        }
        
        public ManagePhones(string Username): this()
        {
            username = Username;

            LoadComboBox();
            LoadPhoneSample();
        }

        private void LoadComboBox()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                cbbBrandFilter.Items.Clear();
                cbbEditBrand.Items.Clear();
                cbbColor.Items.Clear();

                var brands = from b in ctx.HangDienThoais select b.TenHDT;
                cbbBrandFilter.Items.AddRange(brands.ToArray());
                cbbEditBrand.Items.AddRange(brands.ToArray());
            }
        }

        private void LoadPhoneSample()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var query = from q in ctx.MauDienThoais
                            select new
                            {
                                q.MaMDT,
                                q.HangDienThoai.TenHDT,
                                q.TenDT,
                                q.NamSX,
                                q.KM,
                                q.MoTa
                            };

                if (cbbBrandFilter.SelectedIndex > -1)
                {
                    query = from q in query
                            where
                            q.TenHDT == cbbBrandFilter.SelectedItem.ToString()
                            select q;
                }

                dgvPhoneSamples.DataSource = query.ToList();
                dgvPhoneSamples.Columns[0].Visible = false;
                dgvPhoneSamples.Columns[1].Visible = false;
                dgvPhoneSamples.Columns[5].Visible = false;
                dgvPhoneSamples.Columns[2].HeaderText = "Tên điện thoại";
                dgvPhoneSamples.Columns[3].HeaderText = "Năm sản xuất";
                dgvPhoneSamples.Columns[4].HeaderText = "Khuyến mãi";
                dgvPhoneSamples.Refresh();
            }
        }

        private void LoadcbbColor()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                cbbColor.Items.Clear();
                cbbColor.Text = "";
                txtNumber.Text = "";
                txtEntryPrice.Text = "";
                txtSalePrice.Text = "";
                try
                {
                    var colors = from c in ctx.DienThoais where c.MaMDT == phoneSampleID group c by c.Mau into sc select sc.Key;
                    cbbColor.Items.AddRange(colors.ToArray());
                    cbbColor.SelectedIndex = 0;
                }
                catch { }
            }
        }

        private void FillPhoneSamples(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvPhoneSamples.CurrentRow.Selected = true;

                phoneSampleID = Convert.ToInt32(dgvPhoneSamples.Rows[e.RowIndex].Cells[0].FormattedValue);
                txtPhoneSampleID.Text = phoneSampleID.ToString();
                cbbEditBrand.SelectedItem = dgvPhoneSamples.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();               
                txtPhoneSample.Text = dgvPhoneSamples.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                datManufacturing.Value = Convert.ToDateTime(dgvPhoneSamples.Rows[e.RowIndex].Cells[3].FormattedValue);
                txtPromotion.Text = dgvPhoneSamples.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtDescription.Text  = dgvPhoneSamples.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();

                LoadcbbColor();                   
            }
        }

        private void Clean()
        {
            txtPhoneSampleID.Text = "";
            cbbEditBrand.SelectedIndex = -1;
            txtPhoneSample.Text = "";
            datManufacturing.Value = new DateTime(2000, 1, 1);
            txtPromotion.Text = "";
            txtDescription.Text = "";

            //cbbColor.SelectedIndex = -1;
            cbbColor.Items.Clear();
            cbbColor.Text = "";
            txtNumber.Text = "";
            txtEntryPrice.Text = "";
            txtSalePrice.Text = "";
        }

        private void Modify()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                if (addFlag) //add
                {

                    if (radBrandMode.Checked) //brand
                    {
                        try
                        {
                            var lastbrandID = (from b in ctx.HangDienThoais orderby b.MaHDT descending select b.MaHDT).FirstOrDefault();
                            var brand = new HangDienThoai
                            {
                                MaHDT = lastbrandID + 1,
                                TenHDT = cbbEditBrand.Text
                            };
                            ctx.HangDienThoais.Add(brand);

                            MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Thông tin nhập chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (radPhoneSampleMode.Checked) //sample phone
                    {
                        try
                        {
                            var brand = (from b in ctx.HangDienThoais where b.TenHDT == cbbEditBrand.SelectedItem.ToString() select b).FirstOrDefault();
                            var lastID = (from sp in ctx.MauDienThoais orderby sp.MaMDT descending select sp.MaMDT).FirstOrDefault();
                            var newsPhone = new MauDienThoai
                            {
                                MaMDT = lastID + 1,
                                TenDT = txtPhoneSample.Text,
                                NamSX = datManufacturing.Value,
                                KM = txtPromotion.Text,
                                MoTa = txtDescription.Text,
                                MaHDT = brand.MaHDT
                            };
                            ctx.MauDienThoais.Add(newsPhone);

                            MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Thông tin nhập chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else //phone
                    {
                        try
                        {
                            var lastID = (from p in ctx.DienThoais orderby p.MaDT descending select p.MaDT).FirstOrDefault();
                            var newPhone = new DienThoai
                            {
                                MaDT = lastID + 1,
                                MaMDT = Convert.ToInt32(txtPhoneSampleID.Text),
                                Mau = cbbColor.Text,
                                GiaNhap = Convert.ToInt32(txtEntryPrice.Text),
                                GiaBan = Convert.ToInt32(txtSalePrice.Text),
                                SoLuong = Convert.ToInt32(txtNumber.Text)
                            };
                            ctx.DienThoais.Add(newPhone);

                            MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch
                        {
                            MessageBox.Show("Thông tin nhập chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else //edit
                {
                    if (radBrandMode.Checked) //brand
                    {
                        try
                        {
                            var brand = (from b in ctx.HangDienThoais where b.TenHDT == nameBrand select b).FirstOrDefault();
                            brand.TenHDT = cbbEditBrand.Text;

                            MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Bạn chưa chọn hãng, hãy chọn hãng cần sửa trước khi thực hiện thao tác!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (radPhoneSampleMode.Checked) //sample phone
                    {
                        try
                        {
                            var phoneID = Int32.Parse(txtPhoneSampleID.Text);
                            var phone = (from p in ctx.MauDienThoais where p.MaMDT == phoneID select p).FirstOrDefault();

                            phone.TenDT = txtPhoneSample.Text;
                            phone.NamSX = datManufacturing.Value;
                            phone.KM = txtPromotion.Text;
                            phone.MoTa = txtDescription.Text;

                            MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Bạn chưa chọn mẫu điện thoại, hãy chọn mẫu điện thoại cần sửa trước khi thực hiện thao tác!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else //phone
                    {
                        try
                        {
                            var phone = (from p in ctx.DienThoais where p.MaMDT == phoneSampleID && p.Mau == cbbColor.SelectedItem.ToString() select p).FirstOrDefault();
                            phone.Mau = cbbColor.Text;
                            phone.SoLuong = Convert.ToInt32(txtNumber.Text);
                            phone.GiaNhap = Convert.ToInt32(txtEntryPrice.Text);
                            phone.GiaBan = Convert.ToInt32(txtSalePrice.Text);

                            MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Bạn chưa chọn điện thoại, hãy chọn điện thoại cần sửa trước khi thực hiện thao tác!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                ctx.SaveChanges();      
            }
        }

        private void LoadPrice()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var phone = (from p in ctx.DienThoais where p.MaMDT == phoneSampleID && p.Mau == cbbColor.SelectedItem.ToString() select p).FirstOrDefault();
                txtEntryPrice.Text = phone.GiaNhap.ToString();
                txtSalePrice.Text = phone.GiaBan.ToString();
                txtNumber.Text = phone.SoLuong.ToString();
            }
        }

        private void Delete()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                if (radBrandMode.Checked)
                {
                        DialogResult answer = MessageBox.Show("Tất cả mẫu điện thoại cũng sẽ bị xóa\nBạn muốn xóa hãng điện thoại thật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (answer == DialogResult.Yes)
                    {
                        if (nameBrand != null)
                        {
                            var dBill = (from db in ctx.ChiTietHoadons where db.DienThoai.MauDienThoai.HangDienThoai.TenHDT == nameBrand select db).FirstOrDefault();
                            if (dBill == null)
                            {
                                var phone = (from p in ctx.DienThoais where p.MauDienThoai.HangDienThoai.TenHDT == nameBrand select p).FirstOrDefault();
                                if (phone == null)
                                {
                                    var brand = (from b in ctx.HangDienThoais where b.TenHDT == nameBrand select b).FirstOrDefault();
                                    var sphones = (from p in ctx.MauDienThoais where p.MaHDT == brand.MaHDT select p).ToList();

                                    ctx.MauDienThoais.RemoveRange(sphones);
                                    ctx.HangDienThoais.Remove(brand);
                                    ctx.SaveChanges();

                                    cbbEditBrand.Text = "";

                                    MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                    MessageBox.Show("Không thể xóa hãng do điện thoại của hãng còn trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Không thể xóa hãng do điện thoại tồn tại trong hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Bạn chưa chọn hãng, hãy chọn hãng cần xóa trước khi thực hiện thao tác!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (radPhoneSampleMode.Checked)
                {
                    DialogResult answer = MessageBox.Show("Bạn muốn xóa mẫu điện thoại thật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (answer == DialogResult.Yes)
                    {
                        try
                        {
                            var examphoneID = Convert.ToInt32(txtPhoneSampleID.Text);
                            var dBill = (from db in ctx.ChiTietHoadons where db.DienThoai.MauDienThoai.MaMDT == examphoneID select db).FirstOrDefault();
                            if (dBill == null)
                            {
                                var phone = (from p in ctx.DienThoais where p.MauDienThoai.MaMDT == examphoneID select p).FirstOrDefault();
                                if (phone == null)
                                {
                                    var examPhone = (from xp in ctx.MauDienThoais where xp.MaMDT == examphoneID select xp).FirstOrDefault();

                                    ctx.MauDienThoais.Remove(examPhone);
                                    ctx.SaveChanges();

                                    MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                    MessageBox.Show("Không thể xóa mẫu điện thoại do điện thoại của mẫu còn trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Không thể xóa mẫu điện thoại do điện thoại của mẫu tồn tại trong hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch
                        {
                            MessageBox.Show("Bạn chưa chọn mẫu điện thoại, hãy chọn mẫu điện thoại cần xóa trước khi thực hiện thao tác!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult answer = MessageBox.Show("Tất cả mẫu điện thoại cũng sẽ bị xóa\nBạn muốn xóa điện thoại thật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (answer == DialogResult.Yes)
                    {
                        try
                        {
                            var examphoneID = Convert.ToInt32(txtPhoneSampleID.Text);
                            var color = cbbColor.SelectedItem.ToString();
                            var dBill = (from db in ctx.ChiTietHoadons where db.DienThoai.MauDienThoai.MaMDT == examphoneID && db.DienThoai.Mau == color select db).FirstOrDefault();
                            if (dBill == null)
                            {
                                var phones = (from p in ctx.DienThoais where p.MauDienThoai.MaMDT == examphoneID && p.Mau == color select p).FirstOrDefault();
                                if (phones != null)
                                {
                                    ctx.DienThoais.Remove(phones);
                                    ctx.SaveChanges();

                                    LoadcbbColor();

                                    MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                                MessageBox.Show("Không thể xóa mẫu điện thoại do điện thoại của mẫu tồn tại trong hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch
                        {
                            MessageBox.Show("Bạn chưa chọn điện thoại, hãy chọn điện thoại cần xóa trước khi thực hiện thao tác!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void dgvPhoneSamples_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillPhoneSamples(e);
        }

        private void cbbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPhoneSample();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Modify();
            LoadComboBox();
            LoadPhoneSample();
            if (!radBrandMode.Checked) Clean();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addFlag = true;
            //cbbEditBrand.Enabled = true;
            btnClean.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            addFlag = false;
            btnClean.Enabled = true;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            LoadComboBox();
            LoadPhoneSample();
            if (!radBrandMode.Checked) Clean();
        }

        private void radHandle_CheckedChange(object sender, EventArgs e)
        {
            cbbEditBrand.Enabled = radBrandMode.Checked || radPhoneSampleMode.Checked;
            pnlPhoneSample.Enabled = radPhoneSampleMode.Checked;
            pnlPhone.Enabled = radPhoneMode.Checked;
        }

        private void infoHandle_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void cbbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPrice();
            try
            {
                nameColor = cbbColor.SelectedItem.ToString();
            }
            catch { }

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadPhoneSample();
        }

        private void cbbEditBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                nameBrand = cbbEditBrand.SelectedItem.ToString();
            }
            catch { }
        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {
            Clean();
        }
    }
}
