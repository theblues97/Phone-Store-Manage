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
        public ManageCustomer()
        {
            InitializeComponent();
        }
        public ManageCustomer(string Username) : this()
        {
            username = Username;
        }

    }
}
