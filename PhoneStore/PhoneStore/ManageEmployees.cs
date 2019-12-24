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
    public partial class ManageEmployees : Form
    {
        private string username;
        private bool addFlag;
        public ManageEmployees()
        {
            InitializeComponent();
        }
        public ManageEmployees(string Username) : this()
        {
            username = Username;
            LoadEmployees();
            LoadComboBox();
            addFlag = false;

            pnlContract.Visible = Utilities.Permit(username) == 1; 
        }

        private void LoadComboBox()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var pos = from p in ctx.ChucVus select p.TenCV;
                cbbPosition.Items.AddRange(pos.ToArray());
            }
        }

        private void LoadEmployees()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var ems = from e in ctx.NhanViens
                          select new
                          {
                              e.MaNV,
                              e.TenNV,
                              e.GioiTinh,
                              e.NgaySinh,
                              e.SoDienThoai,
                              e.Luong,
                              e.Email,
                              e.DiaChi,
                              e.ChucVu.TenCV,
                              e.HopDong.TenLoaiHopDong,
                              e.HopDong.Ngaybatdau,
                              e.HopDong.Ngayketthuc                    
                          };
                if(txtSearchEmp.Text != "")
                {
                    var empID = Convert.ToInt32(txtSearchEmp.Text);
                    var result = from ne in ems where ne.MaNV == empID select ne;
                    dgvME.DataSource = result.ToList();
                }
                else
                    dgvME.DataSource = ems.ToList();

                dgvME.Columns[2].Visible = false;
                dgvME.Columns[3].Visible = false;
                dgvME.Columns[4].Visible = false;
                dgvME.Columns[6].Visible = false;
                dgvME.Columns[7].Visible = false;
                dgvME.Columns[10].Visible = false;
                dgvME.Columns[11].Visible = false;

                dgvME.Columns[0].HeaderText = "Mã NV";
                dgvME.Columns[1].HeaderText = "Nhân viên";
                dgvME.Columns[5].HeaderText = "Lương";
                dgvME.Columns[8].HeaderText = "Chức vụ";
                dgvME.Columns[9].HeaderText = "Hợp đồng";

                dgvME.Columns[0].FillWeight = 100;
                dgvME.Columns[1].FillWeight = 200;
                dgvME.Columns[5].FillWeight = 100;
                dgvME.Columns[8].FillWeight = 100;
                dgvME.Columns[9].FillWeight = 100;

                dgvME.Refresh();
            }
        }

        private void FillInfor(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvME.CurrentRow.Selected = true;
                var MEID = Convert.ToInt32(dgvME.Rows[e.RowIndex].Cells[0].FormattedValue);
                txtID.Text = MEID.ToString();
                txtName.Text = dgvME.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                if (dgvME.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() == "Nam")
                    radMale.Checked = true;
                else
                    radFemale.Checked = true;

                datBirth.Value = Convert.ToDateTime(dgvME.Rows[e.RowIndex].Cells[3].FormattedValue);
                txtPhone.Text = dgvME.Rows[e.RowIndex].Cells[4].FormattedValue.ToString(); 
                txtSalary.Text = dgvME.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                txtEmail.Text = dgvME.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                txtAdress.Text = dgvME.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                cbbPosition.SelectedItem = dgvME.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                cbbContract.SelectedItem = dgvME.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
                datStart.Value = Convert.ToDateTime(dgvME.Rows[e.RowIndex].Cells[10].FormattedValue);
                datEnd.Value = Convert.ToDateTime(dgvME.Rows[e.RowIndex].Cells[11].FormattedValue);
                
                using (var ctx = new PhoneStoreManageEntities())
                {
                    var acc = from ac in ctx.Accounts where ac.MaNV == MEID select ac;
                    txtUsername.Text = (from ac in acc select ac.Username).FirstOrDefault();
                    txtPassword.Text = (from ac in acc select ac.Password).FirstOrDefault();
                }
            }
        }

        private void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            datBirth.Value = new DateTime(2000, 1, 1);
            radFemale.Checked = false;
            radMale.Checked = false;
            txtEmail.Text = "";
            txtAdress.Text = "";

            cbbContract.SelectedIndex = 0;
            cbbPosition.SelectedIndex = 2;
            DateTime ptime = DateTime.Now;
            datStart.Value = new DateTime(ptime.Year, ptime.Month, ptime.Day);
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void Modify()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                if(addFlag)
                {
                    try
                    {
                        var lastConID = (from co in ctx.HopDongs orderby co.MaHopDong descending select co.MaHopDong).FirstOrDefault();
                        var lastEmpID = (from cu in ctx.NhanViens orderby cu.MaNV descending select cu.MaNV).FirstOrDefault();

                        var newCon = new HopDong
                        {
                            MaHopDong = lastConID + 1,
                            TenLoaiHopDong = cbbContract.SelectedItem.ToString(),
                            Ngaybatdau = datStart.Value,
                            Ngayketthuc = datEnd.Value
                        };

                        var newEmp = new NhanVien
                        {
                            MaNV = lastEmpID + 1,
                            TenNV = txtName.Text,
                            GioiTinh = radMale.Checked ? "Nam" : "Nữ",
                            NgaySinh = datBirth.Value,
                            SoDienThoai = txtPhone.Text,
                            Luong = Convert.ToInt32(txtSalary.Text),
                            Email = txtEmail.Text,
                            DiaChi = txtAdress.Text,
                            MaCV = cbbPosition.SelectedIndex + 1,
                            MaHopDong = lastConID + 1
                        };

                        var newAcc = new Account
                        {
                            Username = txtUsername.Text,
                            Password = txtPassword.Text,
                            MaNV = lastEmpID + 1
                        };

                        ctx.HopDongs.Add(newCon);
                        ctx.NhanViens.Add(newEmp);
                        ctx.Accounts.Add(newAcc);
                        MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Thông tin nhập chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        var empID = Convert.ToInt32(txtID.Text);
                        var emp = (from cu in ctx.NhanViens where cu.MaNV == empID select cu).FirstOrDefault();
                        var con = (from co in ctx.HopDongs where co.MaHopDong == emp.MaHopDong select co).FirstOrDefault();
                        var acc = (from ac in ctx.Accounts where ac.MaNV == empID select ac).FirstOrDefault();

                        con.TenLoaiHopDong = cbbContract.SelectedItem.ToString();
                        con.Ngaybatdau = datStart.Value;
                        con.Ngayketthuc = datEnd.Value;

                        emp.TenNV = txtName.Text;
                        emp.GioiTinh = radMale.Checked ? "Nam" : "Nữ";
                        emp.NgaySinh = datBirth.Value;
                        emp.SoDienThoai = txtPhone.Text;
                        emp.Luong = Convert.ToInt32(txtSalary.Text);
                        emp.Email = txtEmail.Text;
                        emp.DiaChi = txtAdress.Text;
                        emp.MaCV = cbbPosition.SelectedIndex + 1;

                        acc.Username = txtUsername.Text;
                        acc.Password = txtPassword.Text;

                        MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Bạn chưa chọn nhân viên, hãy chọn nhân viên cần sửa trước khi thực hiện thao tác!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ctx.SaveChanges();
            }
        }

        private void Delete()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                DialogResult answer = MessageBox.Show("Nhân viên, hợp đồng\nBạn chắc chắn chứ?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(answer == DialogResult.Yes)
                {
                    try
                    {
                        var empID = Convert.ToInt32(txtID.Text);
                        var bill = (from b in ctx.HoaDons where b.MaNV == empID select b).FirstOrDefault();
                        var warr = (from w in ctx.SuaChuas where w.MaNV == empID select w).FirstOrDefault();
                        if (bill == null && warr == null)
                        {
                            var acc = (from ac in ctx.Accounts where ac.MaNV == empID select ac).FirstOrDefault();
                            var emp = (from cu in ctx.NhanViens where cu.MaNV == empID select cu).FirstOrDefault();
                            var con = (from co in ctx.HopDongs where co.MaHopDong == emp.MaHopDong select co).FirstOrDefault();

                            if (acc != null) ctx.Accounts.Remove(acc);
                            ctx.HopDongs.Remove(con);
                            ctx.NhanViens.Remove(emp);
                            ctx.SaveChanges();

                            MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Không thể xóa nhân viên tồn tại trong hóa đơn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        MessageBox.Show("Bạn chưa chọn nhân viên, hãy chọn nhân viên cần xóa trước khi thực hiện thao tác!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvME_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillInfor(e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clear();
            addFlag = true;
            pnlInformation.Enabled = true;
            pnlContract.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            addFlag = false;
            pnlInformation.Enabled = true;
            pnlContract.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Utilities.Permit(username) < 2)
            {
                Delete();
                LoadEmployees();
                Clear();
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbbContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addFlag)
            {
                DateTime ptime = DateTime.Now;
                datEnd.Value = cbbContract.SelectedIndex == 0 ? new DateTime(ptime.Year, ptime.Month, ptime.Day).AddYears(3) :
                    new DateTime(ptime.Year, ptime.Month, ptime.Day).AddMonths(3);
            }
        }

        private void infoHandle_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Modify();
            LoadEmployees();
        }

        private void btnEmpSearch_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }
    }
}
