using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApplication.UI
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        private void chkLogin_CheckedChanged(object sender, EventArgs e)
        {
            if(chkLogin.Checked)
            {
                Form roleForm = new Role();
                roleForm.Show();
                this.Hide();
                chkLogin.Checked = false;
            }
        }

        private void chkExit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExit.Checked)
            {
                Form form = new Exit();
                form.Show();
                this.Hide();
            }
        }
    }
}
