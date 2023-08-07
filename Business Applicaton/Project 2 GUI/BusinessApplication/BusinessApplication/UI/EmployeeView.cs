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
    public partial class EmployeeView : Form
    {
        public EmployeeView()
        {
            InitializeComponent();
           
        }    
        private void tabView_Click(object sender, EventArgs e)
        {
            ViewGrid.DataSource = SellingDL.Sell;
        }
        public void dataBind()
        {
            ViewGrid.DataSource = null;
            ViewGrid.DataSource = SellingDL.Sell;
            ViewGrid.Refresh();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
           
            string path = "Selling.txt";
            if (SellingDL.readSellingFile(path))
            {
            }
            SellingTab.Visible = true;
            tabView.Visible = true;
            if (tabView.Visible == true)
            {
                btnView.Enabled = false;
                btnViewRepairing.Enabled = false;
            }
            dataBind();
        }
        private void btnack_Click(object sender, EventArgs e)
        {
            SellingTab.Visible = false;
            tabView.Visible = false;
            tabVieRepaiirng.Visible = false;
            SellingDL.Sell.Clear();
            btnView.Enabled = true;
            btnViewRepairing.Enabled = true;
        }
        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SellingDL.Sell.Clear();
            RepairingDL.Repair.Clear();
            Form sign = new EmployeeInterface();          
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            AdminPanel.Hide();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            AdminPanel.Show();
        }
        private void tabVieRepaiirng_Click(object sender, EventArgs e)
        {
            ViewGrid.DataSource = RepairingDL.Repair;
        }
        private void btnViewRepairing_Click(object sender, EventArgs e)
        {
            string path = "Repairing.txt";
            if (RepairingDL.readRepairingFile(path))
            {
            }
            SellingTab.Visible = true;
            tabView.Visible = false;
            tabVieRepaiirng.Visible = true;
            if(tabVieRepaiirng.Visible == true)
            {
                btnView.Enabled = false;
                btnViewRepairing.Enabled = false;
            }
            dataBind1();
        }
        public void dataBind1()
        {
            ViewGrids.DataSource = null;
            ViewGrids.DataSource = RepairingDL.Repair;
            ViewGrids.Refresh();
        }
        private void btnBackes_Click(object sender, EventArgs e)
        {
            SellingTab.Visible = false;
            tabView.Visible = false;
            tabVieRepaiirng.Visible = false;
            RepairingDL.Repair.Clear();
            btnViewRepairing.Enabled = true;
            btnView.Enabled = true;
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            SellingTab.Visible = false;
            tabView.Visible = false;
            tabVieRepaiirng.Visible = false;
        }
    }
}
