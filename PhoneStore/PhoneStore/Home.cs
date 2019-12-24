using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        ManageBills manageBills;
        Statistics statistics;

        public Home()
        {
            InitializeComponent();
            this.FormClosing += Home_Closing;
        }

        public Home(string Username) : this()
        {
            username = Username;
            lblUsernames.Text = username;

            bills = new Bills(username);
            warrantys = new Warrantys(username);
            accounts = new Informations(username);
            manageBills = new ManageBills(username);
            manageEmployees = new ManageEmployees(username);
            managePhones = new ManagePhones(username);
            manageCustomer = new ManageCustomer(username);
            statistics = new Statistics(username);

            hoaĐơnBanHangToolStripMenuItem.PerformClick();
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
            if (Utilities.Permit(username) < 3)
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
            else
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void quanLyNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utilities.Permit(username) < 3)
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
            else
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void quanLyKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utilities.Permit(username) < 2)
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
            else
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void quanLyHoaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utilities.Permit(username) < 2)
            {
                if (!CheckExistForm("ManageBills"))
                {
                    manageBills.MdiParent = this;
                    manageBills.Show();
                    manageBills.Location = new Point(0, 0);
                }
                else
                    ActiveChildForm("ManageBills");
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thôngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utilities.Permit(username) < 3)
            {
                if (!CheckExistForm("Statistics"))
                {
                    statistics.MdiParent = this;
                    statistics.Show();
                    statistics.Location = new Point(0, 0);
                }
                else
                    ActiveChildForm("Statistics");
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Home_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (this.DialogResult == DialogResult.Cancel)
            {

                switch (MessageBox.Show(this, "Bạn muốn thoát thật không?", "Quetion?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        bills.Close();
                        break;
                }
            }
        }

        private void trơGiupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = string.Format("{0}Resources\\help.chm", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            Help.ShowHelp(this, filePath);
        }
        #endregion


    }
}
