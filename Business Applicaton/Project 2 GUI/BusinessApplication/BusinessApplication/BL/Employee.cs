using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace BusinessApplication.BL
{
    public class Employee : Staff
    {
        public Employee()
        {

        }
        public Employee(string username, string password) : base(username, password)
        {
            this.UserName = username;
            this.Password = password;
        }
        public Employee(string username, string password , string ID  , string role) : base(username, password , role , ID)
        {
            this.UserName = username;
            this.Password = password;
            this.ID = ID;
            this.Role = role;
        }
        public Employee(string username, string password , string ID) : base(username, password , ID)
        {
            this.UserName = username;
            this.Password = password;
            this.ID = ID;
        }
        public Employee( string ID)
        {
            this.ID = ID;
        }
        public Employee(string ID , int workHour , string role , int salary) : base(ID , workHour , role, salary)
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
            if(WorkHours > 9)
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
