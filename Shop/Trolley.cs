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


        public double finalprice()
        {
            double price = 0;
            if(ShoppingList != null)
            {
                for(int i = 0; i < ShoppingList.Length; i++)
                {
                    price += ShoppingList[i].price;
                }
            }
            return price;
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
