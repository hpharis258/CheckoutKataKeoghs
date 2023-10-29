using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKataKeoghs
{
    public class Promotion
    {
        public int Quantity { get; set; }
        public Double Fixed_Price { get; set; }
        public Double Percentage_Discount { get; set; }
        public Promotion(int Quantity, Double Fixed_Price = 0, Double Percentage_Discount = 0)
        {
            this.Quantity = Quantity;
            this.Fixed_Price = Fixed_Price;
            this.Percentage_Discount = Percentage_Discount;
        }
    }
}
