using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKataKeoghs
{
    public class Basket
    {
        // Items Added to Basket
        public List<Item> SelectedItems { get; }

        public Basket()
        {
            SelectedItems = new List<Item>();
        }
        //  Add Items
        public void AddItem(Item item)
        {
            SelectedItems.Add(item);
        }
        public int Count { get { return SelectedItems.Count; } }
    }
}
