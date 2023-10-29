using System.Text.RegularExpressions;

namespace CheckoutKataKeoghs
{
    public partial class Form1 : Form
    {
        // User Input Validation RegEx
        string pattern = @"^\d+$";
        int Total_Items = 0;
        // Prices
        Price Price_10 = new Price(10.00);
        Price Price_15 = new Price(15.00);
        Price Price_40 = new Price(40.00);
        Price Price_55 = new Price(55.00);
        Basket Basket = new Basket();
        Checkout Checkout;
        //
        public Form1()
        {
            InitializeComponent();
        }

        private void item_a_input_TextChanged(object sender, EventArgs e)
        {
            while (!Regex.IsMatch(item_a_input.Text, pattern))
            {
                if (item_a_input.Text == "")
                {
                    break;
                }
                MessageBox.Show("Enter a Valid Quantity for Item A!");
                item_a_input.Text = "";
            }
        }

        private void item_b_input_TextChanged(object sender, EventArgs e)
        {
            while (!Regex.IsMatch(item_b_input.Text, pattern))
            {
                if (item_b_input.Text == "")
                {
                    break;
                }
                MessageBox.Show("Enter a Valid Quantity for Item B!");
                item_b_input.Text = "";
            }
        }

        private void item_c_input_TextChanged(object sender, EventArgs e)
        {

            while (!Regex.IsMatch(item_c_input.Text, pattern))
            {
                if (item_c_input.Text == "")
                {
                    break;
                }
                MessageBox.Show("Enter a Valid Quantity for Item C!");
                item_c_input.Text = "";
            }
        }

        private void item_d_input_TextChanged(object sender, EventArgs e)
        {
            while (!Regex.IsMatch(item_d_input.Text, pattern))
            {
                if (item_d_input.Text == "")
                {
                    break;
                }
                MessageBox.Show("Enter a Valid Quantity for Item D!");
                item_d_input.Text = "";
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            // Raw user Input
            String? item_a = item_a_input.Text;
            String? item_b = item_b_input.Text;
            String? item_c = item_c_input.Text;
            String? item_d = item_d_input.Text;
            // Parse to Int
            int Item_A_QTY = Int32.Parse(item_a == "" ? "0" : item_a);
            int Item_B_QTY = Int32.Parse(item_b == "" ? "0" : item_b);
            int Item_C_QTY = Int32.Parse(item_c == "" ? "0" : item_c);
            int Item_D_QTY = Int32.Parse(item_d == "" ? "0" : item_d);
            // Add Items To Basket
            for (int a = 0; a < Item_A_QTY; a++)
            {
                Item A_Item = new Item("A", Price_10);
                Basket.AddItem(A_Item);
            }
            for (int b = 0; b < Item_B_QTY; b++)
            {
                Item B_Item = new Item("B", Price_15);
                Basket.AddItem(B_Item);
            }
            for (int c = 0; c < Item_C_QTY; c++)
            {
                Item C_Item = new Item("C", Price_40);
                Basket.AddItem(C_Item);
            }
            for (int d = 0; d < Item_D_QTY; d++)
            {
                Item D_Item = new Item("D", Price_55);
                Basket.AddItem(D_Item);
            }
            // Display Total Item Count
            Total_Items_Display.Text = Basket.Count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Items
            Item Item_A = new Item("A", Price_10);
            Item Item_B = new Item("B", Price_15);
            Item Item_C = new Item("C", Price_40);
            Item Item_D = new Item("D", Price_55);
            // Promotions
            Promotion ThreeForForty = new Promotion(3, Fixed_Price: 40.00);
            Promotion TwentyFiveForEveryTwoPurchased = new Promotion(2, Percentage_Discount: 25.00);
            // Active Promotions Valid For following Items:
            Dictionary<String, Promotion> ActivePromotions = new Dictionary<String, Promotion>();
            ActivePromotions.Add(Item_B.SKU, ThreeForForty);
            ActivePromotions.Add(Item_D.SKU, TwentyFiveForEveryTwoPurchased);
            ActivePromotions CurrentActivePromotions = new ActivePromotions(ActivePromotions);
            //
            List<Item> Items = new List<Item>();
            Items.Add(Item_A);
            Items.Add(Item_B);
            Items.Add(Item_C);
            Items.Add(Item_D);
            //
            Checkout = new Checkout(Items, Basket, CurrentActivePromotions);

            
        }
    }
}