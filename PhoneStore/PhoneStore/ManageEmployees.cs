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
        public string username;
        public ManageEmployees()
        {
            InitializeComponent();
        }
        public ManageEmployees(string Username) : this()
        {
            username = Username;
            MELoadEmployees();
        }

        void MELoadEmployees()
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

                dgvME.DataSource = ems.ToList();
                dgvME.Columns[10].Visible = false;
                dgvME.Columns[11].Visible = false;
                dgvME.Columns[0].HeaderText = "MSNV";
                dgvME.Columns[1].HeaderText = "Nhân viên";
                dgvME.Columns[2].HeaderText = "Giới tính";
                dgvME.Columns[3].HeaderText = "Ngày sinh";
                dgvME.Columns[4].HeaderText = "Số điện thoại";
                dgvME.Columns[5].HeaderText = "Lương";
                dgvME.Columns[6].HeaderText = "Email";
                dgvME.Columns[7].HeaderText = "Địa chỉ";
                dgvME.Columns[8].HeaderText = "Chức vụ";
                dgvME.Columns[9].HeaderText = "Hợp đồng";

                dgvME.Refresh();
            }
        }

        void MEFillInfor(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvME.CurrentRow.Selected = true;
                var MEID = Convert.ToInt32(dgvME.Rows[e.RowIndex].Cells[0].FormattedValue);
                txtMEID.Text = MEID.ToString();
                txtMEName.Text = dgvME.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                if (dgvME.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() == "Nam")
                    radMEMale.Checked = true;
                else
                    radMEFemale.Checked = true;

                datMEBirth.Value = Convert.ToDateTime(dgvME.Rows[e.RowIndex].Cells[3].FormattedValue);
                txtMEPhone.Text = dgvME.Rows[e.RowIndex].Cells[4].FormattedValue.ToString(); 
                txtMESalary.Text = dgvME.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                txtMEEmail.Text = dgvME.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                txtMEAdress.Text = dgvME.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                cbbMEPos.SelectedItem = dgvME.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                cbbMEContract.SelectedItem = dgvME.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
                datMEStart.Value = Convert.ToDateTime(dgvME.Rows[e.RowIndex].Cells[10].FormattedValue);
                datMEEnd.Value = Convert.ToDateTime(dgvME.Rows[e.RowIndex].Cells[11].FormattedValue);
                
                using (var ctx = new PhoneStoreManageEntities())
                {

                    var acc = from ac in ctx.Accounts where ac.MaNV == MEID select ac;
                    txtMEUsername.Text = (from ac in acc select ac.Username).FirstOrDefault();
                    txtMEPass.Text = (from ac in acc select ac.Password).FirstOrDefault();
                }
            }
        }

        private void dgvME_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MEFillInfor(e);
        }
    }
}
