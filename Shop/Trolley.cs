using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Trolley
    {
        public Items[] ShoppingList { get; set; }

        public Trolley(Items[] shoppinglist)
        {
            ShoppingList = shoppinglist;
        }


        public double[] pricelist()
        {
            double[] prices = null;
            if(ShoppingList != null)
            {
                prices = new double[ShoppingList.Length];
                for(int i = 0; i < ShoppingList.Length; i++)
                {
                    prices[i]= ShoppingList[i].Price;
                }
            }
            return prices;
        }
        public string[] FullList()
        {
            string[] lists = null;


            if (ShoppingList != null)
            {
                lists = new string[ShoppingList.Length];
                for (int i = 0;i < ShoppingList.Length; i++)
                {
                    lists[i] = ShoppingList[i].Name;

                }
            }
            return lists;
        }
    }
}
