using BusinessApplication.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.DL
{
    public class PersonDL
    {
        private static List<Person> signUp = new List<Person>();

        public static List<Person> SignUp { get => signUp; set => signUp = value; }

        public static void storeRoleInList(Person person)
        {
            SignUp.Add(person);
        }
        public static void AddAdmin()
        {
            Person p1 = new Person("saba@007", "94822939!", "Admin");
            PersonDL.storeRoleInList(p1);
        }
        public static string signIn(Person person)
        {
            string role = null ;
            foreach (Person storedUser in SignUp)
            {
                if (person.getUsername() == storedUser.getUsername() && person.getPassword() == storedUser.getPassword() )
                {
                    role = storedUser.getRole();
                }
            }
            return role;
        }
        public static bool readFromFile(string path)
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
                    string role = splittedRecord[2];
                    Person p1 = new Person(userName, password, role);
                    PersonDL.storeRoleInList(p1);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeDataInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach(Person s in PersonDL.SignUp)
            {
                file.WriteLine(s.getUsername() + "," + s.getPassword() + "," + s.getRole());

            }
            file.Flush();
            file.Close();
        }
        public static int searchPerson(string newPerson)
        {
            Person e = new Person();
            for (int x = 0; x < SignUp.Count; x++)
            {
                if (SignUp == null)
                {
                    return -1;
                }
                else if (newPerson == SignUp[x].getUsername())
                {
                    return x;
                }
            }
            return -1;
        }
        public static bool deletePerson(string newEmployee)
        {
            int delete = searchPerson(newEmployee);
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
        public static bool updatePerson(string newEmployee)
        {
            int update = searchPerson(newEmployee);
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
    }
}
