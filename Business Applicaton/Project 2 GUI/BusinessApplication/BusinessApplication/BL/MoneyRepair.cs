using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.BL
{
    public class MoneyRepair : Money
    {
        private int numberOfDefects;
        public MoneyRepair()
        {

        }
        public MoneyRepair(string day, int numberOfProduct)
        {
            this.Day = day;
            this.NumberOfDefects = numberOfProduct;
        }
        public MoneyRepair(string productName, int productPrice, int numberOfProduct , string day)
        {
            this.NumberOfDefects = numberOfProduct;
            this.Day = day;
            this.ProductName1 = productName;
            this.ProductPrice1 = productPrice;
        }
        public MoneyRepair(string productName, int productPrice, int numberOfProduct, string day, int oneDayRecord) : base(productName, productPrice, numberOfProduct, day)
        {
            this.NumberOfDefects = numberOfProduct;
            this.Day = day;
            this.ProductName1 = productName;
            this.ProductPrice1 = productPrice;
            this.OneDayRecord = oneDayRecord;
        }

        public int NumberOfDefects { get => numberOfDefects; set => numberOfDefects = value; }

        public int getNumberOfDefects()
        {
            return NumberOfDefects;
        }
        public bool setNumberOfDefects(int numberOfProduct)
        {
            string newProduct = numberOfProduct.ToString();
            bool flag = false;
            foreach (char c in newProduct)
            {
                if (char.IsLetter(c) || NumberOfproduct < 0)
                {
                    flag = false;
                    break;
                }
                else
                {
                    this.NumberOfDefects = numberOfProduct;
                    flag = true;
                }
            }
            return flag;
        }
        public override string toString()
        {
            return base.toString();
        }
    }
}
