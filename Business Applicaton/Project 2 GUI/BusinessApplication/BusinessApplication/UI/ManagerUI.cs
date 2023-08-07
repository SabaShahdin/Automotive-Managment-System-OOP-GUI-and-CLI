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
    public partial class ManagerUI : Form
    {
        public ManagerUI()
        {
            InitializeComponent();
            string path = "Manager.txt";
            if (ManagerDL.readManagerFile(path))
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
            ManagerTab.Visible = true;
            tabAdd.Visible = true;
        }

        private void ManagerUI_Load(object sender, EventArgs e)
        {
            AdminPanel.Visible = true;
            ManagerTab.Visible = false;
            ManagerTab.Appearance = TabAppearance.FlatButtons;
            ManagerTab.ItemSize = new Size(0, 1);
            tabView.Visible = false;
            tabAdd.Visible = false;
        }
        private void ClearDataFromForm()
        {
            txtUsernames.Text = "";
            txtpasswords.Text = "";
            txtID.Text = "";
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            Manager e2 = new Manager();
            string username = txtUsernames.Text;
            string password = txtpasswords.Text;
            string ManagerID = txtID.Text;
            bool flag2 = ManagerDL.CheckManager(password, username, ManagerID);
            bool usernameFlag = p.setUsername(username);
            bool passwordFlag = p.setPassword(password);
            bool ManagerFlag = e2.setID(ManagerID);
            if (usernameFlag && passwordFlag && ManagerFlag && flag2)
            {
                Person p1 = new Person(username, password, "Manager");
                Manager e1 = new Manager(username, password, ManagerID, "Manager");
                ManagerDL.AddIntoManangerList(e1);
                PersonDL.storeRoleInList(p1);
                txtResult.Visible = true;
                txtResult.Text = "Manager Added successfully";
            }
            else
            {
                txtResult.Visible = true;
                txtResult.Text = "Wrong form of input ";
            }
            ClearDataFromForm();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ManagerTab.Visible = true;
            tabAdd.Visible = false;
           // tabView.Visible = true;
            ManagerTab.SelectedTab = tabView;
            dataBind();
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
        public void dataBind()
        {
            ViewGrid.DataSource = null;
            ViewGrid.DataSource = ManagerDL.Manager;
            ViewGrid.Refresh();
            ConfigureViewGrid();
        }
        private void tabView_Click(object sender, EventArgs e)
        {
            ViewGrid.DataSource = ManagerDL.Manager;
            ConfigureViewGrid();
        }
        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManagerDL.storeManagerInFile("Manager.txt");
            PersonDL.storeDataInFile("Person.txt");
            ManagerDL.Manager.Clear();
            Form sign = new AdminInterface();
            sign.Show();
            this.Hide();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerDL.storeManagerInFile("Manager.txt");
            PersonDL.storeDataInFile("Person.txt");
            ManagerDL.Manager.Clear();
            Form sign = new AdminInterface();
            sign.Show();
            this.Hide();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            string name = txtAnswer.Text;
            int index = ManagerDL.searchManager(name);
            if (ManagerDL.deleteManager(name))
            {
                txtResults.Visible = true;
                txtResults.Text = "Manager Found";
                ManagerDL.Manager.RemoveAt(index);
                txtCon.Visible = true;
                txtCon.Text = "Manager  removed successfully";
            }
            else
            {
                txtResults.Visible = false;
                txtResults.Text = "Manager not  Found";
            }
            txtAnswer.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ManagerTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            ManagerTab.SelectedTab = tabDelete;
           // tabDelete.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ManagerTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            ManagerTab.SelectedTab = tabUpdate;
            // tabUpdate.Visible = true;

        }

        private void radNames_CheckedChanged(object sender, EventArgs e)
        {
            ManagerTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabUpdate.Visible = false;
            tabUpdateName.Visible = true;
        }

        private void radPassword_CheckedChanged(object sender, EventArgs e)
        {
            ManagerTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabUpdate.Visible = false;
            tabUpdateName.Visible = false;
            tabUpdatePrice.Visible = true;
        }

        private void radID_CheckedChanged(object sender, EventArgs e)
        {
            ManagerTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabUpdate.Visible = false;
            tabUpdateName.Visible = false;
            tabUpdatePrice.Visible = false;
            tabUpdateQuantity.Visible = true;
        }

        private void btnUpdates_Click(object sender, EventArgs e)
        {
            Person s = new Person();
            string name = txtEdit.Text;
            int index = ManagerDL.searchManager(name);
            if (index != -1)
            {
                txtUpdateAnswer.Visible = true;
                txtUpdateAnswer.Text = "Product Found";
                string names = txtNames.Text;
                bool usernameFlag = s.setUsername(name);
                if (usernameFlag)
                {
                    ManagerDL.Manager[index].setUsername(names);
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
                txtUpdateAnswer.Text = "Manager not  Found";
            }
            txtEdit.Text = "";
            txtNames.Text = "";
        }

        private void btnPriceUpdate_Click(object sender, EventArgs e)
        {

            Person s = new Person();
            string name = txtOriginalName.Text.ToLower();
            int index = ManagerDL.searchManager(name);
            if (index != -1)
            {
                txtinfo.Visible = true;
                txtinfo.Text = "Manager  Found";
                string password = txtUpdatedpassword.Text;
                bool usernameFlag = s.setPassword(password);
                if (usernameFlag)
                {
                    ManagerDL.Manager[index].setPassword(password);
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
                txtinfo.Text = "Manager not  Found";
            }
            txtOriginalName.Text = "";
            txtUpdatedpassword.Text = "";
        }

        private void btnUpdaters_Click(object sender, EventArgs e)
        {
            Manager s = new Manager();
            string name = txtOrginalName.Text;
            int index = ManagerDL.searchManager(name);
            if (index != -1)
            {
                txtUpdateinfo.Visible = true;
                txtUpdateinfo.Text = "Manager Found";
                string ID = txtUpdateIDS.Text;
                bool usernameFlag = s.setID(ID);
                if (usernameFlag)
                {
                    ManagerDL.Manager[index].setID(ID);
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
                txtUpdateinfo.Text = "Manager not  Found";
            }
            txtOrginalName.Text = "";
            txtUpdateIDS.Text = "";
        }
        public void Closer()
        {
            ManagerTab.Visible = false;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabUpdate.Visible = false;
            tabUpdateName.Visible = false;
            tabUpdatePrice.Visible = false;
            tabUpdateQuantity.Visible = false;
        }

        private void btnBacker_Click(object sender, EventArgs e)
        {
            ManagerTab.SelectedTab = tabUpdate;

        }

        private void btnBackButton_Click(object sender, EventArgs e)
        {
            ManagerTab.SelectedTab = tabUpdate;

        }
        private void btnBackes_Click(object sender, EventArgs e)
        {
            ManagerTab.SelectedTab = tabUpdate;
        }

        private void btnbacks_Click(object sender, EventArgs e)
        {
            Closer();
        }

        private void btnBackers_Click(object sender, EventArgs e)
        {
            Closer();

        }

        private void btnack_Click(object sender, EventArgs e)
        {
            Closer();

        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            Closer();
        }

        
    }
}
