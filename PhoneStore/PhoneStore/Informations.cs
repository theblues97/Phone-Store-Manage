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
        public string username;
        public Informations()
        {
            InitializeComponent();
            
        }

        public Informations(string Username) : this()
        {
            username = Username;
            LoadInfor();
        }

        void LoadInfor()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var maNV = (from acc in ctx.Accounts where acc.Username == username select acc.MaNV).FirstOrDefault();
                var query = (from emp in ctx.NhanViens
                            where emp.MaNV == maNV
                            select emp);

                txtEmpID.Text = maNV.ToString();
                txtEmpName.Text = (from q in query select q.TenNV).FirstOrDefault();
                datEmpBirth.Value = (from q in query select q.NgaySinh).FirstOrDefault().Value;

                if ((from q in query select q.GioiTinh).FirstOrDefault().ToString() == "Nam")
                    radEmpMale.Checked = true;
                else
                    radEmpFemale.Checked = true;

                txtEmpPhone.Text = (from q in query select q.SoDienThoai).FirstOrDefault().ToString();
                txtEmpPos.Text = (from q in query select q.ChucVu.TenCV).FirstOrDefault().ToString();
                txtEmpSalary.Text = (from q in query select q.Luong).FirstOrDefault().ToString();
                txtEmpAdress.Text = (from q in query select q.DiaChi).FirstOrDefault().ToString();
                txtEmpContractID.Text = (from q in query select q.MaHopDong).FirstOrDefault().ToString();
                txtContractType.Text = (from q in query select q.HopDong.TenLoaiHopDong).FirstOrDefault().ToString();
                datEmpStart.Value = (from q in query select q.HopDong.Ngaybatdau).FirstOrDefault().Value;
                datEmpEnd.Value = (from q in query select q.HopDong.Ngayketthuc).FirstOrDefault().Value; ;
                txtEmpUsername.Text = username;
                txtEmpPass.Text = (from acc in ctx.Accounts where acc.Username == username select acc.Password).FirstOrDefault();


            }

        }
    }
}
