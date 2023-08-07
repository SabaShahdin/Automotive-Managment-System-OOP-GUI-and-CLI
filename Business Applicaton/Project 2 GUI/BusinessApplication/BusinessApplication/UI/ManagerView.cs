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
    public partial class ManagerView : Form
    {
        public ManagerView()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AdminPanel.Hide();
        }

        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SellingDL.Sell.Clear();
            RepairingDL.Repair.Clear();
            Form sign = new ManagerInterface();
            sign.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SellingDL.Sell.Clear();
            RepairingDL.Repair.Clear();
            Form sign = new ManagerInterface();
            sign.Show();         
            this.Hide();
        }

        private void tabView_Click(object sender, EventArgs e)
        {
            ViewGrid.DataSource = SellingDL.Sell;
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
        public void dataBind()
        {
            ViewGrid.DataSource = null;
            ViewGrid.DataSource = SellingDL.Sell;
            ViewGrid.Refresh();
        }

        private void tabVieRepaiirng_Click(object sender, EventArgs e)
        {
            ViewGrid.DataSource = RepairingDL.Repair;

        }

      
        public void dataBind1()
        {
            ViewGrids.DataSource = null;
            ViewGrids.DataSource = RepairingDL.Repair;
            ViewGrids.Refresh();
        }

        private void ManagerView_Load(object sender, EventArgs e)
        {
            SellingTab.Visible = false;
            tabView.Visible = false;
            tabVieRepaiirng.Visible = false;
        }

        private void ManagerView_Load_1(object sender, EventArgs e)
        {

        }

        private void btnViewRepairing_Click_1(object sender, EventArgs e)
        {
            string path = "Repairing.txt";
            if (RepairingDL.readRepairingFile(path))
            {
            }
            SellingTab.Visible = true;
            tabView.Visible = false;
            tabVieRepaiirng.Visible = true;
            if (tabVieRepaiirng.Visible == true)
            {
                btnView.Enabled = false;
                btnViewRepairing.Enabled = false;
            }
            dataBind1();
        }

    
        private void btnBackes_Click(object sender, EventArgs e)
        {
            SellingTab.Visible = false;
            tabView.Visible = false;
            tabVieRepaiirng.Visible = false;
            RepairingDL.Repair.Clear();
            btnView.Enabled = true;
            btnViewRepairing.Enabled = true;
        }
    }
}
