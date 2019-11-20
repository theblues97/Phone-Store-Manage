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
    public partial class StatisticBills : Form
    {
        public string username;
        public StatisticBills()
        {
            InitializeComponent();
        }

        public StatisticBills(string Username):this()
        {
            username = Username;

            LoadBillList();
        }
        void LoadBillList()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var query = from q in ctx.HoaDons
                            select new
                            {
                                q.MaHD,
                                q.MaNV,
                                q.NhanVien.TenNV,
                                q.KhachHang.TenKH,
                                q.NgayMua,
                                q.HanBH,
                                q.PTMuaHang,
                                q.PTThanhToan,
                                q.Tongtien
                            };
                var a = query.ToList();
                dgvBillList.DataSource = query.ToList();
                dgvBillList.Columns[0].Visible = false;
                dgvBillList.Columns[6].Visible = false;
                dgvBillList.Columns[7].Visible = false;
                dgvBillList.Columns[1].HeaderText = "Mã nhân viên";
                dgvBillList.Columns[2].HeaderText = "Nhân viên";
                dgvBillList.Columns[3].HeaderText = "Khách hàng";
                dgvBillList.Columns[4].HeaderText = "Ngày mua";
                dgvBillList.Columns[5].HeaderText = "Bảo hành";
                dgvBillList.Columns[8].HeaderText = "Tổng tiền";
                dgvBillList.Refresh();
            }
        }

        void FillBills(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvBillList.CurrentRow.Selected = true;

                txtEmployeeID.Text = dgvBillList.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtEmployee.Text = dgvBillList.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtCustomer.Text = dgvBillList.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                datPurchase.Value = Convert.ToDateTime(dgvBillList.Rows[e.RowIndex].Cells[4].FormattedValue);
                datWarranty.Value = Convert.ToDateTime(dgvBillList.Rows[e.RowIndex].Cells[5].FormattedValue);
                cbbBuyMethod.SelectedItem = dgvBillList.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                cbbPayMethod.SelectedItem = dgvBillList.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                txtTotalMoney.Text = dgvBillList.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();

                var billID = Convert.ToInt32(dgvBillList.Rows[e.RowIndex].Cells[0].FormattedValue);
                using (var ctx = new PhoneStoreManageEntities())
                {
                    var query = from q in ctx.ChiTietHoadons where q.MaHD == billID
                                select new
                                {
                                    q.MaCTHD,
                                    q.DienThoai.MauDienThoai.TenDT,
                                    q.DienThoai.Mau,
                                    q.DienThoai.Gia
                                };
                    dgvDetailBill.DataSource = query.ToList();
                    dgvDetailBill.Columns[0].Visible = false;
                    dgvDetailBill.Columns[1].HeaderText = "Tên điện thoại";
                    dgvDetailBill.Columns[2].HeaderText = "Màu";
                    dgvDetailBill.Columns[3].HeaderText = "Giá";
                    dgvDetailBill.Refresh();
                }
            }
        }

        private void dgvBillList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillBills(e);
        }
    }
}
