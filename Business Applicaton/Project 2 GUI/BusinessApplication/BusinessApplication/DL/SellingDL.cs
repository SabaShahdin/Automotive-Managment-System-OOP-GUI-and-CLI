using BusinessApplication.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.DL
{
    public  class SellingDL
    {
        private static List<Selling> sell = new List<Selling>();

        public static List<Selling> Sell { get => sell; set => sell = value; }

        public static void AddSellingintoList(Selling s1)
        {
            Sell.Add(s1);
        }
        public static int searchSelling(string newProduct)
        {
            Selling s = new Selling();
            for (int x = 0; x < Sell.Count; x++)
            {
                if (Sell == null)
                {
                    return -1;
                }
                else if (newProduct == Sell[x].getProductName())
                {
                    return x;
                }
            }
            return -1;
        }
        public static bool deleteSelling(string newProduct)
        {
            int delete = searchSelling(newProduct);
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
        public static int updateProduct(string newEmployee)
        {
            int update = searchSelling(newEmployee);
            if (update != -1)
            {
                return update;
            }
            else
            {
                return -1;
            }
            return update;
        }

        public static bool readSellingFile(string path)
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
                    int Quantity = int.Parse(splittedRecord[2]);
                    Selling e1 = new Selling(productName , productPrice , Quantity);
                    AddSellingintoList(e1);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeSellInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Selling s in Sell)
            {
                file.WriteLine(s.getProductName() + "," + s.getProductPrice() + "," + s.getQunatity()) ;

            }
            file.Flush();
            file.Close();
        }
    }
}
