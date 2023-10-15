using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinnermaker3000
{
    public partial class NewRecipe : Form
    {
        List<(string name, double count, Utils.UnitID unit_id)> ingredients = new();
        readonly SQLiteConnection sqlite_conn;

        public NewRecipe(SQLiteConnection conn)
        {
            sqlite_conn = conn;
            InitializeComponent();

            //SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            //sqlite_cmd.CommandText = @"SELECT name FROM Ingredients LIMIT 5;";
            //SQLiteDataReader sqlite_ingredient_datareader = sqlite_cmd.ExecuteReader();
            //while (sqlite_ingredient_datareader.Read())
            //{
            //    ingredient_name_combobox.Items.Add(sqlite_ingredient_datareader.GetValue(0).ToString()); // ingredient name
            //}
        }

        // button events

        private void add_ingredient_button_Click(object sender, EventArgs e)
        {
            string? empty_field_name = null;
            if (ingredient_name_combobox.Text == "")
            {
                empty_field_name = ingredient_name_label.Text;
            }
            else if (ingredient_count_label.Text == "")
            {
                empty_field_name = ingredient_count_label.Text;
            }
            else if (unit_id_combobox.SelectedIndex == -1)
            {
                empty_field_name = ingredient_unit_label.Text;
            }
            if (empty_field_name is not null)
            {
                MessageBox.Show($"'{empty_field_name}' is a required field!",
                    "Invalid data given", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double ingredient_count;
            try
            {
                ingredient_count = double.Parse(ingredient_count_textbox.Text);
            }
            catch
            {
                MessageBox.Show($"'{ingredient_count_textbox.Text}' is not a valid ingredient count!",
                    "Invalid data given", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };



            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = @"
                    SELECT id 
                    FROM Ingredients 
                    WHERE Ingredients.name = @ingredient_name
                    ORDER BY id DESC
                    LIMIT 1;";
            sqlite_cmd.Parameters.AddWithValue("@ingredient_name", ingredient_name_combobox.Text);
            var ingredient_search = sqlite_cmd.ExecuteScalar();
            if (ingredient_search is null)
            {
                MessageBox.Show($"No ingredient with the name '{ingredient_name_combobox.Text}' found!\nYou may have to add to the database first.",
                    "404: Ingredient not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ingredients.Add((ingredient_name_combobox.Text, ingredient_count, (Utils.UnitID)unit_id_combobox.SelectedIndex));
            update_ingredient_preview();

            ingredient_name_combobox.Text = "";
            ingredient_count_textbox.Text = "";
            unit_id_combobox.SelectedIndex = -1;
        }

        private void confirm_new_recipe_button_click(object sender, EventArgs e)
        {
            if (recipe_name_textbox.Text == "")
            {
                MessageBox.Show($"'{recipe_name_label.Text}' is a required field!",
                    "Invalid data given", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ingredients.Count <= 0)
            {
                MessageBox.Show("You need at least one ingredient for your recipe!",
                    "Missing ingredients", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Utils.add_recipe(recipe_name_textbox.Text, ingredients);
            Close();
        }

        private void remove_ingredient_click(object sender, EventArgs e)
        {
            ingredients.RemoveAt(int.Parse(((Button)sender).Name));
            update_ingredient_preview();
        }

        // backstage events

        private void update_ingredient_preview()
        {
            ingredient_output_panel.Controls.Clear();
            for (int index = 0; index < ingredients.Count; index++)
            {
                int y_position = ingredient_output_panel.Controls.Count * 10 + 10; // 3 elements at a time: 3*10=30 spacing

                Button i_remove_button = new Button();
                i_remove_button.Location = new Point(10, y_position);
                i_remove_button.Text = "remove";
                i_remove_button.Size = new Size(100, 30);
                i_remove_button.Name = index.ToString();
                i_remove_button.Click += remove_ingredient_click;
                i_remove_button.BackColor = Color.FromArgb(255, 180, 180);
                ingredient_output_panel.Controls.Add(i_remove_button);

                Label i_count_and_unit_label = new Label();
                i_count_and_unit_label.Location = new Point(130, y_position);
                i_count_and_unit_label.Text = ingredients[index].count.ToString() + Utils.unit_string(ingredients[index].unit_id);
                i_count_and_unit_label.Width = 100;
                ingredient_output_panel.Controls.Add(i_count_and_unit_label);

                Label i_name_label = new Label();
                i_name_label.Location = new Point(130 + 100 + 10, y_position);
                i_name_label.Text = ingredients[index].name;
                i_name_label.AutoSize = true;
                ingredient_output_panel.Controls.Add(i_name_label);
            }
        }

        private void ingredient_name_combobox_TextChanged(object sender, EventArgs e)
        {
            //ingredient_autocomplete = new();
            string txt = ingredient_name_combobox.Text;
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = @"SELECT name FROM Ingredients 
                        WHERE name LIKE @name || '%'
                        LIMIT 5;";
            sqlite_cmd.Parameters.AddWithValue("@name", ingredient_name_combobox.Text);
            SQLiteDataReader sqlite_ingredient_datareader = sqlite_cmd.ExecuteReader();
            //ingredient_autocomplete.Clear();

            ingredient_name_combobox.Items.Clear();
            while (sqlite_ingredient_datareader.Read())
            {
                ingredient_name_combobox.Items.Add(sqlite_ingredient_datareader.GetValue(0).ToString()); // ingredient name
            }
            ingredient_name_combobox.DroppedDown = true;
            ingredient_name_combobox.SelectionStart = txt.Length;
            if (ingredient_name_combobox.Items.Count > 0)
            {
                ingredient_name_combobox.SelectionLength = ingredient_name_combobox.Items[0].ToString().Length - txt.Length;
            }
            Cursor.Current = Cursors.Default;
        }

        private void ingredient_name_combobox_Leave(object sender, EventArgs e)
        {
            ingredient_name_combobox.DroppedDown = false;
        }
    }
}
