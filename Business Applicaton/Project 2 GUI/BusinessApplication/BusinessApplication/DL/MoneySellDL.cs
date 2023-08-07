using BusinessApplication.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.DL
{
    public class MoneySellDL
    {
        private static List<MoneySell> money = new List<MoneySell>();

        public static List<MoneySell> Money { get => money; set => money = value; }

        public static void AddIntoList(MoneySell m1)
        {
            Money.Add(m1);
        }
        public static int searchPrice(string productName)
        {
            foreach(Selling s in SellingDL.Sell)
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
            foreach (Selling s in SellingDL.Sell)
            {
                if (s == null)
                {
                    return -1;
                }
                if (productName == s.getProductName())
                {
                    return s.getQunatity();
                }
            }
            return -1;
        }
        public static void viewMoneySelling(string day)
        { 
            int sum = 0;
            foreach(MoneySell m in Money)
            {
                if (m.getDay() == day)
                {
                    sum = sum + m.OneDayRecord;
                }
            }
            Console.WriteLine("Money earned  is ...." + sum);
        }
        public static bool readMoneySellFile(string path)
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
                    MoneySell e1 = new MoneySell(productName, productPrice , numberOfProduct , day , oneDayRecord);
                    MoneySellDL.AddIntoList(e1);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeMoneySellInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (MoneySell s in Money)
            {
                file.WriteLine(s.getProductName() + "," + s.getProductPrice() + "," + s.getNumber() + "," +s.getDay()+ "," +  s.OneDayRecord );

            }
            file.Flush();
            file.Close();
        }
    }
}
