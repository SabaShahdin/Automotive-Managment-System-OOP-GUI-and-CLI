using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.BL
{
    public class MoneySell : Money
    {

        public MoneySell()
        {
            
        }
        public MoneySell(string day , int numberOfProduct) : base (numberOfProduct , day)
        {
            this.Day = day;
            this.NumberOfproduct = numberOfProduct;
        }
        public MoneySell( string productName , int productPrice  , int numberofProduct, string day) : base( productName, productPrice ,  numberofProduct, day)
        {
            this.NumberOfproduct = numberofProduct;
            this.Day = day;
            this.ProductName1 = productName;
            this.ProductPrice1 = productPrice;
        }
        public MoneySell(string productName, int productPrice , int numberOfProduct , string day , int oneDayRecord) : base ( productName, productPrice , numberOfProduct , day)
        {
            this.NumberOfproduct = numberOfProduct;
            this.Day = day;
            this.ProductName1 = productName;
            this.ProductPrice1 = productPrice;
            this.OneDayRecord = oneDayRecord;
        }
        public override string toString()
        {
            return base.toString();
        }

    }
}
