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
    public partial class ManagePhones : Form
    {
        public string username;
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

        void LoadComboBox()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var brands = from b in ctx.HangDienThoais select b.TenHDT;
                foreach (var brand in brands)
                {
                    cbbBrand.Items.Add(brand);
                }

            }
        }

        void LoadPhoneSample()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var query = from q in ctx.MauDienThoais
                            select new
                            {
                                q.HangDienThoai.TenHDT,
                                q.TenDT,
                                q.NamSX,
                                q.KM,
                                q.MoTa
                            };

                if (cbbBrand.SelectedIndex > -1)
                {
                    query = from q in query
                            where
                            q.TenHDT == cbbBrand.SelectedItem.ToString()
                            select q;
                }

                dgvPhoneSamples.DataSource = query.ToList();
                dgvPhoneSamples.Columns[0].Visible = false;
                dgvPhoneSamples.Columns[1].HeaderText = "Tên điện thoại";
                dgvPhoneSamples.Columns[2].HeaderText = "Năm sản xuất";
                dgvPhoneSamples.Columns[3].HeaderText = "Khuyến mãi";
                dgvPhoneSamples.Columns[4].HeaderText = "Mô tả";
                dgvPhoneSamples.Refresh();
            }
        }

        void FillPhoneSamples(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvPhoneSamples.CurrentRow.Selected = true;

                txtBrand.Text = dgvPhoneSamples.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtPhoneSample.Text = dgvPhoneSamples.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                datProduce.Value = Convert.ToDateTime(dgvPhoneSamples.Rows[e.RowIndex].Cells[2].FormattedValue);
                txtPromotion.Text = dgvPhoneSamples.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtDescription.Text  = dgvPhoneSamples.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

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
    }
}
