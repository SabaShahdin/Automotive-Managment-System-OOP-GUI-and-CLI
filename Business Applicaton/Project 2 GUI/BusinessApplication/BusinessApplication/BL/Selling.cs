using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.BL
{
    public class Selling : Product
    {
        private int Quantity;

        public int Quantity1 { get => Quantity; set => Quantity = value; }

        public Selling()
        {

        }
        public Selling(string productName , int productPrice) : base(productName , productPrice)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
        }
        public Selling(string productName, int productPrice, int Quantity) : base(productName, productPrice)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.Quantity1 = Quantity;
        }
        public bool setQuantity(int Quantity)
        {
            string newProduct = Quantity.ToString();
            bool flag = false;
            foreach (char c in newProduct)
            {
                if (char.IsLetter(c) || Quantity <= 0 || Quantity >= 70)
                {
                    flag = false;
                    break;
                }
                else
                {
                    this.Quantity1 = Quantity;
                    flag = true;
                }
            }
            return flag;
        }
        public int getQunatity()
        {
            return Quantity1;
        }
        public override string toString()
        {
            return base.toString();
        }
      
    }
}
