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
    public partial class ManagerMoney : Form
    {
        public ManagerMoney()
        {
            InitializeComponent();
        }

        private void btnViewMoneySell_Click(object sender, EventArgs e)
        {
            string path = "MoneySell.txt";
            if (MoneySellDL.readMoneySellFile(path))
            {
            }
            ViewTab.Visible = true;
            ViewTab.SelectedTab = tabDelete;
            tabUpdateName.Visible = false;
            if (tabDelete.Visible == true)
            {
                btnViewMoneySell.Enabled = false;
                btnDelete.Enabled = false;

            }
            dataBind1();
        }
        public void dataBind1()
        {
            GridV.DataSource = null;
            GridV.DataSource = MoneySellDL.Money;
            GridV.Refresh();
        }

        private void btnBackers_Click(object sender, EventArgs e)
        {
            ViewTab.Visible = false;
            MoneySellDL.Money.Clear();
            btnViewMoneySell.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void tabDelete_Click(object sender, EventArgs e)
        {
            GridV.DataSource = MoneySellDL.Money;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string path = "MoneyRepair.txt";
            if (MoneyRepairDL.readMoneyRepairFile(path))
            {
            }
            ViewTab.Visible = true;
            tabDelete.Visible = false;
            ViewTab.SelectedTab = tabUpdateName;
            if (tabUpdateName.Visible == true)
            {
                btnViewMoneySell.Enabled = false;

                btnDelete.Enabled = false;
            }
            //tabUpdateName.Visible = true;
            dataBind2();
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
            btnViewMoneySell.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AdminPanel.Hide();
        }

        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form sign = new ManagerInterface();
            sign.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SellingDL.Sell.Clear();
            RepairingDL.Repair.Clear();
            Form sign = new EmployeeInterface();
            sign.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AdminPanel.Show();
        }

        private void ManagerMoney_Load(object sender, EventArgs e)
        {

        }
    }
}
