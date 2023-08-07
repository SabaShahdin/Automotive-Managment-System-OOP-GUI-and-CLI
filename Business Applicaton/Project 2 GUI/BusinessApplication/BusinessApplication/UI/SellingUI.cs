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
    public partial class SellingUI : Form
    {
        
        public SellingUI()
        {
            InitializeComponent();
            string path = "Selling.txt";
            if (SellingDL.readSellingFile(path))
            {
            }
        }      
        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form sign = new AdminInterface();
            SellingDL.Sell.Clear();
            sign.Show();
            this.Hide();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            AdminPanel.Visible = true;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            SellingDL.storeSellInFile("Selling.txt");
            SellingDL.Sell.Clear();
            Form sign = new AdminInterface();
            sign.Show();
            this.Hide();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SellingTab.Visible = true;
            tabAdd.Visible = true;
        }
        private void Selling_Load(object sender, EventArgs e)
        {           
            AdminPanel.Visible = true;
            SellingTab.Visible = false;
            SellingTab.Appearance = TabAppearance.FlatButtons;
            SellingTab.ItemSize = new Size(0, 1);
            tabView.Visible = false;
            tabAdd.Visible = false;
        }
        private void ClearDataFromForm()
        {
            txtProductName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            Selling s1 = new Selling();
            string name = txtProductName.Text.ToLower();
            string price = txtPrice.Text;
            string Quantity = txtQuantity.Text;
            if (int.TryParse(price, out int productPrice) && int.TryParse(Quantity, out int productQuantity))
            {
                bool usernameFlag = s1.setName(name);
                bool passwordFlag = s1.setPrice(productPrice);
                bool QuantityFlag = s1.setQuantity(productQuantity);
                if (usernameFlag && passwordFlag && QuantityFlag)
                {
                    Selling s2 = new Selling(name, productPrice, productQuantity);
                    SellingDL.AddSellingintoList(s2);
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
            SellingTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = true;
            dataBind();
        }
        public void dataBind()
        {
            ViewGrid.DataSource = null;
            ViewGrid.DataSource = SellingDL.Sell;
            ViewGrid.Refresh();
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {          
            ViewGrid.DataSource = SellingDL.Sell;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SellingTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = true;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            string name = txtAnswer.Text.ToLower();
            int index =  SellingDL.searchSelling(name);
            if (SellingDL.deleteSelling(name))
            {
                    txtResults.Visible = true;
                    txtResults.Text = "Product Found";
                    SellingDL.Sell.RemoveAt(index);
                    txtCon.Visible = true;
                    txtCon.Text = "Product removed successfully";              
            }
            else
            {
                txtResults.Visible = true ;
                txtResults.Text = "Product not  Found";
            }
            txtAnswer.Text = "";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SellingTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabUpdate.Visible = true;
        }
        private void btnUpdates_Click(object sender, EventArgs e)
        {
            Selling s = new Selling();
            string name = txtEdit.Text.ToLower();
            int index = SellingDL.searchSelling(name);
            if (index != -1)
            {
                txtUpdateAnswer.Visible = true;
                txtUpdateAnswer.Text = "Product Found";              
                string names = txtNames.Text;
                bool usernameFlag = s.setName(names);
                if (usernameFlag)
                {
                    SellingDL.Sell[index].setName(names);
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
        private void radNames_CheckedChanged(object sender, EventArgs e)
        {
            SellingTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabUpdate.Visible = false;
            tabUpdateName.Visible = true;
        }
        private void btnBackes_Click(object sender, EventArgs e)
        {
            SellingTab.SelectedTab = tabUpdate;
        }
        private void btnPriceUpdate_Click(object sender, EventArgs e)
        {
            Selling s = new Selling();
            string name = txtOriginalName.Text.ToLower();
            int index = SellingDL.searchSelling(name);
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
                        SellingDL.Sell[index].setPrice(productPrice);
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

        private void radPrice_CheckedChanged(object sender, EventArgs e)
        {
            SellingTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabUpdate.Visible = false;
            tabUpdateName.Visible = false;
            tabUpdatePrice.Visible = true;
        }
        private void btnBackButton_Click(object sender, EventArgs e)
        {
            SellingTab.SelectedTab = tabUpdate;
        }
        private void btnUpdaters_Click(object sender, EventArgs e)
        {
            Selling s = new Selling();
            string name = txtOrginalName.Text.ToLower();
            int index = SellingDL.searchSelling(name);
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
                        SellingDL.Sell[index].setQuantity(productPrice);
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
        private void radQuantity_CheckedChanged(object sender, EventArgs e)
        {
            SellingTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabUpdate.Visible = false;
            tabUpdateName.Visible = false;
            tabUpdatePrice.Visible = false;
            tabUpdateQuantity.Visible = true;
        }
        private void btnBacker_Click(object sender, EventArgs e)
        {
            SellingTab.SelectedTab = tabUpdate;
        }
        public void Closer()
        {
            SellingTab.Visible = false;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            tabUpdate.Visible = false;
            tabUpdateName.Visible = false;
            tabUpdatePrice.Visible = false;
            tabUpdateQuantity.Visible = false;
        }
        private void btnbacks_Click(object sender, EventArgs e)
        {
            Closer();   
        }
        private void btnPic_Click(object sender, EventArgs e)
        {
            Closer();
        }

        private void btnack_Click(object sender, EventArgs e)
        {
            Closer();
           
        }

        private void btnBackers_Click(object sender, EventArgs e)
        {
            Closer();
        }

        private void btnClossse_Click(object sender, EventArgs e)
        {
            AdminPanel.Visible = false;
        }

      
    }
}

