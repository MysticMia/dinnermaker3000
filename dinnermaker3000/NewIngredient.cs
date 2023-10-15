using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinnermaker3000
{
    public partial class NewIngredient : Form
    {
        readonly SQLiteConnection sqlite_conn;

        public NewIngredient(SQLiteConnection conn)
        {
            sqlite_conn = conn;
            InitializeComponent();
        }

        public void add_product_button_click(object sender, EventArgs e)
        {
            string? empty_field_name = null;
            if (product_name_textbox.Text == "")
            {
                empty_field_name = product_name_label.Text;
            }
            else if (product_count_textbox.Text == "")
            {
                empty_field_name = product_count_label.Text;
            }
            else if (product_price_textbox.Text == "")
            {
                empty_field_name = product_price_label.Text;
            }
            else if (product_unit_combobox.SelectedIndex == -1)
            {
                empty_field_name = product_unit_name.Text;
            }

            if (empty_field_name is not null)
            {
                MessageBox.Show($"'{empty_field_name}' is a required field!",
                    "Invalid data given", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double product_count;
            try
            {
                product_count = double.Parse(product_count_textbox.Text);
            }
            catch
            {
                MessageBox.Show($"'{product_count_textbox.Text}' is not a valid value for 'count'!",
                    "Invalid data given", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            double product_price;
            try
            {
                product_price = double.Parse(product_price_textbox.Text);
            }
            catch
            {
                MessageBox.Show($"'{product_price_textbox.Text}' is not a valid value for 'price'!",
                    "Invalid data given", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };


            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = @"
                INSERT INTO
                    Ingredients(name, price_per_unit, unit)
                VALUES
                    (@name, @price_per_unit, @unit);
                ";
            sqlite_cmd.Parameters.AddWithValue("@name", product_name_textbox.Text);
            sqlite_cmd.Parameters.AddWithValue("@price_per_unit", product_price / product_count);
            sqlite_cmd.Parameters.AddWithValue("@unit", Utils.UnitAccronyms[product_unit_combobox.SelectedIndex]);
            // [price]$ per [unit] [item]
            // example: [4]$ per [kilogram] [apples]
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (SQLiteException)
            {
                MessageBox.Show($"A product with the name '{product_name_textbox.Text}' has already been defined previously!",
                    "Product already exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Close();
        }
    }
}
