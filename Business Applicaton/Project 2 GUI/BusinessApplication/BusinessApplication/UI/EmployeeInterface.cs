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
    public partial class EmployeeInterface : Form
    {


        public EmployeeInterface()
        {
            InitializeComponent();
        }
        
        private void radProducts_CheckedChanged(object sender, EventArgs e)
        {
            if (radProducts.Checked == true)
            {
                Form form = new EmployeeView();
                form.Show();
                this.Hide();
            }
        }

        private void radMoney_CheckedChanged(object sender, EventArgs e)
        {
            if (radMoney.Checked == true)
            {
                Form form = new EmployeeMoney();
                form.Show();
                this.Hide();
            }
        }

        private void radSalary_CheckedChanged(object sender, EventArgs e)
        {
            if (radSalary.Checked == true)
            {
                Form form = new SalaryUI();
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
    }
}
