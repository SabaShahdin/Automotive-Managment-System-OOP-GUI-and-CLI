using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.BL
{
    public class Repairing: Product
    {
        private int numberOfDefects;

        public int NumberOfDefects { get => numberOfDefects; set => numberOfDefects = value; }

        public Repairing()
        {

        }
        public Repairing(string productName , int productPrice) : base(productName , productPrice)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
        }
        public Repairing(string productName, int productPrice , int numberOfDefects) : base(productName, productPrice)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.NumberOfDefects = numberOfDefects;
        }
        public bool setQuantity(int numberOfDefects)
        {
            string newProduct = numberOfDefects.ToString();
            bool flag = false;
            foreach (char c in newProduct)
            {
                if (char.IsLetter(c) || numberOfDefects <= 0 || numberOfDefects > 10)
                {
                    flag = false;
                    break;
                }
                else
                {
                    this.NumberOfDefects = numberOfDefects;
                    flag = true;
                }
            }
            return flag;
        }
        public int getNumber()
        {
            return NumberOfDefects;
        }
        
        public override string toString()
        {
            return base.toString();
        }
    }
}
