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
    public partial class ManageCustomer : Form
    {
        public string username;
        public ManageCustomer()
        {
            InitializeComponent();
        }
        public ManageCustomer(string Username) : this()
        {
            username = Username;

            LoadCustomers();
        }

        private void LoadCustomers()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var query = from q in ctx.KhachHangs
                            select new
                            {
                                q.MaKH,
                                q.TenKH,
                                q.GioiTinh,
                                q.NgaySinh,
                                q.SoDienThoai,
                                q.Email,
                                q.DiaChi
                            };

                dgvMC.DataSource = query.ToList();
                dgvMC.Columns[2].Visible = false;
                dgvMC.Columns[6].Visible = false;
                dgvMC.Columns[0].HeaderText = "Mã KH";
                dgvMC.Columns[1].HeaderText = "Khách hàng";
                //dgvMC.Columns[2].HeaderText = "Giới tính";
                dgvMC.Columns[3].HeaderText = "Ngày sinh";
                dgvMC.Columns[4].HeaderText = "Số đ.thoại";
                dgvMC.Columns[5].HeaderText = "Email";
                dgvMC.Refresh();
            }
        }

        private void FillInfor(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvMC.CurrentRow.Selected = true;

                txtCusID.Text = dgvMC.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtCus.Text = dgvMC.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                if (dgvMC.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() == "Nam")
                    radMale.Checked = true;
                else
                    radFemale.Checked = true;
                datBirth.Value = Convert.ToDateTime(dgvMC.Rows[e.RowIndex].Cells[3].FormattedValue);
                txtPhone.Text = dgvMC.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtEmail.Text = dgvMC.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                txtAdress.Text = dgvMC.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            }
        }

        private void dgvMC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillInfor(e);
        }
    }
}
