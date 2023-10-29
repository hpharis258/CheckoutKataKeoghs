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
            double Total_Promotion_B = 0;
            double Total_Promotion_D = 0;

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
                int numberOfItemsPromB = PromotionItemBCounter / ActivePromotions.Active_Promotions["B"].Quantity;
                int RemainedOfB = PromotionItemBCounter % ActivePromotions.Active_Promotions["B"].Quantity;
                // Whole Promotions
                for(int i = 0; i< numberOfItemsPromB; i++)
                {
                    // Apply Whole Promotions
                    Total_Promotion_B += ActivePromotions.Active_Promotions["B"].Fixed_Price;
                }
                // Remainder Items
                for(int i = 0; i < RemainedOfB; i++)
                {
                    Total_Promotion_B += 15;
                }
                Total_With_Promotion += Total_Promotion_B;
            }
            if(PromotionItemDCCounter > 0)
            {
                // Add Items With Promotion D Applied
                int numberOfItemsPromD = PromotionItemDCCounter / ActivePromotions.Active_Promotions["D"].Quantity;
                int RemainedOfD = PromotionItemDCCounter % ActivePromotions.Active_Promotions["D"].Quantity;

                //Remainder Items
                Double DiscountApplied = 100 - ActivePromotions.Active_Promotions["D"].Percentage_Discount;
                DiscountApplied = DiscountApplied / 100;
                // Whole Promotions
                for (int i = 0; i< numberOfItemsPromD;i++)
                {
                    Total_Promotion_D += 110.00 * DiscountApplied;
                }
                // Remainder
                for(int i = 0; i < RemainedOfD;i++)
                {
                    Total_Promotion_D += 55;
                }
                Total_With_Promotion += Total_Promotion_D;
            }

            Total = Total_Without_Promotion + Total_With_Promotion;
            return Total;
        }
    }
}
