using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKataKeoghs
{
    public class ActivePromotions
    {
        // Item SKU and Promotion
        public Dictionary<String, Promotion> Active_Promotions;
        public ActivePromotions(Dictionary<String, Promotion> Active_Promotions)
        {
            this.Active_Promotions = Active_Promotions;
        }
    }
}

