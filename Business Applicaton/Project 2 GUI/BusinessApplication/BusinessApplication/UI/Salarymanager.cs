using BusinessApplication.BL;
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
    public partial class Salarymanager : Form
    {
        public Salarymanager()
        {
            InitializeComponent();
            string path = "Manager.txt";
            if (ManagerDL.readManagerFile(path))
            {
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Manager e1 = new Manager();
            string workHours = txtProductName.Text;
            string ID = tXTIDS.Text;
            if (int.TryParse(workHours, out int workHour) && ManagerDL.checkManagerID(ID))
            {
                if (e1.setWorkHour(workHour))
                {
                    int salary = e1.calculateSalary();
                    Staff e2 = new Staff(ID, workHour, "Manager", salary);
                    string s = salary.ToString();
                    txtResult.Visible = true;
                    txtResult.Text = "Salary on the basis of Hour you work are " + salary;
                    StaffDL.storeSalaryInList(e2);
                }
            }
            else
            {
                txtResult.Visible = true;
                txtResult.Text = "Wrong format of input OR Manager Doesnot exist";
            }
        }
        private void btnPic_Click(object sender, EventArgs e)
        {
            Form form = new ManagerInterface();
            form.Show();
            this.Hide();
        }
    }
}
