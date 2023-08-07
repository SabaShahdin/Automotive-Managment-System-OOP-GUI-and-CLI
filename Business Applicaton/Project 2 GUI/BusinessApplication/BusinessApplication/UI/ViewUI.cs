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
    public partial class ViewUI : Form
    {
        public ViewUI()
        {
            InitializeComponent();

        }
        private void ViewUI_Load(object sender, EventArgs e)
        {
            AdminPanel.Visible = true;
            ViewTab.Visible = false;
            ViewTab.Appearance = TabAppearance.FlatButtons;
            ViewTab.ItemSize = new Size(0, 1);
          
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            string path = "Employee.txt";
            if (EmployeeDL.readFile(path))
            {
            }
            ViewTab.Visible = true;
            ViewTab.SelectedTab = tabView;
            tabDelete.Visible = false;
            tabUpdateName.Visible = false;
            tabSalary.Visible = false;
            if(tabView.Visible == true)
            {
                Condition();
            }
            dataBind();
        }
        public void dataBind()
        {
            ViewGrid.DataSource = null;
            ViewGrid.DataSource = EmployeeDL.Employee;
            ConfigureViewGrid();
            ViewGrid.Refresh();
        }
        public void ConfigureViewGrid()
        {
            ViewGrid.Columns.Remove("WorkHours");
            ViewGrid.Columns.Remove("Salary");
            ViewGrid.Columns.Remove("Role");
            foreach (DataGridViewColumn column in ViewGrid.Columns)
            {
                if (column.Name != "ID" && column.Name != "UserName" && column.Name != "Password")
                {
                    column.Visible = false;
                }
            }
            ViewGrid.Columns["ID"].Visible = true;
            ViewGrid.Columns["UserName"].Visible = true;
            ViewGrid.Columns["Password"].Visible = true;

        }     
        private void btnack_Click(object sender, EventArgs e)
        {
            ViewTab.Visible = false;
            tabView.Visible = false;
            EmployeeDL.Employee.Clear();
            Conditions();
        }
        private void tabView_Click(object sender, EventArgs e)
        {
            ConfigureViewGrid();
            ViewGrid.DataSource = EmployeeDL.Employee;
        }
        private void btnBackers_Click(object sender, EventArgs e)
        {
            ViewTab.Visible = false;
            tabView.Visible = false;
            MoneySellDL.Money.Clear();
            Conditions();
        }
        private void btnViewMoneySell_Click(object sender, EventArgs e)
        {
            string path = "MoneySell.txt";
            if (MoneySellDL.readMoneySellFile(path))
            {
            }
            ViewTab.Visible = true;
            tabView.Visible = false;
            // tabDelete.Visible = true; // Set tabDelete.Visible to true
            ViewTab.SelectedTab = tabDelete;
            tabUpdateName.Visible = false;
            tabSalary.Visible = false;
            if (tabDelete.Visible == true)
            {
                Condition();
            }
            dataBind1();
        }
        public void dataBind1()
        {
            GridV.DataSource = null;
            GridV.DataSource = MoneySellDL.Money;
            GridV.Refresh();
        }
        private void tabDelete_Click(object sender, EventArgs e)
        {
            GridV.DataSource = MoneySellDL.Money;
        }
        public void Condition ()
        {
            btnView.Enabled = false;
            btnDelete.Enabled = false;
            btnViewMoneySell.Enabled = false;
            btnUpdate.Enabled = false;

        }
        private void tabUpdateName_Click(object sender, EventArgs e)
        {
            ViewGrids.DataSource = MoneyRepairDL.MoneyRepair;
        }
        public void dataBind2()
        {
            ViewGrids.DataSource = null;
            ViewGrids.DataSource = MoneyRepairDL.MoneyRepair;
            ViewGrids.Refresh();
        }
        private void btnBackes_Click(object sender, EventArgs e)
        {
            ViewTab.Visible = false;
            
            MoneyRepairDL.MoneyRepair.Clear();
            Conditions();


        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string path = "MoneyRepair.txt";
            if (MoneyRepairDL.readMoneyRepairFile(path))
            {
            }
            ViewTab.Visible = true;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabSalary.Visible = false;
            ViewTab.SelectedTab = tabUpdateName;
            if(tabUpdateName.Visible == true)
            {
                Condition();
            }
            dataBind2();
        }
        private void Salary_Click(object sender, EventArgs e)
        {
            ConfigureSalaryGrid();
            SalaryGrid.DataSource = StaffDL.Salary;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string path = "Salary.txt";
            if (StaffDL.readSalaryFile(path))
            {
            }
            ViewTab.Visible = true;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabUpdateName.Visible = false;
            ViewTab.SelectedTab = tabSalary;
            if(tabSalary.Visible == true)
            {
                Condition();
            }
           // tabSalary.Visible = true;
           dataBind3();
        }
        public void Conditions()
        {
            btnView.Enabled = true;
            btnDelete.Enabled = true;
            btnViewMoneySell.Enabled = true;
            btnUpdate.Enabled = true;
        }
        public void dataBind3()
        {
            SalaryGrid.DataSource = null;
            SalaryGrid.DataSource = StaffDL.Salary;
            ConfigureSalaryGrid();
            SalaryGrid.Refresh();
        }
        public void ConfigureSalaryGrid()
        {
            SalaryGrid.Columns.Remove("UserName");
            SalaryGrid.Columns.Remove("Password");
            foreach (DataGridViewColumn column in SalaryGrid.Columns)
            {
                if (column.Name != "WorkHours" && column.Name != "Salary"  && column.Name != "Role" && column.Name != "ID")
                {
                    column.Visible = false;
                }
            }
            SalaryGrid.Columns["WorkHours"].Visible = true;
            SalaryGrid.Columns["Salary"].Visible = true;
            SalaryGrid.Columns["Role"].Visible = true;
            SalaryGrid.Columns["ID"].Visible = true;
        }
        private void btnBackess_Click(object sender, EventArgs e)
        {
            ViewTab.Visible = false;         
            StaffDL.Salary.Clear();
            Conditions();
        }
       private void btnClose_Click(object sender, EventArgs e)
        {
            AdminPanel.Hide();
        }
        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form sign = new AdminInterface();
            sign.Show();
            this.Hide();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            StaffDL.Salary.Clear();
            MoneyRepairDL.MoneyRepair.Clear();
            EmployeeDL.Employee.Clear();
            MoneySellDL.Money.Clear();
            Form sign = new AdminInterface();
            sign.Show();
            this.Hide();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            AdminPanel.Show();
        }

       
    }
}
