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
            LoadWarranty();
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
                dgvBill.DataSource = query.ToList();
                dgvBill.Columns[3].Visible = false;
                dgvBill.Columns[4].Visible = false;
                dgvBill.Columns[6].Visible = false;
                dgvBill.Columns[7].Visible = false;
                dgvBill.Columns[0].HeaderText = "Mã HD";
                dgvBill.Columns[1].HeaderText = "Mã NV";
                dgvBill.Columns[2].HeaderText = "Nhân viên";
                //dgvBill.Columns[3].HeaderText = "Khách hàng";
                //dgvBill.Columns[4].HeaderText = "Ngày mua";
                dgvBill.Columns[5].HeaderText = "Bảo hành";
                dgvBill.Columns[8].HeaderText = "Tổng tiền";
                dgvBill.Refresh();
            }
        }

        void LoadWarranty()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var query = from wa in ctx.SuaChuas
                            select new
                            {
                                wa.MaSC,
                                wa.MaHD,
                                wa.MaNV,
                                wa.NhanVien.TenNV,
                                wa.TenDienThoai,
                                wa.KhachHang.TenKH,
                                wa.NgayNhan,
                                wa.PhiSC,
                                wa.PTThanhToan,
                                wa.NoiDung
                            };
                dgvWa.DataSource = query.ToList();
                dgvWa.Columns[1].Visible = false;
                dgvWa.Columns[5].Visible = false;
                dgvWa.Columns[8].Visible = false;
                dgvWa.Columns[9].Visible = false;
                dgvWa.Columns[0].HeaderText = "Mã HD";
                dgvWa.Columns[2].HeaderText = "Mã NV";
                dgvWa.Columns[3].HeaderText = "Nhân viên";
                dgvWa.Columns[4].HeaderText = "Điện thoại";
                dgvWa.Columns[6].HeaderText = "Ngày nhận";
                dgvWa.Columns[7].HeaderText = "Phí SC";
                dgvWa.Refresh();

            }
        }

        void FillBills(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvBill.CurrentRow.Selected = true;

                txtBiEmployeeID.Text = dgvBill.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtBiEmployee.Text = dgvBill.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtBiCustomer.Text = dgvBill.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtBillID.Text = dgvBill.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                datBiPurchase.Value = Convert.ToDateTime(dgvBill.Rows[e.RowIndex].Cells[4].FormattedValue);
                datBiWarranty.Value = Convert.ToDateTime(dgvBill.Rows[e.RowIndex].Cells[5].FormattedValue);
                cbbBiBuyMethod.SelectedItem = dgvBill.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                cbbBiPayMethod.SelectedItem = dgvBill.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                lblBiTotalMoney.Text = dgvBill.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();

                var billID = Convert.ToInt32(dgvBill.Rows[e.RowIndex].Cells[0].FormattedValue);
                using (var ctx = new PhoneStoreManageEntities())
                {
                    var detailBill = (from b in ctx.ChiTietHoadons
                                      select new
                                      {
                                          b.MaHD,
                                          b.MaDT,
                                          b.DienThoai.MauDienThoai.TenDT,
                                          b.DienThoai.Mau,
                                          b.DienThoai.GiaBan
                                      }).Distinct();

                    var countList = from db in ctx.ChiTietHoadons
                                    join p in ctx.DienThoais on db.MaDT equals p.MaDT
                                    join b in ctx.HoaDons on db.MaHD equals b.MaHD
                                    group db by new { db.MaHD, db.MaDT, db.DienThoai.GiaBan } into dbs
                                    orderby dbs.Key.MaHD
                                    select new
                                    {
                                        dbs.Key,
                                        Count = dbs.Count(),
                                        Total = dbs.Count() * dbs.Key.GiaBan
                                    };
                    var query = from bill in detailBill
                                join list in countList on
                                new { bill.MaHD, bill.MaDT } equals
                                new { list.Key.MaHD, list.Key.MaDT }
                                into result
                                from r in result.DefaultIfEmpty()
                                where bill.MaHD == billID
                                select new
                                {
                                    bill.TenDT,
                                    bill.Mau,
                                    bill.GiaBan,
                                    r.Count,
                                    r.Total
                                };
                    dgvBiDetailBill.DataSource = query.ToList();
                    dgvBiDetailBill.Columns[0].HeaderText = "Điện thoại";
                    dgvBiDetailBill.Columns[1].HeaderText = "Màu";
                    dgvBiDetailBill.Columns[2].HeaderText = "Giá";
                    dgvBiDetailBill.Columns[3].HeaderText = "Số lượng";
                    dgvBiDetailBill.Columns[4].HeaderText = "Thành tiền";
                    dgvBiDetailBill.Refresh();
                }
            }
        }

        void FillWaBill(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvWa.CurrentRow.Selected = true;

                txtWaWaBillID.Text = dgvWa.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtWaBillID.Text = dgvWa.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtWaEmpID.Text = dgvWa.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtWaEmp.Text = dgvWa.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtWaPhone.Text  = dgvWa.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtWaCus.Text = dgvWa.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                datWaRecive.Value = Convert.ToDateTime(dgvWa.Rows[e.RowIndex].Cells[6].FormattedValue);
                txtWaCost.Text = dgvWa.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                cbbWaPayMethod.SelectedItem = dgvWa.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                txtWaContent.Text = dgvWa.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            }
        }

        private void dgvBillList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillBills(e);
        }


        private void dgvWa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillWaBill(e);
        }
    }
}
