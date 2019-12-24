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
        private bool addFlag;
        public ManageCustomer()
        {
            InitializeComponent();
        }
        public ManageCustomer(string Username) : this()
        {
            username = Username;          
            LoadCustomers();
            addFlag = false;
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
               
                if (txtSearchCus.Text == "")
                    dgvMC.DataSource = query.ToList();
                else
                {
                    var proc = ctx.pro_SearchCustomers(txtSearchCus.Text);
                    var result = from pr in proc
                                 join q in query on pr.MaKH equals q.MaKH
                                 select pr;
                    dgvMC.DataSource = result.ToList();
                }

                dgvMC.Columns[2].Visible = false;
                dgvMC.Columns[6].Visible = false;
                dgvMC.Columns[0].HeaderText = "Mã KH";
                dgvMC.Columns[1].HeaderText = "Khách hàng";
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

                txtID.Text = dgvMC.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtName.Text = dgvMC.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
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
        }

        private void Modify()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                if (addFlag)
                {
                    try
                    {
                        var lastCusID = (from c in ctx.KhachHangs orderby c.MaKH descending select c.MaKH).FirstOrDefault();

                        var newCus = new KhachHang
                        {
                            MaKH = lastCusID + 1,
                            TenKH = txtName.Text,
                            NgaySinh = datBirth.Value,
                            GioiTinh = radMale.Checked ? "Nam" : "Nữ",
                            SoDienThoai = txtPhone.Text,
                            Email = txtEmail.Text,
                            DiaChi = txtAdress.Text
                        };
                        ctx.KhachHangs.Add(newCus);
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
                        var cusID = Convert.ToInt32(txtID.Text);
                        var cus = (from c in ctx.KhachHangs where c.MaKH == cusID select c).FirstOrDefault();

                        cus.TenKH = txtName.Text;
                        cus.NgaySinh = datBirth.Value;
                        cus.GioiTinh = radMale.Checked ? "Nam" : "Nữ";
                        cus.SoDienThoai = txtPhone.Text;
                        cus.Email = txtEmail.Text;
                        cus.DiaChi = txtAdress.Text;
                        MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Bạn chưa chọn khách hàng, hãy chọn khách hàng cần sửa trước khi thực hiện thao tác!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ctx.SaveChanges();
            }
        }

        private void Delete()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                DialogResult answer = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng chứ?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(answer == DialogResult.Yes)
                {
                    try
                    {
                        var cusID = Convert.ToInt32(txtID.Text);

                        var bill = (from b in ctx.HoaDons where b.MaKH == cusID select b).FirstOrDefault();
                        var warr = (from w in ctx.SuaChuas where w.MaNV == cusID select w).FirstOrDefault();
                        if (bill == null && warr == null)
                        {
                            var cus = (from c in ctx.KhachHangs where c.MaKH == cusID select c).FirstOrDefault();
                            ctx.KhachHangs.Remove(cus);
                            ctx.SaveChanges();

                            MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Không thể xóa khách hàng tồn tại trong hóa đơn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        MessageBox.Show("Bạn chưa chọn khách hàng, hãy chọn khách hàng cần xóa trước khi thực hiện thao tác!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvMC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillInfor(e);
        }

        private void btnPhoneSearch_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addFlag = true;
            Clear();
            pnlInfor.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlInfor.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Delete();
            LoadCustomers();
            Clear();
            btnSave.Enabled = false;
        }

        private void txtSearchCus_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Modify();
            LoadCustomers();
        }
    }
}