using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKataKeoghs
{
    public class Checkout
    {
        public List<Item> AvailableItems { get; set; }
        public Basket Basket { get; set; }
        public ActivePromotions ActivePromotions { get; set; }

        private double Total;
        //
        public Checkout(List<Item> AvailableItems, Basket Basket, ActivePromotions ActivePromotions)
        {
            this.AvailableItems = AvailableItems;
            this.Basket = Basket;
            this.ActivePromotions = ActivePromotions;
        }
        // Calculate Total
        public double Calculate_Total()
        {
            return Total;
        }
    }
}
