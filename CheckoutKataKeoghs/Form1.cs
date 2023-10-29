using System.Text.RegularExpressions;

namespace CheckoutKataKeoghs
{
    public partial class Form1 : Form
    {
        // User Input Validation RegEx
        string pattern = @"^\d+$";

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
    }
}