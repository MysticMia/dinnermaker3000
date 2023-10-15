namespace dinnermaker3000
{
    partial class NewRecipe
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
            confirm_new_recipe_button = new Button();
            recipe_name_textbox = new TextBox();
            recipe_name_label = new Label();
            ingredient_name_label = new Label();
            ingredient_name_combobox = new ComboBox();
            ingredient_output_panel = new Panel();
            ingredient_count_label = new Label();
            ingredient_count_textbox = new TextBox();
            label2 = new Label();
            add_ingredient_button = new Button();
            ingredient_unit_label = new Label();
            unit_id_combobox = new ComboBox();
            SuspendLayout();
            // 
            // confirm_new_recipe_button
            // 
            confirm_new_recipe_button.Anchor = AnchorStyles.Bottom;
            confirm_new_recipe_button.Location = new Point(339, 511);
            confirm_new_recipe_button.Name = "confirm_new_recipe_button";
            confirm_new_recipe_button.Size = new Size(105, 30);
            confirm_new_recipe_button.TabIndex = 12;
            confirm_new_recipe_button.Text = "Add recipe";
            confirm_new_recipe_button.UseVisualStyleBackColor = true;
            confirm_new_recipe_button.Click += confirm_new_recipe_button_click;
            // 
            // recipe_name_textbox
            // 
            recipe_name_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            recipe_name_textbox.Location = new Point(25, 43);
            recipe_name_textbox.Name = "recipe_name_textbox";
            recipe_name_textbox.Size = new Size(732, 27);
            recipe_name_textbox.TabIndex = 2;
            // 
            // recipe_name_label
            // 
            recipe_name_label.AutoSize = true;
            recipe_name_label.Location = new Point(25, 20);
            recipe_name_label.Name = "recipe_name_label";
            recipe_name_label.Size = new Size(95, 20);
            recipe_name_label.TabIndex = 1;
            recipe_name_label.Text = "Recipe name";
            // 
            // ingredient_name_label
            // 
            ingredient_name_label.AutoSize = true;
            ingredient_name_label.Location = new Point(25, 80);
            ingredient_name_label.Name = "ingredient_name_label";
            ingredient_name_label.Size = new Size(118, 20);
            ingredient_name_label.TabIndex = 3;
            ingredient_name_label.Text = "Ingredient name";
            // 
            // ingredient_name_combobox
            // 
            ingredient_name_combobox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ingredient_name_combobox.AutoCompleteMode = AutoCompleteMode.Suggest;
            ingredient_name_combobox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            ingredient_name_combobox.Location = new Point(25, 103);
            ingredient_name_combobox.Name = "ingredient_name_combobox";
            ingredient_name_combobox.Size = new Size(732, 28);
            ingredient_name_combobox.TabIndex = 4;
            ingredient_name_combobox.TextChanged += ingredient_name_combobox_TextChanged;
            ingredient_name_combobox.Leave += ingredient_name_combobox_Leave;
            // 
            // ingredient_output_panel
            // 
            ingredient_output_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ingredient_output_panel.AutoScroll = true;
            ingredient_output_panel.Location = new Point(25, 275);
            ingredient_output_panel.Name = "ingredient_output_panel";
            ingredient_output_panel.Size = new Size(732, 230);
            ingredient_output_panel.TabIndex = 11;
            // 
            // ingredient_count_label
            // 
            ingredient_count_label.AutoSize = true;
            ingredient_count_label.Location = new Point(25, 140);
            ingredient_count_label.Name = "ingredient_count_label";
            ingredient_count_label.Size = new Size(118, 20);
            ingredient_count_label.TabIndex = 5;
            ingredient_count_label.Text = "Ingredient count";
            // 
            // ingredient_count_textbox
            // 
            ingredient_count_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ingredient_count_textbox.Location = new Point(25, 163);
            ingredient_count_textbox.Name = "ingredient_count_textbox";
            ingredient_count_textbox.Size = new Size(574, 27);
            ingredient_count_textbox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 252);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 10;
            label2.Text = "Output:";
            // 
            // add_ingredient_button
            // 
            add_ingredient_button.Location = new Point(25, 206);
            add_ingredient_button.Name = "add_ingredient_button";
            add_ingredient_button.Size = new Size(158, 29);
            add_ingredient_button.TabIndex = 9;
            add_ingredient_button.Text = "Add ingredient";
            add_ingredient_button.UseVisualStyleBackColor = true;
            add_ingredient_button.Click += add_ingredient_button_Click;
            // 
            // ingredient_unit_label
            // 
            ingredient_unit_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ingredient_unit_label.AutoSize = true;
            ingredient_unit_label.Location = new Point(613, 139);
            ingredient_unit_label.Name = "ingredient_unit_label";
            ingredient_unit_label.Size = new Size(36, 20);
            ingredient_unit_label.TabIndex = 7;
            ingredient_unit_label.Text = "Unit";
            // 
            // unit_id_combobox
            // 
            unit_id_combobox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            unit_id_combobox.AutoCompleteMode = AutoCompleteMode.Suggest;
            unit_id_combobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            unit_id_combobox.FormattingEnabled = true;
            unit_id_combobox.Items.AddRange(new object[] { "raw", "milliliter", "liter", "gram", "kilogram", "teaspoon", "tablespoon" });
            unit_id_combobox.Location = new Point(613, 162);
            unit_id_combobox.Name = "unit_id_combobox";
            unit_id_combobox.Size = new Size(144, 28);
            unit_id_combobox.TabIndex = 8;
            // 
            // NewRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(unit_id_combobox);
            Controls.Add(ingredient_unit_label);
            Controls.Add(add_ingredient_button);
            Controls.Add(label2);
            Controls.Add(ingredient_count_textbox);
            Controls.Add(ingredient_count_label);
            Controls.Add(ingredient_output_panel);
            Controls.Add(ingredient_name_combobox);
            Controls.Add(ingredient_name_label);
            Controls.Add(recipe_name_label);
            Controls.Add(recipe_name_textbox);
            Controls.Add(confirm_new_recipe_button);
            MinimumSize = new Size(350, 450);
            Name = "NewRecipe";
            Text = "Create new recipe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confirm_new_recipe_button;
        private TextBox recipe_name_textbox;
        private Label recipe_name_label;
        private Label ingredient_name_label;
        private ComboBox ingredient_name_combobox;
        private Panel ingredient_output_panel;
        private Label ingredient_count_label;
        private TextBox ingredient_count_textbox;
        private Label label2;
        private Button add_ingredient_button;
        private Label ingredient_unit_label;
        private ComboBox unit_id_combobox;
    }
}