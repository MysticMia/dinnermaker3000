namespace dinnermaker3000
{
    partial class HomeScreen
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
            create_recipe_button = new Button();
            add_ingredient_button = new Button();
            SuspendLayout();
            // 
            // create_recipe_button
            // 
            create_recipe_button.Location = new Point(178, 115);
            create_recipe_button.Name = "create_recipe_button";
            create_recipe_button.Size = new Size(161, 42);
            create_recipe_button.TabIndex = 0;
            create_recipe_button.Text = "New Recipe";
            create_recipe_button.UseVisualStyleBackColor = true;
            create_recipe_button.Click += create_recipe_button_Click;
            // 
            // add_ingredient_button
            // 
            add_ingredient_button.Location = new Point(347, 217);
            add_ingredient_button.Name = "add_ingredient_button";
            add_ingredient_button.Size = new Size(170, 49);
            add_ingredient_button.TabIndex = 1;
            add_ingredient_button.Text = "New Ingredient";
            add_ingredient_button.UseVisualStyleBackColor = true;
            add_ingredient_button.Click += add_ingredient_button_Click;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(add_ingredient_button);
            Controls.Add(create_recipe_button);
            Name = "HomeScreen";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button create_recipe_button;
        private Button add_ingredient_button;
    }
}