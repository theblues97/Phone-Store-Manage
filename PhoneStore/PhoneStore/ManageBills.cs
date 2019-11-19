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
    public partial class ManageBills : Form
    {
        public ManageBills()
        {
            InitializeComponent();
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
    }
}
