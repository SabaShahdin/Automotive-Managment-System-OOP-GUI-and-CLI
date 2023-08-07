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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
          
        }
        private void ClearDataFromForm()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";

        }
        private void SignIn_Load(object sender, EventArgs e)
        {
            
        }
        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            Person person = new Person(username, password);
            bool flag1 = person.setUsername(username);
            bool flag2 = person.setPassword(password);
            string flag = PersonDL.signIn(person);
            if (flag1 && flag2)
            {
                txtResult.Visible = true;
                txtResult.Text = "Signed in successfully";
                if (flag == "Admin")
                {
                    Form sign = new AdminInterface();
                    sign.Show();
                    this.Hide();
                }
                if (flag == "Employee")
                {
                    Form sign = new EmployeeInterface();
                    sign.Show();
                    this.Hide();
                }
                if (flag == "Manager")
                {
                    Form sign = new ManagerInterface();
                    sign.Show();
                    this.Hide();
                }
            }
            else if (flag1 || flag2 ||  flag == null)
            {
                txtResult.Visible = true;
                txtResult.Text = "Wrong Input";
            }

            ClearDataFromForm();
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Form mainForm = new Role();
            mainForm.Show();
            this.Hide();

        }

       
    }
}
