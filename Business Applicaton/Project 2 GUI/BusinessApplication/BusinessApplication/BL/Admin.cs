using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.BL
{
    public class Admin : Person
    {
        public static List<Employee> employees = new List<Employee>();
        public static List<Manager> managers = new List<Manager>();
        public static List<Product> products = new List<Product>();
        public Admin()
        {

        }
        public Admin( string role) : base( role)
        {
            this.Role = role;
        }
        public Admin(string username, string password) : base(username, password)
        {
            this.UserName = username;
            this.Password = password;
        }
        public Admin(string username, string password, string role) : base(username, password, role)
        {
            this.UserName = username;
            this.Password = password;
            this.Role = role;
        }
        public override string toString()
        {
            return base.toString();
        }
    }
}
