using BusinessApplication.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.DL
{
    public class EmployeeDL
    {
        private static List<Employee> employee = new List<Employee>();

        public static List<Employee> Employee { get => employee; set => employee = value; }

        public static void AddIntoList(Employee e1)
        {
            Employee.Add(e1);
        }
       
        public static bool checkID(string employeeID)
        {           
            foreach(Employee e in Employee)
            {
 
                if (e.getID() == employeeID)
                {
                    return  true;
                }
            }
            return false;
        }
        public static void viewEmployee()
        {
            Console.WriteLine("UserName \t  Password  \t Employee ID  ");
            foreach (Employee store in Employee)
            {
                    Console.WriteLine(store.getUsername()  + "\t" +  store.getPassword() + "\t" + store.getID());
                
            }
        }
        public static int searchEmployee (string newEmployee)
        {
            Employee e = new Employee();
            for (int x = 0; x < Employee.Count; x++)
            {
                if (Employee == null)
                {
                    return -1;
                }
                else if (newEmployee == Employee[x].getUsername())
                {
                    return x;
                }
            }
            return -1;
        }
        public static bool deleteEmployee(string newEmployee)
        {
            int delete = searchEmployee( newEmployee);
            bool flag = true;
            if (delete != -1)
            {
               flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }
        public static bool updateEmployee(string newEmployee)
        {
            int update = searchEmployee(newEmployee);
            bool flag = true;
            if (update != -1)
            {
                return flag;
            }
            else
            {
                flag = false;
            }
            return flag;
        }
        public static bool Check(string employeePassword , string employeeUserName , string employeeID)
        {
            bool flag = true;
            foreach (Employee e in Employee)
            {
                if (e.getPassword() != employeePassword && e.getUsername() != employeeUserName  && e.getID() != employeeID && employeeUserName != "saba@007" && employeePassword != "94822939!")
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        public static bool readFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string userName = splittedRecord[0];
                    string password = splittedRecord[1];
                    string employeeID = splittedRecord[2];
                    Employee e1 = new Employee(userName , password , employeeID);
                    AddIntoList(e1);
                    
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeInFile(string path)
        {
            StreamWriter file = new StreamWriter(path , false);
            foreach (Employee s in   EmployeeDL.Employee)
            {
                file.WriteLine(s.getUsername() + "," + s.getPassword() + "," + s.getID());

            }
            file.Flush();
            file.Close();
        }
        
    }
}
