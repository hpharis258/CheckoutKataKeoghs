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
            // Promotion Item Counter 
            int PromotionItemBCounter = 0;
            int PromotionItemDCCounter = 0;
            // Totals
            Double Total_Without_Promotion = 0;
            Double Total_With_Promotion = 0;
            //

            // Loop Selected Basket Items
            foreach (var item in this.Basket.SelectedItems)
            {
                // Check if item SKU is in active promotions
                if (!ActivePromotions.Active_Promotions.ContainsKey(item.SKU))
                {
                    // Calculate total without Promotion Items
                    Total_Without_Promotion += item.Price.Unit_Price;
                }
                else
                {
                    // Item is in Active Promotions find Which Promotion
                    if(item.SKU == "B")
                    {
                        PromotionItemBCounter ++;
                    }else if(item.SKU == "D")
                    {
                        PromotionItemDCCounter ++;
                    }
                }
            }
            if(PromotionItemBCounter > 0)
            {
                // Add Items With Promotion B Applied
            }
            if(PromotionItemDCCounter > 0)
            {
                // Add Items With Promotion D Applied
            }
            
            Total = Total_Without_Promotion;
            return Total;
        }
    }
}
