using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKataKeoghs
{
    public class Item
    {
        public String SKU { get; set; }
        public Price Price { get; set; }
        public Item(string SKU, Price Price) 
        {
            this.SKU = SKU;
            this.Price = Price;
        }
    }
}
