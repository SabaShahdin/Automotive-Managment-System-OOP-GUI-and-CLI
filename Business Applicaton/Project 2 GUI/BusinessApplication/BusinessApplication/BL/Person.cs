using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BusinessApplication.BL
{
    public class Person
    {
        private string userName;
        private string password;
        private string role;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public Person()
        {

        }
        public Person(string role)
        {
            this.Role = role;
        }

        public Person(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
        }
        public Person(string username, string password, string role) 
        {
            this.UserName = username;
            this.Password = password;
            this.Role = role;
        }
        public bool setUsername(string username)
        {
            string pattern = "^[A-Za-z]+@[0-9]+$";
            bool isMatch = Regex.IsMatch(username, pattern);
            if ((string.IsNullOrEmpty(username) || !isMatch ))
            {               
                return false;
            }
            else
            {
                this.UserName = username;
                return true;
            }
        }
        public string getUsername()
        {
            return UserName;
        }
        public bool setPassword(string password)
        {
            foreach(char c in password )
            {
                if ((password.Length <= 8 && password.Length >= 15) || char.IsLetter(c) || c == ',')
                {
                    return false;
                }

            }

            this.Password = password;
            return true;
        }
        public string getPassword()
        {
            return Password;
        }
        public bool setRole(string role)
        {
            if (role == "Admin" || role == "Employee" || role == "Manager")
            {
                this.Role = role;
                return true;
            }
                return false;
        }
        public string getRole()
        {
            return Role;
        }
        public virtual string toString()
        {
            return "userName" + "\t" + UserName + "password" + "\t" + Password + "role" + "\t" + Role;
        }
       
    }
}
