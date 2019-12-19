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
    public partial class Home : Form
    {
        public string username;
        public int billID;

        Bills bills;
        Warrantys warrantys;
        Informations accounts;
        ManageEmployees manageEmployees;
        ManagePhones managePhones;
        ManageCustomer manageCustomer;

        StatisticBills statisticBills;

        public Home()
        {
            InitializeComponent();          
        }

        public Home(string Username) : this()
        {
            username = Username;
            lblUsernames.Text = username;

            bills = new Bills(username);
            warrantys = new Warrantys(username);
            accounts = new Informations(username);
            statisticBills = new StatisticBills(username);
            manageEmployees = new ManageEmployees(username);
            managePhones = new ManagePhones(username);
            manageCustomer = new ManageCustomer(username);
        }

        private bool CheckExistForm(string name)
        {
            foreach(Form form in this.MdiChildren)
            {
                if (form.Name == name)
                    return true;
            }
            return false;
        }

        private void ActiveChildForm(string name)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == name)
                {
                    form.Activate();
                    break;
                }
            }
        }

        #region Events
        private void hoaĐơnBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Bills"))
            {            
                bills.MdiParent = this;
                bills.Show();
                bills.Location = new Point(0, 0);
            }
            else
                ActiveChildForm("Bills");
        }

        private void hoaĐơnSuaChuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Warrantys"))
            {
                warrantys.MdiParent = this;
                warrantys.Show();
                warrantys.Location = new Point(0, 0);
            }
            else
                ActiveChildForm("Warrantys");
        }

        private void thôngTinTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Informations"))
            {
                accounts.MdiParent = this;
                accounts.Show();
                accounts.Location = new Point(0, 0);
            }
            else
                ActiveChildForm("Informations");
        }

        private void quanLyĐiênThoaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("ManagePhones"))
            {
                managePhones.MdiParent = this;
                managePhones.Show();
                managePhones.Location = new Point(0, 0);
            }
            else
                ActiveChildForm("ManagePhones");
        }

        private void quanLyNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("ManageEmployees"))
            {
                manageEmployees.MdiParent = this;
                manageEmployees.Show();
                manageEmployees.Location = new Point(0, 0);
            }
            else
                ActiveChildForm("ManageEmployees");
        }

        private void quanLyKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("ManageCustomer"))
            {
                manageCustomer.MdiParent = this;
                manageCustomer.Show();
                manageCustomer.Location = new Point(0, 0);
            }
            else
                ActiveChildForm("ManageCustomer");
        }

        private void thongKeHoaĐơnBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("StatisticBills"))
            {
                statisticBills.MdiParent = this;
                statisticBills.Show();
                statisticBills.Location = new Point(0, 0);
            }
            else
                ActiveChildForm("StatisticBills");
        }
        #endregion


    }
}
