using System.Data.SQLite;
using System.Data;

namespace dinnermaker3000
{
    public partial class HomeScreen : Form
    {
        readonly SQLiteConnection sqlite_conn;

        public HomeScreen()
        {
            sqlite_conn = Utils.CreateConnection();
            //Utils.create_database(sqlite_conn);
            InitializeComponent();
        }

        private void create_recipe_button_Click(object sender, EventArgs e)
        {
            new NewRecipe(sqlite_conn).Show();
        }

        private void add_ingredient_button_Click(object sender, EventArgs e)
        {
            new NewIngredient(sqlite_conn).Show();
        }
    }

    public static class Utils
    {
        public readonly static string[] UnitNames = {
                             "raw","milliliter","liter","gram","kilogram","teaspoon","tablespoon" };
        public enum UnitID { raw, milliliter, liter, gram, kilogram, teaspoon, tablespoon };
        public readonly static string[] UnitAccronyms = {
                             "",    "mL",        "L",    "g",   "kg",      "tsp.",   "tbsp."};


        public static string unit_string(UnitID unit)
        {
            switch (unit)
            {
                case UnitID.raw:
                    return "";
                case UnitID.milliliter:
                    return " mL";
                case UnitID.liter:
                    return " L";
                case UnitID.gram:
                    return " g";
                case UnitID.kilogram:
                    return " kg";
                case UnitID.teaspoon:
                    return " tsp.";
                case UnitID.tablespoon:
                    return " tbsp.";
            }
            throw new Exception("invalid unit id selected (and no exception handler)");
        }

        public static void create_database(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = @"
            CREATE TABLE IF NOT EXISTS [Recipes] (
                [id] INTEGER PRIMARY KEY,
                [name] TEXT UNIQUE
            );

            CREATE INDEX IF NOT EXISTS idx_recipes_name
            ON Recipes(name);

            CREATE TABLE IF NOT EXISTS [Ingredients] (
                [id] INTEGER PRIMARY KEY,
                [name] TEXT UNIQUE NOT NULL,
                [price_per_unit] DOUBLE NOT NULL,
                [unit] VARCHAR(15) NOT NULL
            );

            CREATE INDEX IF NOT EXISTS idx_ingredients_name
            ON Ingredients(name);

            CREATE TABLE IF NOT EXISTS [Recipe_Ingredients] (
                [id] INTEGER PRIMARY KEY,
                [recipe_id] INTEGER NOT NULL,
                [ingredient_id] INTEGER NOT NULL,
                [ingredient_count] DOUBLE NOT NULL,
                [unit] VARCHAR(15),
                FOREIGN KEY (recipe_id) REFERENCES Recipes(id),
                FOREIGN KEY (ingredient_id) REFERENCES Ingredients(id)
            );";

            //try
            //{
            sqlite_cmd.ExecuteNonQuery();
            //    Console.WriteLine("Database gemaakt!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Initialization error: --" /*+ ex + "\r\n==============================="*/);
            //}
        }


        public static void add_recipe(string name, List<(string name, double count, UnitID unit_id)> ingredients)
        {
            //double cost = get_recipe_cost(ingredients);
        }

        private static double get_recipe_cost(SQLiteConnection conn, List<(string name, double count, UnitID unit_id)> ingredients)
        {
            SQLiteCommand sqlite_cmd = conn.CreateCommand();

            double cost = 0;
            foreach ((string name, double count, UnitID unit_id) ingredient in ingredients)
            {
                sqlite_cmd.CommandText = @"
                    SELECT id 
                    FROM Ingredients 
                    WHERE Ingredients.name = @ingredient_name
                    ORDER BY id DESC
                    LIMIT 1;";
                sqlite_cmd.Parameters.AddWithValue("@ingredient_name", ingredient.name);
                var ingredient_search = sqlite_cmd.ExecuteScalar();
                if (ingredient_search == null)
                {
                    throw new InvalidCastException("symptoom ID niet gevonden.");
                    // commented out in case a Subcategorie had been selected.
                    // overall, it shouldn't give an error if you clicked the boxes like normal
                }
            }
            return cost;
        }


        public static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            string userName = Environment.UserName;
            sqlite_conn = new SQLiteConnection("Data Source=" +
                Directory.GetCurrentDirectory() + "\\dinnermaker_data.db");
            // Open the connection:
            //try
            //{
            sqlite_conn.Open();
            //Console.Write("{|");
            //}
            //catch (Exception ex)
            //{
            //    //Console.WriteLine("COULD NOT OPEN CONNECTION!\r\n" +
            //    //    "Either the file is not accessable/created, or something is blocking access to do so (eg. AntiVirus)"); // TODO
            //    throw new DataException("Could not open SQLite connection!" + ex);
            //}
            return sqlite_conn;
        }
    }
}