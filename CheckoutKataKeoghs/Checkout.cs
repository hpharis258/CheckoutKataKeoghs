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
            // Totals
            Double Total_Without_Promotion = 0;
            Double Total_With_Promotion = 0;
            //
            foreach (var item in this.Basket.SelectedItems)
            {
                // Check if item SKU is in active promotions
                if (!ActivePromotions.Active_Promotions.ContainsKey(item.SKU))
                {
                    // Calculate total without Promotion Items
                    Total_Without_Promotion += item.Price.Unit_Price;
                }
               
            }
            Total = Total_Without_Promotion;
            return Total;
        }
    }
}
