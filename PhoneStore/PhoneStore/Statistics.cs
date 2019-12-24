using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts.Events;
using Brushes = System.Windows.Media.Brushes;

namespace PhoneStore
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        public Statistics(string Username) : this()
        {
            cbbType.SelectedIndex = 0;
        }

        private void Bills()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {

                List<string> label = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                int[] values = new int[12];

                var dbills = from db in ctx.ChiTietHoadons select db;
                foreach(var db in dbills)
                {
                    var date = db.HoaDon.NgayMua;
                    values[date.Value.Month - 1]++;
                }

                cscChart.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = "Điện thoại",
                        Values = new ChartValues<int>()
                    }
                };

                cscChart.Series[0].Values.AddRange(values.Cast<object>());
                cscChart.AxisX.Add(new Axis
                {
                    Title = "Thời gian",
                    Labels = label,
                    MinValue = 0,
                    MaxValue = 11
                });

                cscChart.AxisY.Add(new Axis
                {
                    Title = "Số lượng",
                    LabelFormatter = value => value.ToString("N")
                });

                cscChart.LegendLocation = LegendLocation.Right;
            }
        }

        private void Business()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                List<string> label = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                double[] entrys = new double[12];
                double[] sales = new double[12];
                var dbills = from db in ctx.ChiTietHoadons select db;
                foreach(var db in dbills)
                {
                    var entry = Convert.ToDouble(db.DienThoai.GiaNhap)/1000000;
                    var sale = Convert.ToDouble(db.DienThoai.GiaBan)/1000000;
                    var date = db.HoaDon.NgayMua;

                    entrys[date.Value.Month - 1] += entry;
                    sales[date.Value.Month - 1] += sale;
                }

                cscChart.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = "Tổng thu",
                        Values = new ChartValues<double>()
                    },
                    new LineSeries
                    {
                        Title = "Tổng chi",
                        Values = new ChartValues<double>()
                    }
                };

                cscChart.Series[0].Values.AddRange(sales.Cast<object>());
                cscChart.Series[1].Values.AddRange(entrys.Cast<object>());
                cscChart.AxisX.Add(new Axis
                {
                    Title = "Thời gian",
                    Labels = label,
                    MinValue = 0,
                    MaxValue = 11
                });

                cscChart.AxisY.Add(new Axis
                {
                    Title = "Tổng tiền (triệu)",
                    LabelFormatter = value => value.ToString("N"),                   
                });

                cscChart.LegendLocation = LegendLocation.Right;
            }
        }

        private void PreviousOnClick(object sender, EventArgs e)
        {
            if (cscChart.AxisX[0].MinValue > 0)
            {
                cscChart.AxisX[0].MinValue -= 2;
                cscChart.AxisX[0].MaxValue -= 2;
            }
        }

        private void NextOnClick(object sender, EventArgs e)
        {
            cscChart.AxisX[0].MinValue += 2;
            cscChart.AxisX[0].MaxValue += 2;
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cscChart.AxisX.Clear();
            cscChart.AxisY.Clear();
            if (cbbType.SelectedIndex == 0)
                Bills();
            else if (cbbType.SelectedIndex == 1)
                Business();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            cscChart.AxisX.Clear();
            cscChart.AxisY.Clear();
            if (cbbType.SelectedIndex == 0)
                Bills();
            else if (cbbType.SelectedIndex == 1)
                Business();
        }
    }
}
