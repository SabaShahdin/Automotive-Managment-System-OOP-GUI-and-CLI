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
    public partial class SalaryUI : Form
    {
        public SalaryUI()
        {
            InitializeComponent();
            string path = "Employee.txt";
            if (EmployeeDL.readFile(path))
            {
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            string workHours = txtProductName.Text;
            string ID = tXTIDS.Text;
            if (int.TryParse(workHours, out int workHour) && EmployeeDL.checkID(ID))
            {
                if (e1.setWorkHour(workHour))
                {
                    int salary = e1.calculateSalary();
                    Staff e2 = new Staff(ID, workHour, "Employee", salary);
                    txtResult.Visible = true;
                    string s = salary.ToString();
                    txtResult.Text = "Salary on the basis of Hour you work are " + s;
                    StaffDL.storeSalaryInList(e2);
                }
            }
            else
            {
                txtResult.Visible = true;
                txtResult.Text =  "Wrong format of input OR Employee Doesnot exist";
            }
        }
        private void btnPic_Click(object sender, EventArgs e)
        {
            Form form = new EmployeeInterface();
            form.Show();
            this.Hide();
        }
    }
}
