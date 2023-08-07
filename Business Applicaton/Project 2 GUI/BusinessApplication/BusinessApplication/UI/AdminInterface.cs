using BusinessApplication.DL;
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
    public partial class AdminInterface : Form
    {
        public AdminInterface()
        {
            InitializeComponent();
        }

        private void radbtnSelling_CheckedChanged(object sender, EventArgs e)
        {
            if(radbtnSelling.Checked)
            {
                Form form = new SellingUI();
                form.Show();
                this.Hide();
            }           
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form form = new MainScreen();
            form.Show();
            this.Hide();
        }

        private void AdminInterface_Load(object sender, EventArgs e)
        {

        }

        private void radbtnRepairing_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnRepairing.Checked)
            {
                Form form = new RepairingUI();
                form.Show();
                this.Hide();
            }
        }
        private void radbtnManager_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnManager.Checked)
            {
                Form form = new ManagerUI();
                form.Show();
                this.Hide();
            }
        }   
        private void radbtnMoney_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnMoney.Checked)
            {
                Form form = new ViewUI();
                form.Show();
                this.Hide();
            }
        }
    }
}
