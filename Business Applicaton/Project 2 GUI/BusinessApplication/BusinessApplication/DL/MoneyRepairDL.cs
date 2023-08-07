using BusinessApplication.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.DL
{
    public class MoneyRepairDL
    {
        private static List<MoneyRepair> moneyRepair = new List<MoneyRepair>();

        public static List<MoneyRepair> MoneyRepair { get => moneyRepair; set => moneyRepair = value; }

        public static void AddIntoList(MoneyRepair m1)
        {
            MoneyRepair.Add(m1);
        }
        public static int searchPrice(string productName)
        {

            foreach (Repairing s in RepairingDL.Repair)
            {
                if (s == null)
                {
                    return -1;
                }
                if (s.getProductName() == productName)
                {
                    return s.getProductPrice();
                }
            }
            return -1;
        }
        public static int searchQuantity(string productName)
        {
            foreach (Repairing s in RepairingDL.Repair)
            {
                if (s == null)
                {
                    return -1;
                }
                if (productName == s.getProductName() )
                {
                    return s.getNumber();
                }
            }
            return -1;
        }
        public static void viewMoneyRepairing(string day)
        {
            int sum = 0;
            foreach (MoneyRepair m in MoneyRepair)
            {
                if (m.getDay() == day)
                {
                    sum = sum + m.OneDayRecord;
                }
            }
            Console.WriteLine("Money earned  is ...." + sum);
        }
        public static bool readMoneyRepairFile(string path)
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
                    int numberOfProduct = int.Parse(splittedRecord[2]);
                    string day = splittedRecord[3];
                    int oneDayRecord = int.Parse(splittedRecord[4]);
                    MoneyRepair e1 = new MoneyRepair(productName, productPrice, numberOfProduct, day, oneDayRecord);
                    MoneyRepairDL.AddIntoList(e1);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeMoneyRepairInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (MoneyRepair s in MoneyRepair)
            {
                file.WriteLine(s.getProductName() + "," + s.getProductPrice() + "," + s.getNumber() + "," + s.getDay() + "," + s.OneDayRecord);

            }
            file.Flush();
            file.Close();
        }
    }
}
