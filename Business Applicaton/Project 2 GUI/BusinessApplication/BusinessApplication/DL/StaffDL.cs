using BusinessApplication.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.DL
{
    public class StaffDL
    {
        private static List<Staff> salary = new List<Staff>();

        public static List<Staff> Salary { get => salary; set => salary = value; }

        public static void storeSalaryInList(Staff person)
        {
            Salary.Add(person);
        }
        
        public static bool readSalaryFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string employeeID = splittedRecord[0];
                    int workHours = int.Parse(splittedRecord[1]);
                    int salary = int.Parse(splittedRecord[2]);
                    string role = splittedRecord[3];
                    Staff e1 = new Staff(employeeID, workHours, role , salary);
                    storeSalaryInList(e1);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeSalaryInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Staff s in Salary)
            {
                file.WriteLine(s.getID() +  "," + s.getWorkHour() + "," + s.getSalary() + "," + s.getRole());

            }
            file.Flush();
            file.Close();
        }
    }
}
