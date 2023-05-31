using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Items
    {

        public int ProdcutId { get; set; }
        public string Name { get; set; }
        public char Size { get; set; }
        public double price { get; set; }

        public Boolean DiffColours { get; set; }

        public Items(int productid, string name , char size, Boolean diffcolours)
        {
            ProdcutId = productid;
            Name = name;
            Size = size;
            DiffColours = diffcolours;
            
        }
    }
}
