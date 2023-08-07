using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.BL
{
    public  class Product
    {
        private string productName;
        private int productPrice;

        public string ProductName { get => productName; set => productName = value; }
        public int ProductPrice { get => productPrice; set => productPrice = value; }

        public Product()
        {

        }
        public Product(string productName)
        {
            this.ProductName = productName;
        }
        public Product(string productName , int productPrice)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
        }
        public bool  setName(string productName)
        {
            bool flag = false;
            foreach(char c in productName)
            {
                if(!(char.IsLetter(c)))
                {
                    flag = false;
                    break;
                }
                else
                {
                    this.ProductName = productName;
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
                    this.ProductPrice = productPrice;
                    flag = true;
                }
            }
            return flag;
        }
        public string getProductName()
        {
            return ProductName;
        }
        public int getProductPrice()
        {
            return ProductPrice;
        }
        public virtual string toString()
        {
            return "ProductName" + "\t" + ProductName + "ProductPrice" + "\t" + ProductPrice;
        }
    }
}
