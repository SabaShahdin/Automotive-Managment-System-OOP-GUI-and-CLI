using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessApplication.BL
{
    public class Staff :Person
    {
        private string iD;
        private int workHours;
        private int salary;

        public string ID { get => iD; set => iD = value; }
        public int WorkHours { get => workHours; set => workHours = value; }
        public int Salary { get => salary; set => salary = value; }

        public Staff()
        {

        }
        public Staff(string username, string password) : base(username, password)
        {
            this.UserName = username;
            this.Password = password;
        }
        public Staff(string username, string password, string ID, string role) : base(username, password, role)
        {
            this.UserName = username;
            this.Password = password;
            this.ID = ID;
            this.Role = role;
        }
        public Staff(string username, string password, string ID) : base(username, password , ID)
        {
            this.UserName = username;
            this.Password = password;
            this.ID = ID;
        }
        public Staff(string ID)
        {
            this.ID = ID;
        }
        public Staff(string ID, int workHour,string role)
        {
            this.ID = ID;
            this.WorkHours = workHour;
            this.Role = role;
        }

        public Staff(string ID, int workHour, string role , int salary)
        {
            this.ID = ID;
            this.WorkHours = workHour;
            this.Role = role;
            this.Salary = salary;
        }
        public override string toString()
        {
            return base.toString() + "\t" + ID;
        }
        public bool setID(string ID)
        {
            string pattern = "^[A-Za-z]+@[0-9]+$";
            bool isMatch = Regex.IsMatch(ID , pattern);
            if ((string.IsNullOrEmpty(ID)) || !isMatch)
            {
                return false;
            }
            this.ID = ID;
            return true;
        }
        public string getID()
        {
            return ID;
        }
        public bool setWorkHour(int workHour)
        {
            string newProduct = workHour.ToString();
            bool flag = false;
            foreach (char c in newProduct)
            {
                if (char.IsLetter(c) || workHour < 0)
                {
                    flag = false;
                    break;
                }
                else
                {
                    this.WorkHours = workHour;
                    flag = true;
                }
            }
            return flag;
        }
        public int getWorkHour()
        {
            return WorkHours;
        }
        public int getSalary()
        {
            return Salary;
        }
       
        public virtual int calculateSalary()
        {
            return 0;
        }
    }
}
