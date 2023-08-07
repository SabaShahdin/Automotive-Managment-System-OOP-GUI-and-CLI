using BusinessApplication.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.DL
{
    public class ManagerDL
    {
        private static List<Manager> manager = new List<Manager>();

        public static List<Manager> Manager { get => manager; set => manager = value; }

        public static void AddIntoManangerList(Manager e1)
        {
            Manager.Add(e1);
        }
        public static bool checkManagerID(string ManagerID)
        {
            foreach (Manager e in Manager)
            {
                if (e.getID() == ManagerID)
                {
                    return true;
                }
            }
            return false ;
        }
        public static void viewManager()
        {
            Console.WriteLine("UserName \t  Password  \t Manager ID  ");
            foreach (Manager store in Manager)
            {
                Console.WriteLine(store.getUsername() + "\t" + store.getPassword() + "\t" + store.getID());

            }
        }
        public static int searchManager(string newManager)
        {
            Manager e = new Manager();
            for (int x = 0; x < Manager.Count; x++)
            {
                if (Manager == null)
                {
                    return -1;
                }
                else if (newManager == Manager[x].getUsername())
                {
                    return x;
                }
            }
            return -1;
        }
        public static bool deleteManager(string newManager)
        {
            int delete = searchManager(newManager);
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
        public static bool updateManager(string newManager)
        {
            int update = searchManager(newManager);
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
        public static bool CheckManager(string ManagerPassword, string ManagerUserName, string ManagerID)
        {
            bool flag = true;
            foreach (Manager e in Manager)
            {
                if (e.getPassword() != ManagerPassword && e.getUsername() != ManagerUserName && e.getID() != ManagerID && ManagerUserName != "saba@007" && ManagerPassword != "94822939!")
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
       
        public static bool readManagerFile(string path)
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
                    string ManagerID = splittedRecord[2];
                    Manager e1 = new Manager(userName, password, ManagerID);
                    ManagerDL.AddIntoManangerList(e1);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeManagerInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Manager s in ManagerDL.Manager)
            {
                file.WriteLine(s.getUsername() + "," + s.getPassword() + "," + s.getID());

            }
            file.Flush();
            file.Close();
        }
    }
}
