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
    public partial class RepairingUI : Form
    {
        public RepairingUI()
        {
            InitializeComponent();
            string path = "Repairing.txt";
            if (RepairingDL.readRepairingFile(path))
            {
            }
        }      
        private void btnClose_Click(object sender, EventArgs e)
        {
            AdminPanel.Hide();
        }       
        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form sign = new AdminInterface();
           RepairingDL.Repair.Clear();
            sign.Show();
            this.Hide();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            RepairingTab.Visible = true;
            tabAdd.Visible = true;
        }
        private void RepairingUI_Load(object sender, EventArgs e)
        {          
                AdminPanel.Visible = true;
                RepairingTab.Visible = false;
                RepairingTab.Appearance = TabAppearance.FlatButtons;
                RepairingTab.ItemSize = new Size(0, 1);
                tabView.Visible = false;
                tabAdd.Visible = false;
        }
        private void ClearDataFromForm()
        {
            txtProductName.Text = "";
            txtPrice.Text = "";
            txtDefectNumber.Text = "";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Repairing s1 = new Repairing();
            string name = txtProductName.Text.ToLower();
            string price = txtPrice.Text;
            string defects = txtDefectNumber.Text;
            if (int.TryParse(price, out int productPrice) && int.TryParse(defects, out int numberOfdefect))
            {
                bool usernameFlag = s1.setName(name);
                bool passwordFlag = s1.setPrice(productPrice);
                bool QuantityFlag = s1.setQuantity(numberOfdefect);
                if (usernameFlag && passwordFlag && QuantityFlag)
                {
                    Repairing s2 = new Repairing(name, productPrice, numberOfdefect);
                    RepairingDL.AddRepairingintoList(s2);
                    txtResult.Visible = true;
                    txtResult.Text = "Product Added successfully";
                }
                else
                {
                    txtResult.Visible = true;
                    txtResult.Text = "Wrong form of input ";
                }
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
            RepairingTab.Visible = true;
            tabAdd.Visible = false;
         
            RepairingTab.SelectedTab = tabView;
            dataBind();
        }
        public void dataBind()
        {
            ViewGrid.DataSource = null;
            ViewGrid.DataSource = RepairingDL.Repair;
            ViewGrid.Refresh();
        }
        private void tabView_Click(object sender, EventArgs e)
        {
            ViewGrid.DataSource = RepairingDL.Repair;
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            RepairingDL.storerepairInFile("Repairing.txt");
            RepairingDL.Repair.Clear();
            Form sign = new AdminInterface();
            sign.Show();
            this.Hide();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            RepairingTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
           // tabDelete.Visible = true;
            RepairingTab.SelectedTab = tabDelete;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string name = txtAnswer.Text.ToLower();
            int index = RepairingDL.searchRepairing(name);
            if (RepairingDL.deleteRepairing(name))
            {
                txtResults.Visible = true;
                txtResults.Text = "Product Found";
                RepairingDL.Repair.RemoveAt(index);
                txtCon.Visible = true;
                txtCon.Text = "Product removed successfully";
            }
            else
            {
                txtResults.Visible = false;
                txtResults.Text = "Product not  Found";
            }
            txtAnswer.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RepairingTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            RepairingTab.SelectedTab = tabUpdate;

           // tabUpdate.Visible = true;
        }

        private void radNames_CheckedChanged(object sender, EventArgs e)
        {
            RepairingTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabUpdate.Visible = false;
            tabUpdateName.Visible = true;
        }

        private void btnUpdates_Click(object sender, EventArgs e)
        {
            Repairing s = new Repairing();
            string name = txtEdit.Text.ToLower();
            int index = RepairingDL.searchRepairing(name);
            if (index != -1)
            {
                txtUpdateAnswer.Visible = true;
                txtUpdateAnswer.Text = "Product Found";
                string names = txtNames.Text;
                bool usernameFlag = s.setName(names);
                if (usernameFlag)
                {
                    RepairingDL.Repair[index].setName(names);
                    txtConclusion.Visible = true;
                    txtConclusion.Text = "Name updated successfully";
                }
                else
                {
                    txtConclusion.Visible = true;
                    txtConclusion.Text = "Name can't be updated successfully";
                }
            }
            else
            {
                txtUpdateAnswer.Visible = true;
                txtUpdateAnswer.Text = "Product not  Found";
            }
            txtEdit.Text = "";
            txtNames.Text = "";
        }

        private void radPrice_CheckedChanged(object sender, EventArgs e)
        {
            RepairingTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabUpdate.Visible = false;
            tabUpdateName.Visible = false;
            tabUpdatePrice.Visible = true;
        }
        private void btnPriceUpdate_Click(object sender, EventArgs e)
        {
            Repairing s = new Repairing();
            string name = txtOriginalName.Text.ToLower();
            int index = RepairingDL.searchRepairing(name);
            if (index != -1)
            {
                txtinfo.Visible = true;
                txtinfo.Text = "Product Found";
                string prices = txtUpdatedprices.Text;
                if (int.TryParse(prices, out int productPrice))
                {
                    bool usernameFlag = s.setPrice(productPrice);
                    if (usernameFlag)
                    {
                        RepairingDL.Repair[index].setPrice(productPrice);
                        txtinfo1.Visible = true;
                        txtinfo1.Text = "Price updated successfully";
                    }
                    else
                    {
                        txtinfo1.Visible = true;
                        txtinfo1.Text = "Price can't be updated successfully";
                    }
                }
                else
                {
                    txtinfo.Visible = true;
                    txtinfo.Text = "Product not  Found";
                }
            }
            txtOriginalName.Text = "";
            txtUpdatePrice.Text = "";
        }
        private void radQuantity_CheckedChanged(object sender, EventArgs e)
        {
            RepairingTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabUpdate.Visible = false;
            tabUpdateName.Visible = false;
            tabUpdatePrice.Visible = false;
            tabUpdateQuantity.Visible = true;
        }
        private void btnUpdaters_Click(object sender, EventArgs e)
        {
             Repairing s = new Repairing();
            string name = txtOrginalName.Text.ToLower();
            int index = RepairingDL.searchRepairing(name);
            if (index != -1)
            {
                txtUpdateinfo.Visible = true;
                txtUpdateinfo.Text = "Product Found";
                string prices = txtUpdateQuantity.Text;
                if (int.TryParse(prices, out int productPrice))
                {
                    bool usernameFlag = s.setQuantity(productPrice);
                    if (usernameFlag)
                    {
                        RepairingDL.Repair[index].setQuantity(productPrice);
                        txtInfos.Visible = true;
                        txtInfos.Text = "Quantity updated successfully";
                    }
                    else
                    {
                        txtInfos.Visible = true;
                        txtInfos.Text = "Quantity can't be updated ";
                    }
                }
                else
                {
                    txtUpdateinfo.Visible = true;
                    txtUpdateinfo.Text = "Product not  Found";
                }
            }
            txtOrginalName.Text = "";
            txtUpdateQuantity.Text = "";
        }
        public void Closer()
        {
            RepairingTab.Visible = false;
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
            RepairingTab.SelectedTab = tabUpdate;
        }
        private void btnBackButton_Click(object sender, EventArgs e)
        {
            RepairingTab.SelectedTab = tabUpdate;
        }
        private void btnBackes_Click(object sender, EventArgs e)
        {
            RepairingTab.SelectedTab = tabUpdate;
        }
        private void btnbacks_Click(object sender, EventArgs e)
        {
            Closer();
        }

        private void btnBackers_Click(object sender, EventArgs e)
        {
            Closer();
        }

        public void btnack_Click(object sender, EventArgs e)
        {
            Closer();
           
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            Closer();
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            AdminPanel.Show();
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {

        }
    }
}
