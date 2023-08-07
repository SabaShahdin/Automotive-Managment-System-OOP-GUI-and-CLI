using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.BL
{
    public class Money
    {
         private string ProductName;
        private int ProductPrice;
        private int numberOfproduct;
        private string day;
        private int oneDayRecord;

        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public int ProductPrice1 { get => ProductPrice; set => ProductPrice = value; }
        public int NumberOfproduct { get => numberOfproduct; set => numberOfproduct = value; }
        public string Day { get => day; set => day = value; }
        public int OneDayRecord { get => oneDayRecord; set => oneDayRecord = value; }

        public Money()
        {

        }
        public Money(int numberofProduct , string day )
        {
            this.NumberOfproduct = numberofProduct;
            this.Day = day;
        }
        public Money(string productName , int productPrice , int numberofProduct, string day) 
        {
            this.NumberOfproduct = numberofProduct;
            this.Day = day;
            this.ProductName1 = productName;
            this.ProductPrice1 = productPrice;
        }
        public bool setDay(string day)
        {
            bool flag = false;
            foreach (char c in day)
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday"|| day == "Thursday" || day == "Friday")
                {
                    this.Day = day;
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
        public bool setNumber(int numberOfProduct)
        {
            string newProduct = numberOfProduct.ToString();
            bool flag = false;
            foreach (char c in newProduct)
            {
                if (char.IsLetter(c) || NumberOfproduct < 0 )
                {
                    flag = false;
                    break;
                }
                else
                {
                    this.NumberOfproduct = numberOfProduct;
                    flag = true;
                }
            }
            return flag;
        }
        public string getDay()
        {
            return Day;
        }
        public int getNumber()
        {
            return NumberOfproduct;
        }
        public bool setName(string productName)
        {
            bool flag = false;
            foreach (char c in productName)
            {
                if (!(char.IsLetter(c)))
                {
                    flag = false;
                    break;
                }
                else
                {
                    this.ProductName1 = productName;
                    flag = true;
                }
            }
            return flag;
        }
        public bool setPrice(int productPrice)
        {
            string newProduct = productPrice.ToString();
            bool flag = false;
            foreach (char c in newProduct)
            {
                if (char.IsLetter(c))
                {
                    flag = false;
                    break;
                }
                else
                {
                    this.ProductPrice1 = productPrice;
                    flag = true;
                }
            }
            return flag;
        }
        public string getProductName()
        {
            return ProductName1;
        }
        public int getProductPrice()
        {
            return ProductPrice1;
        }
        public virtual string toString()
        {
            return "ProductName" + "\t" + ProductName1 + "ProductPrice" + "\t" + ProductPrice1 + "day" + "\t" + Day + "numberofProducts" + "\t" + NumberOfproduct;
        }
    }
}
