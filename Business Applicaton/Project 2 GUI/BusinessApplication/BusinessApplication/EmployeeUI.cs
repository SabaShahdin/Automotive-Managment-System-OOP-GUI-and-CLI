using BusinessApplication.BL;
using BusinessApplication.DL;
using BusinessApplication.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApplication
{
    public partial class EmployeeUI : Form
    {
       
        public EmployeeUI()
        {
            InitializeComponent();
            string path = "Employee.txt";
            if (EmployeeDL.readFile(path))
            {
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            AdminPanel.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            AdminPanel.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeTab.Visible = true;
            EmployeeTab.SelectedTab = tabAdd;
           // tabAdd.Visible = true;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            Employee e2 = new Employee();
            string username = txtUsernames.Text;
            string password = txtpasswords.Text;
            string ManagerID = txtID.Text;
            bool flag2 = EmployeeDL.Check(password, username, ManagerID);
            bool usernameFlag = p.setUsername(username);
            bool passwordFlag = p.setPassword(password);
            bool ManagerFlag = e2.setID(ManagerID);
            if (usernameFlag && passwordFlag && ManagerFlag && flag2)
            {
                Person p1 = new Person(username, password, "Employee");
                Employee e1 = new Employee(username, password, ManagerID, "Employee");
                EmployeeDL.AddIntoList(e1);
                PersonDL.storeRoleInList(p1);
                txtResult.Visible = true;
                txtResult.Text = "Employee Added successfully";
            }
            else
            {
                txtResult.Visible = true;
                txtResult.Text = "Wrong form of input ";
            }
            ClearDataFromForm();
        }
        private void ClearDataFromForm()
        {
            txtUsernames.Text = "";
            txtpasswords.Text = "";
            txtID.Text = "";
        }

        private void EmployeeUI_Load(object sender, EventArgs e)
        {
            AdminPanel.Visible = true;
            EmployeeTab.Visible = false;
            EmployeeTab.Appearance = TabAppearance.FlatButtons;
            EmployeeTab.ItemSize = new Size(0, 1);
            tabView.Visible = false;
            tabAdd.Visible = false;
        }

        public void btnView_Click(object sender, EventArgs e)
        {
            EmployeeTab.Visible = true;
            tabAdd.Visible = false;
            EmployeeTab.SelectedTab = tabView;

            // tabView.Visible = true;
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
        public void tabView_Click(object sender, EventArgs e)
        {
            ConfigureViewGrid();
            ViewGrid.DataSource = EmployeeDL.Employee;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EmployeeTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            EmployeeTab.SelectedTab = tabDelete;

           // tabDelete.Visible = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string name = txtAnswer.Text;
            int index = EmployeeDL.searchEmployee(name);
            if (EmployeeDL.deleteEmployee(name))
            {
                txtResults.Visible = true;
                txtResults.Text = "Employee Found";
                EmployeeDL.Employee.RemoveAt(index);
                txtCon.Visible = true;
                txtCon.Text = " Employee removed successfully";
            }
            else
            {
                txtResults.Visible = false;
                txtResults.Text = "Manager not  Found";
            }
            txtAnswer.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            EmployeeTab.SelectedTab = tabUpdate;

           // tabUpdate.Visible = true;
        }

        private void radNames_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabUpdate.Visible = false;
            tabUpdateName.Visible = true;
        }

        private void radPassword_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabUpdate.Visible = false;
            tabUpdateName.Visible = false;
            tabUpdatePrice.Visible = true;
        }

        private void radID_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabUpdate.Visible = false;
            tabUpdateName.Visible = false;
            tabUpdatePrice.Visible = false;
            tabUpdateQuantity.Visible = true;
        }
        public void Closer()
        {
            EmployeeTab.Visible = false;
        }
        private void btnbacks_Click(object sender, EventArgs e)
        {
            Closer();
        }

        private void btnUpdates_Click(object sender, EventArgs e)
        {
            Person s = new Person();
            string name = txtEdit.Text;
            int index = EmployeeDL.searchEmployee(name);
            if (index != -1)
            {
                txtUpdateAnswer.Visible = true;
                txtUpdateAnswer.Text = "Employee Found";
                string names = txtNames.Text;
                bool usernameFlag = s.setUsername(name);
                if (usernameFlag)
                {
                    EmployeeDL.Employee[index].setUsername(names);
                    txtConclusion.Visible = true;
                    txtConclusion.Text = "Useranme updated successfully";
                }
                else
                {
                    txtConclusion.Visible = true;
                    txtConclusion.Text = "Username  can't be updated successfully";
                }
            }
            else
            {
                txtUpdateAnswer.Visible = true;
                txtUpdateAnswer.Text = "Employee not  Found";
            }
            txtEdit.Text = "";
            txtNames.Text = "";
        }

        private void btnBackes_Click(object sender, EventArgs e)
        {
            EmployeeTab.SelectedTab = tabUpdate;
        }

        private void btnPriceUpdate_Click(object sender, EventArgs e)
        {
            Person s = new Person();
            string name = txtOriginalName.Text.ToLower();
            int index = EmployeeDL.searchEmployee(name);
            if (index != -1)
            {
                txtinfo.Visible = true;
                txtinfo.Text = "Employee  Found";
                string password = txtUpdatedpassword.Text;
                bool usernameFlag = s.setPassword(password);
                if (usernameFlag)
                {
                    EmployeeDL.Employee[index].setPassword(password);
                    txtinfo1.Visible = true;
                    txtinfo1.Text = "Password  updated successfully";
                }
                else
                {
                    txtinfo1.Visible = true;
                    txtinfo1.Text = "Password can't be updated successfully";
                }
            }
            else
            {
                txtinfo.Visible = true;
                txtinfo.Text = "Employee not  Found";
            }
            txtOriginalName.Text = "";
            txtUpdatedpassword.Text = "";
        }

        private void btnBackButton_Click(object sender, EventArgs e)
        {
            EmployeeTab.SelectedTab = tabUpdate;
        }

        private void btnUpdaters_Click(object sender, EventArgs e)
        {
            Employee s = new Employee();
            string name = txtOrginalName.Text;
            int index = EmployeeDL.searchEmployee(name);
            if (index != -1)
            {
                txtUpdateinfo.Visible = true;
                txtUpdateinfo.Text = "Employee Found";
                string ID = txtUpdateIDS.Text;
                bool usernameFlag = s.setID(ID);
                if (usernameFlag)
                {
                    EmployeeDL.Employee[index].setID(ID);
                    txtInfos.Visible = true;
                    txtInfos.Text = "ID updated successfully";
                }
                else
                {
                    txtInfos.Visible = true;
                    txtInfos.Text = "ID  can't be updated ";
                }
            }
            else
            {
                txtUpdateinfo.Visible = true;
                txtUpdateinfo.Text = "Employee not  Found";
            }
            txtOrginalName.Text = "";
            txtUpdateIDS.Text = "";
        }

        private void btnBacker_Click(object sender, EventArgs e)
        {
            EmployeeTab.SelectedTab = tabUpdate;
        }

        private void btnBackers_Click(object sender, EventArgs e)
        {
            Closer();
        }

        public  void btnack_Click(object sender, EventArgs e)
        {
            Closer();
          
        }

    private void btnPic_Click(object sender, EventArgs e)
        {
            Closer();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EmployeeDL.storeInFile("Employee.txt");
            PersonDL.storeDataInFile("Person.txt");
            EmployeeDL.Employee.Clear();
            Form sign = new ManagerInterface();
            sign.Show();
            this.Hide();
        }

        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeDL.storeInFile("Employee.txt");
            PersonDL.storeDataInFile("Person.txt");
            EmployeeDL.Employee.Clear();
            Form sign = new ManagerInterface();
            sign.Show();
            this.Hide();
        }
       
    }
}
