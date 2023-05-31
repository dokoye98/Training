using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Purchase
    {
        public double TotalBill(Trolley troll)
        {
            double price = 0;
            double[] listofprices = troll.pricelist();
            if(listofprices != null && listofprices.Length > 0)
            {
                for (int i = 0; i < listofprices.Length; i++)
                {
                    price += listofprices[i];
                }
            }
            
            return price;
        }
    }
}
