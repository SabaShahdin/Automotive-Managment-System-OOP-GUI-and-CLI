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
    public partial class Role : Form
    {
        public static List<string> role = new List<string>();
       
        public Role()
        {
            InitializeComponent();
            role.Add("Admin");
            role.Add("Employee");
            role.Add("Manager");
            string path = "Person.txt";
            if(PersonDL.readFromFile(path))
            {
            }
           
        }

        public void Role_Load(object sender, EventArgs e)
        {
            cmbRole.DataSource = role;
        }

        public  void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Selectedrole = cmbRole.SelectedItem.ToString();
            Selectedrole = cmbRole.Text;
        }

        public void btnRole_Click(object sender, EventArgs e)
        {
            if(cmbRole.SelectedItem.ToString() != null)
            {
                if (cmbRole.SelectedItem.ToString() == "Admin")
                {
                  
                    Form signForm = new SignIn();                 
                    signForm.Show();
                    this.Hide();
                    role.Clear();
                    
                }
                else 
                {
                  
                    Form idForm = new ID();
                    idForm.Show();
                    this.Hide();
                    role.Clear();

                }
            }
            else
            {
                MessageBox.Show("Please Select something");
            }
        }        
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form mainForm = new MainScreen();
            mainForm.Show();
            this.Hide();
            role.Clear();

        }

    }
}
