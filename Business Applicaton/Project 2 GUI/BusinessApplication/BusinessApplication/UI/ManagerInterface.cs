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
    public partial class ManagerInterface : Form
    {
        public ManagerInterface()
        {
            InitializeComponent();
        }

        private void radProducts_CheckedChanged(object sender, EventArgs e)
        {
            if(radProducts.Checked == true)
            {
                Form form = new ManagerView();
                form.Show();
                this.Hide();
            }
        }
        private void radEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if(radEmployee.Checked == true)
            {
                Form form = new EmployeeUI();
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
        private void radSalary_CheckedChanged(object sender, EventArgs e)
        {
            if(radSalary.Checked == true)
            {
                Form form = new Salarymanager();
                form.Show();
                this.Hide();
            }
        }

        private void radMoney_CheckedChanged(object sender, EventArgs e)
        {
            if (radMoney.Checked == true)
            {
                Form form = new ManagerMoney();
                form.Show();
                this.Hide();
            }
        }
    }
}
