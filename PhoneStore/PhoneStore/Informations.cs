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
    public partial class Informations : Form
    {
        private string username;
        public Informations()
        {
            InitializeComponent();
            
        }

        public Informations(string Username) : this()
        {
            username = Username;
            LoadInfor();
        }

        private void LoadInfor()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var maNV = (from acc in ctx.Accounts where acc.Username == username select acc.MaNV).FirstOrDefault();
                var query = (from emp in ctx.NhanViens
                            where emp.MaNV == maNV
                            select emp);

                txtID.Text = maNV.ToString();
                txtName.Text = (from q in query select q.TenNV).FirstOrDefault();
                datBirth.Value = (from q in query select q.NgaySinh).FirstOrDefault().Value;

                if ((from q in query select q.GioiTinh).FirstOrDefault().ToString() == "Nam")
                    radMale.Checked = true;
                else
                    radFemale.Checked = true;

                txtPhone.Text = (from q in query select q.SoDienThoai).FirstOrDefault().ToString();
                txtPos.Text = (from q in query select q.ChucVu.TenCV).FirstOrDefault().ToString();
                txtSalary.Text = (from q in query select q.Luong).FirstOrDefault().ToString();
                txtAdress.Text = (from q in query select q.DiaChi).FirstOrDefault().ToString();
                txtContractID.Text = (from q in query select q.MaHopDong).FirstOrDefault().ToString();
                txtContractType.Text = (from q in query select q.HopDong.TenLoaiHopDong).FirstOrDefault().ToString();
                datStarted.Value = (from q in query select q.HopDong.Ngaybatdau).FirstOrDefault().Value;
                datEnd.Value = (from q in query select q.HopDong.Ngayketthuc).FirstOrDefault().Value; ;
                txtUsername.Text = username;
            }
        }

        private void ModifyInfor()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var maNV = Int32.Parse(txtID.Text);
                var query = (from q in ctx.NhanViens where q.MaNV == maNV select q).FirstOrDefault();
                var acc = (from a in ctx.Accounts where a.Username == username select a).FirstOrDefault();

                query.SoDienThoai = txtPhone.Text;
                query.DiaChi = txtAdress.Text;
                if (txtPass.Text == acc.Password)
                {
                    if (pnlChangePass.Visible)
                    {
                        if (txtNewPass.Text.Length > 5)
                        {
                            if (txtNewPass.Text == txtReNewPass.Text)
                            {
                                acc.Password = txtNewPass.Text;

                                ctx.SaveChanges();
                                txtPass.Text = "";
                                btnSave.Enabled = false;
                                pnlChangePass.Visible = false;
                                MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Mật khẩu không khớp!\nVui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("Mật khẩu phải có ít nhất 6 kí tự\nVui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else             
                    {
                        ctx.SaveChanges();
                        txtPass.Text = "";
                        btnSave.Enabled = false;
                        pnlChangePass.Visible = false;
                        MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Mật khẩu không đúng\nVui lòng kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            pnlChangePass.Visible = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ModifyInfor();           
        }

        private void txtHandle_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            if (btnSave.Enabled)
            {
                DialogResult answer = MessageBox.Show("Các thay đổi chưa được lưu\nBạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    LoadInfor();
                    btnSave.Enabled = false;
                    pnlChangePass.Visible = false;
                    txtPass.Text = "";
                }
            }
        }
    }
}
