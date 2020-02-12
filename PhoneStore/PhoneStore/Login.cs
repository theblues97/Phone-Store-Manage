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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        void CheckLogin()
        {
            using (var ctx = new PhoneStoreManageEntities())
            {
                var user = (from acc in ctx.Accounts where acc.Username == txtUsername.Text select acc.Username).FirstOrDefault();
                var pass = (from acc in ctx.Accounts where acc.Username == user select acc.Password).FirstOrDefault();
                if (String.Compare(user, txtUsername.Text, true) == 0 && String.Compare(pass, txtPassword.Text, false) == 0)
                {
                    this.Hide();
                    Home home = new Home(user);
                    home.ShowDialog();

                    this.Close();
                }
                else
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng\nVui lòng kiểm tra lại!", "Cảnh báo!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
