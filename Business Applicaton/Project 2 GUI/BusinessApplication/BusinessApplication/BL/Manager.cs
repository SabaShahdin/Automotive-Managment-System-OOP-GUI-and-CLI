using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BusinessApplication.BL
{
    public class Manager : Staff
    {

        public Manager()
        {

        }
        public Manager(string username, string password) : base(username, password)
        {
            this.UserName = username;
            this.Password = password;
        }
        public Manager(string username, string password, string ManagerID, string role) : base(username, password, role)
        {
            this.UserName = username;
            this.Password = password;
            this.ID = ManagerID;
            this.Role = role;
        }
        public Manager(string username, string password, string ManagerID) : base(username, password , ManagerID)
        {
            this.UserName = username;
            this.Password = password;
            this.ID = ManagerID;
        }
        public Manager(string ManagerID)
        {
            this.ID = ManagerID;
        }
        public Manager(string ID, int workHour,  string role , int salary )
        {
            this.ID = ID;
            this.WorkHours = workHour;
            this.Role = role;
            this.Salary = salary;
        }
        public override string toString()
        {
            return base.toString();
        }
        
       public override int  calculateSalary()
        {
            int monthlySalary = 12000;
            if (WorkHours > 9)
            {
                Salary = monthlySalary + 4000;
            }
            else
            {
                Salary = monthlySalary;
            }
            return Salary;
        }
    }
}
