namespace dinnermaker3000
{
    partial class NewIngredient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            add_product_button = new Button();
            product_name_label = new Label();
            product_name_textbox = new TextBox();
            product_price_label = new Label();
            product_price_textbox = new TextBox();
            product_unit_combobox = new ComboBox();
            product_unit_name = new Label();
            product_count_textbox = new TextBox();
            product_count_label = new Label();
            SuspendLayout();
            // 
            // add_product_button
            // 
            add_product_button.Anchor = AnchorStyles.Bottom;
            add_product_button.Location = new Point(232, 246);
            add_product_button.Name = "add_product_button";
            add_product_button.Size = new Size(129, 29);
            add_product_button.TabIndex = 8;
            add_product_button.Text = "Add ingredient";
            add_product_button.UseVisualStyleBackColor = true;
            add_product_button.Click += add_product_button_click;
            // 
            // product_name_label
            // 
            product_name_label.AutoSize = true;
            product_name_label.Location = new Point(25, 20);
            product_name_label.Name = "product_name_label";
            product_name_label.Size = new Size(101, 20);
            product_name_label.TabIndex = 0;
            product_name_label.Text = "Product name";
            // 
            // product_name_textbox
            // 
            product_name_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            product_name_textbox.Location = new Point(25, 43);
            product_name_textbox.Name = "product_name_textbox";
            product_name_textbox.Size = new Size(548, 27);
            product_name_textbox.TabIndex = 1;
            // 
            // product_price_label
            // 
            product_price_label.AutoSize = true;
            product_price_label.Location = new Point(25, 80);
            product_price_label.Name = "product_price_label";
            product_price_label.Size = new Size(41, 20);
            product_price_label.TabIndex = 2;
            product_price_label.Text = "Price";
            // 
            // product_price_textbox
            // 
            product_price_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            product_price_textbox.Location = new Point(25, 103);
            product_price_textbox.Name = "product_price_textbox";
            product_price_textbox.Size = new Size(548, 27);
            product_price_textbox.TabIndex = 3;
            // 
            // product_unit_combobox
            // 
            product_unit_combobox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            product_unit_combobox.FormattingEnabled = true;
            product_unit_combobox.Items.AddRange(new object[] { "raw", "milliliter", "liter", "gram", "kilogram", "teaspoon", "tablespoon" });
            product_unit_combobox.Location = new Point(412, 203);
            product_unit_combobox.Name = "product_unit_combobox";
            product_unit_combobox.Size = new Size(161, 28);
            product_unit_combobox.TabIndex = 7;
            // 
            // product_unit_name
            // 
            product_unit_name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            product_unit_name.AutoSize = true;
            product_unit_name.Location = new Point(412, 180);
            product_unit_name.Name = "product_unit_name";
            product_unit_name.Size = new Size(36, 20);
            product_unit_name.TabIndex = 6;
            product_unit_name.Text = "Unit";
            // 
            // product_count_textbox
            // 
            product_count_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            product_count_textbox.Location = new Point(25, 203);
            product_count_textbox.Name = "product_count_textbox";
            product_count_textbox.Size = new Size(373, 27);
            product_count_textbox.TabIndex = 5;
            // 
            // product_count_label
            // 
            product_count_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            product_count_label.AutoSize = true;
            product_count_label.Location = new Point(25, 180);
            product_count_label.Name = "product_count_label";
            product_count_label.Size = new Size(271, 20);
            product_count_label.TabIndex = 4;
            product_count_label.Text = "Count (how much do you buy at a time)";
            // 
            // NewIngredient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 288);
            Controls.Add(product_count_label);
            Controls.Add(product_count_textbox);
            Controls.Add(product_unit_name);
            Controls.Add(product_unit_combobox);
            Controls.Add(product_price_textbox);
            Controls.Add(product_price_label);
            Controls.Add(product_name_textbox);
            Controls.Add(product_name_label);
            Controls.Add(add_product_button);
            MinimumSize = new Size(500, 335);
            Name = "NewIngredient";
            Text = "Add Ingredient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_product_button;
        private Label product_name_label;
        private TextBox product_name_textbox;
        private Label product_price_label;
        private TextBox product_price_textbox;
        private ComboBox product_unit_combobox;
        private Label product_unit_name;
        private TextBox product_count_textbox;
        private Label product_count_label;
    }
}