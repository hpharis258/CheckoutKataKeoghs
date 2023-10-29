namespace CheckoutKataKeoghs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Total_Items_Display = new Label();
            label10 = new Label();
            Total_Amount_Display = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            add_button = new Button();
            item_a_input = new TextBox();
            item_b_input = new TextBox();
            item_c_input = new TextBox();
            item_d_input = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 54);
            label1.TabIndex = 1;
            label1.Text = "Checkout Kata";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 63);
            label6.Name = "label6";
            label6.Size = new Size(120, 54);
            label6.TabIndex = 6;
            label6.Text = "Items";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(138, 63);
            label7.Name = "label7";
            label7.Size = new Size(176, 54);
            label7.TabIndex = 7;
            label7.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(459, 63);
            label8.Name = "label8";
            label8.Size = new Size(138, 54);
            label8.TabIndex = 20;
            label8.Text = "Basket";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(382, 158);
            label9.Name = "label9";
            label9.Size = new Size(215, 54);
            label9.TabIndex = 21;
            label9.Text = "Total Items";
            // 
            // Total_Items_Display
            // 
            Total_Items_Display.AutoSize = true;
            Total_Items_Display.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Total_Items_Display.Location = new Point(614, 158);
            Total_Items_Display.Name = "Total_Items_Display";
            Total_Items_Display.Size = new Size(45, 54);
            Total_Items_Display.TabIndex = 22;
            Total_Items_Display.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(382, 237);
            label10.Name = "label10";
            label10.Size = new Size(261, 54);
            label10.TabIndex = 23;
            label10.Text = "Total Amount";
            // 
            // Total_Amount_Display
            // 
            Total_Amount_Display.AutoSize = true;
            Total_Amount_Display.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Total_Amount_Display.Location = new Point(459, 306);
            Total_Amount_Display.Name = "Total_Amount_Display";
            Total_Amount_Display.Size = new Size(120, 54);
            Total_Amount_Display.TabIndex = 24;
            Total_Amount_Display.Text = "0.00£";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 127);
            label2.Name = "label2";
            label2.Size = new Size(49, 54);
            label2.TabIndex = 25;
            label2.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 181);
            label3.Name = "label3";
            label3.Size = new Size(46, 54);
            label3.TabIndex = 26;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 237);
            label4.Name = "label4";
            label4.Size = new Size(48, 54);
            label4.TabIndex = 27;
            label4.Text = "C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(43, 291);
            label5.Name = "label5";
            label5.Size = new Size(51, 54);
            label5.TabIndex = 28;
            label5.Text = "D";
            // 
            // add_button
            // 
            add_button.Location = new Point(100, 348);
            add_button.Name = "add_button";
            add_button.Size = new Size(120, 42);
            add_button.TabIndex = 29;
            add_button.Text = "Add";
            add_button.UseVisualStyleBackColor = true;
            // 
            // item_a_input
            // 
            item_a_input.Location = new Point(127, 145);
            item_a_input.Name = "item_a_input";
            item_a_input.Size = new Size(56, 23);
            item_a_input.TabIndex = 30;
            item_a_input.TextChanged += item_a_input_TextChanged;
            // 
            // item_b_input
            // 
            item_b_input.Location = new Point(127, 200);
            item_b_input.Name = "item_b_input";
            item_b_input.Size = new Size(56, 23);
            item_b_input.TabIndex = 31;
            item_b_input.TextChanged += item_b_input_TextChanged;
            // 
            // item_c_input
            // 
            item_c_input.Location = new Point(127, 253);
            item_c_input.Name = "item_c_input";
            item_c_input.Size = new Size(56, 23);
            item_c_input.TabIndex = 32;
            item_c_input.TextChanged += item_c_input_TextChanged;
            // 
            // item_d_input
            // 
            item_d_input.Location = new Point(127, 306);
            item_d_input.Name = "item_d_input";
            item_d_input.Size = new Size(56, 23);
            item_d_input.TabIndex = 33;
            item_d_input.TextChanged += item_d_input_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(item_d_input);
            Controls.Add(item_c_input);
            Controls.Add(item_b_input);
            Controls.Add(item_a_input);
            Controls.Add(add_button);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Total_Amount_Display);
            Controls.Add(label10);
            Controls.Add(Total_Items_Display);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Checkout Kata";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label Total_Items_Display;
        private Label label10;
        private Label Total_Amount_Display;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button add_button;
        private TextBox item_a_input;
        private TextBox item_b_input;
        private TextBox item_c_input;
        private TextBox item_d_input;
    }
}