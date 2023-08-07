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
    public partial class ID : Form
    {
        public ID()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           Form sign = new SignIn();
            sign.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form sign = new Role();
            sign.Show();
            this.Hide();
        }

        private void ID_Load(object sender, EventArgs e)
        {

        }
    }
}
