using BusinessApplication.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.DL
{
    public class RepairingDL
    {
        private static List<Repairing> repair = new List<Repairing>();

        public static List<Repairing> Repair { get => repair; set => repair = value; }

        public static void AddRepairingintoList(Repairing s1)
        {
            Repair.Add(s1);
        }
      

        public static int searchRepairing(string newProduct)
        {
            Repairing s = new Repairing();
            for (int x = 0; x < Repair.Count; x++)
            {
                if (Repair == null)
                {
                    return -1;
                }
                else if (newProduct == Repair[x].getProductName())
                {
                    return x;
                }
            }
            return -1;
        }
        
        public static bool deleteRepairing(string newProduct)
        {
            int delete = searchRepairing(newProduct);
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
        public static bool updateRepairingProduct(string newProduct)
        {
            int update = searchRepairing(newProduct);
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
        public static bool readRepairingFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string productName = splittedRecord[0];
                    int productPrice = int.Parse(splittedRecord[1]);
                    int NumberOfDefects = int.Parse(splittedRecord[2]);
                    Repairing e1 = new Repairing(productName, productPrice , NumberOfDefects);
                    AddRepairingintoList(e1);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storerepairInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach(Repairing s in RepairingDL.Repair)
            {
                file.WriteLine(s.getProductName() + "," + s.getProductPrice() + "," + s.getNumber());

            }
            file.Flush();
            file.Close();
        }
        
    }
}
