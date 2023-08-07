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
    public partial class EmployeeMoney : Form
    {
        public EmployeeMoney()
        {
            InitializeComponent();
            string path = "MoneySell.txt";
            if (MoneySellDL.readMoneySellFile(path))
            {
            }
            string path2 = "Selling.txt";
            if (SellingDL.readSellingFile(path2))
            {
            }
            string path1 = "Repairing.txt";
            if (RepairingDL.readRepairingFile(path1))
            {
            }
            string path3 = "MoneyRepair.txt";
            if (MoneyRepairDL.readMoneyRepairFile(path3))
            {
            }
        }

        private void ClearDataFromForm()
        {
            txtProductName.Text = "";
            txtPrice.Text = "";
            txtDefectNumber.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            RepairingTab.Visible = true;
            RepairingTab.SelectedTab = tabAdd;
            //tabAdd.Visible = true;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string day = txtProductName.Text;
            string productName = txtPrice.Text;
            string numberOfProduct = txtDefectNumber.Text;
            int price = MoneySellDL.searchPrice(productName);     
            if(price != -1)
            {
                if (int.TryParse(numberOfProduct, out int numberOfProducts))
                {
                    int quantity = MoneySellDL.searchQuantity(productName);
                    if (quantity > numberOfProducts)
                    {
                        Money m = new Money();
                        int oneDayRecord = numberOfProducts * price;
                        bool flag = m.setDay(day);
                        bool flag1 = m.setNumber(numberOfProducts);
                        bool flag2 = m.setPrice(price);
                        bool flag3 = m.setName(productName);
                        if (flag && flag1 && flag2 && flag3)
                        {
                            MoneySell m1 = new MoneySell(productName, price, numberOfProducts, day, oneDayRecord);
                            MoneySellDL.AddIntoList(m1);
                            txtAnswers.Visible = true;
                            txtAnswers.Text = "Money added ";
                        }
                        else
                        {
                            txtAnswers.Visible = true;
                            txtAnswers.Text = "Money cant be added";
                        }
                    }
                    else
                    {
                        txtResult.Visible = true;
                        txtResult.Text = "Quantity exceed stock";
                    }
                }
                else
                {
                    txtAnswers.Visible = true;
                    txtAnswers.Text = "Wrong format of input";
                }
            }          
            else
            {
                txtAnswers.Visible = true;
                txtAnswers.Text = "Product name don't find";
            }
            ClearDataFromForm();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            RepairingTab.Visible = true;
            tabAdd.Visible = false;
            RepairingTab.SelectedTab = tabView;

           // tabView.Visible = true;
            dataBind();
        }
        public void dataBind()
        {
            ViewGrid.DataSource = null;
            ViewGrid.DataSource = MoneySellDL.Money;
            ViewGrid.Refresh();
        }

        private void ViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewGrid.DataSource = MoneySellDL.Money;

        }

        private void EmployeeMoney_Load(object sender, EventArgs e)
        {
            AdminPanel.Visible = true;
            RepairingTab.Visible = false;
            RepairingTab.Appearance = TabAppearance.FlatButtons;
            RepairingTab.ItemSize = new Size(0, 1);
            tabView.Visible = false;
            tabAdd.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AdminPanel.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AdminPanel.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MoneySellDL.storeMoneySellInFile("MoneySell.txt");
            MoneySellDL.Money.Clear();
            MoneyRepairDL.storeMoneyRepairInFile("MoneySell.txt");
            MoneyRepairDL.MoneyRepair.Clear();
            Form sign = new EmployeeInterface();
            sign.Show();
            this.Hide();
        }

        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoneySellDL.storeMoneySellInFile("MoneySell.txt");
            MoneySellDL.Money.Clear();
            MoneyRepairDL.storeMoneyRepairInFile("MoneySell.txt");
            MoneyRepairDL.MoneyRepair.Clear();
            Form sign = new EmployeeInterface();
            sign.Show();
            this.Hide();
        }

        private void btnack_Click(object sender, EventArgs e)
        {
            RepairingTab.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RepairingTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            RepairingTab.SelectedTab = tabDelete;

            //tabDelete.Visible = true;
        }

        private void btnaadd_Click(object sender, EventArgs e)
        {
            string day = txtday.Text;
            string productName = txtnamess.Text;
            string numberOfProduct = txtdefect.Text;
            int price = MoneyRepairDL.searchPrice(productName);
            if (price != -1)
            {
                if (int.TryParse(numberOfProduct, out int numberOfProducts))
                {
                    int quantity = MoneyRepairDL.searchQuantity(productName);
                    if (quantity > numberOfProducts)
                    {
                        Money m = new Money();
                        MoneyRepair m2 = new MoneyRepair();
                        int oneDayRecord = numberOfProducts * price;
                        bool flag = m.setDay(day);
                        bool flag1 = m2.setNumberOfDefects(numberOfProducts);
                        bool flag2 = m.setPrice(price);
                        bool flag3 = m.setName(productName);
                        if (flag && flag1 && flag2 && flag3)
                        {
                            MoneyRepair m1 = new MoneyRepair(productName, price, numberOfProducts, day, oneDayRecord);
                            MoneyRepairDL.AddIntoList(m1);
                            txtCon.Visible = true;
                            txtCon.Text = "Money added ";
                        }
                        else
                        {
                            txtCon.Visible = true;
                            txtCon.Text = "Money cant be added";
                        }
                    }
                    else
                    {
                        txtResults.Visible = true;
                        txtResults.Text = "Quantity exceed stock";
                    }
                }
                else
                {
                    txtCon.Visible = true;
                    txtCon.Text = "Wrong format of input";
                }
            }
            else
            {
                txtCon.Visible = true;
                txtCon.Text = "Wrong format of input";
            }
            txtday.Text =  "";
            txtnamess.Text = "";
            txtdefect.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RepairingTab.Visible = true;
            tabAdd.Visible = false;
            tabView.Visible = false;
            tabDelete.Visible = false;
            RepairingTab.SelectedTab = tabUpdateName;

           // tabUpdateName.Visible = true;
            dataBind1();
        }
        public void dataBind1()
        {
            ViewGrids.DataSource = null;
            ViewGrids.DataSource = MoneyRepairDL.MoneyRepair;
            ViewGrids.Refresh();
        }

        private void tabUpdateName_Click(object sender, EventArgs e)
        {
            ViewGrids.DataSource = MoneyRepairDL.MoneyRepair;
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            RepairingTab.Visible = false;
        }

        private void btnBackers_Click(object sender, EventArgs e)
        {
            RepairingTab.Visible = false;
        }

        private void btnBackes_Click(object sender, EventArgs e)
        {
            RepairingTab.Visible = false;
        }
    }
}
