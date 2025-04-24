using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMP_Proiect_3
{
    internal class SQLiteHandler
    {

        public static SQLiteConnection SQLiteConnect()
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=project3db.sqlite; Version=3;");
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
            }
            return conn;
        }


        public static async Task<List<string>> GetAllTables(SQLiteConnection conn, int propritate)
        {

            List<string> tip1 = new List<string>();


            tip1 = await Task.Run(async () =>
            {
            List<string> tip = new List<string>();

            SQLiteDataReader reader = null;

            SQLiteCommand cmd = conn.CreateCommand();

            if (propritate == 1)
            {
                cmd.CommandText = "SELECT name FROM sqlite_master WHERE type = 'table' AND name NOT LIKE 'sqlite_%' AND name NOT LIKE 'Accounts%';";
            }
            else if (propritate == 0)
            {
                cmd.CommandText = "SELECT name FROM sqlite_master WHERE type = 'table' AND name NOT LIKE 'sqlite_%' AND name NOT LIKE 'Categorie_%' AND name NOT LIKE 'Accounts%';";
            }
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tip.Add(reader.GetString(0));
            }

            return tip;
            });


            return tip1;
        }
        
        public static List<int> GetAllId(SQLiteConnection conn)
        {
            List<int> id = new List<int>();

            SQLiteDataReader reader = null;

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT Id FROM Produse";

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                id.Add(reader.GetInt32(0));
            }

            return id;

        }

        public static List<int> GetAllIdFromCategorii(SQLiteConnection conn)
        {
            List<int> id = new List<int>();

            SQLiteDataReader reader = null;

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT Id FROM CategorieProdus";

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                id.Add(reader.GetInt32(0));
            }

            return id;

        }


        public static async Task<List<string>>  GetAllCategories(SQLiteConnection conn)
        {


            List<string> categorie1 = new List<string>();


            categorie1 = await Task.Run(async () =>
            { 

                List<string> categorie = new List<string>();

            SQLiteDataReader reader = null;

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM CategorieProdus";

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                categorie.Add(reader.GetString(1));
            }
                return categorie;

            });

            return categorie1;

        }
        
        public static int GetId(SQLiteConnection conn, int id)
        {
            int ids = 0;

            SQLiteDataReader reader = null;

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT Id FROM Produse WHERE Id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ids = reader.GetInt32(0);
            }

            return ids;

        }
        
        public static int GetCantitate(SQLiteConnection conn, int id)
        {
            int ctt=0;

            SQLiteDataReader reader = null;

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT Cantitate FROM Produse WHERE Id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ctt=reader.GetInt32(0);
            }

            return ctt;

        }

        
        public static void ScadeCantitate(SQLiteConnection conn, int id, int cantitate)
        {

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Produse SET Cantitate = Cantitate - @cantitate WHERE Id = @id";
            cmd.Parameters.AddWithValue("@cantitate", cantitate);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

        }

        public static void StergereProdus(SQLiteConnection conn, int id)
        {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Produse WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Stergere cu succes!");
        }

        public static void StergereCategorie(SQLiteConnection conn, string categorie)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM CategorieProdus WHERE Categorie = @categorie";
            cmd.Parameters.AddWithValue("@categorie", categorie);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Categoria a fost stearsa!");
        }

        public static void StergereProduseleCategoriei(SQLiteConnection conn, string categorie)
        {
            SQLiteDataReader reader = null;

            SQLiteCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "DELETE FROM Produse WHERE Categorie = @categorie";
            cmd1.Parameters.AddWithValue("@categorie", categorie);
            cmd1.ExecuteNonQuery();
            Console.WriteLine("Toate produsele din categorie au fost sterse!");
        }

        public static Produse GetDetailedInfo(SQLiteConnection conn, int id)
        {
            Produse prod = new Produse();

            SQLiteDataReader reader = null;

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT Id FROM Produse WHERE Id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                prod.Id = reader.GetInt32(0);
            }


            SQLiteCommand cmd1 = conn.CreateCommand();

            cmd1.CommandText = "SELECT Denumire FROM Produse WHERE Id = @id";
            cmd1.Parameters.AddWithValue("@id", id);
            reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                prod.Denumire = reader.GetString(0);
            }


            SQLiteCommand cmd2 = conn.CreateCommand();

            cmd2.CommandText = "SELECT Descriere FROM Produse WHERE Id = @id";
            cmd2.Parameters.AddWithValue("@id", id);
            reader = cmd2.ExecuteReader();

            while (reader.Read())
            {
                prod.Descriere = reader.GetString(0);
            }


            SQLiteCommand cmd3 = conn.CreateCommand();

            cmd3.CommandText = "SELECT Data_intrarii FROM Produse WHERE Id = @id";
            cmd3.Parameters.AddWithValue("@id", id);
            reader = cmd3.ExecuteReader();

            while (reader.Read())
            {
                prod.Data_intrarii = reader.GetString(0);
            }


            SQLiteCommand cmd4 = conn.CreateCommand();

            cmd4.CommandText = "SELECT Data_iesirii FROM Produse WHERE Id = @id";
            cmd4.Parameters.AddWithValue("@id", id);
            reader = cmd4.ExecuteReader();

            while (reader.Read())
            {
                prod.Data_iesirii = reader.GetString(0);
            }


            SQLiteCommand cmd5 = conn.CreateCommand();

            cmd5.CommandText = "SELECT Termen_de_valabilitate FROM Produse WHERE Id = @id";
            cmd5.Parameters.AddWithValue("@id", id);
            reader = cmd5.ExecuteReader();

            while (reader.Read())
            {
                prod.Termen_de_valabilitate = reader.GetString(0);
            }


            SQLiteCommand cmd6 = conn.CreateCommand();

            cmd6.CommandText = "SELECT Cantitate FROM Produse WHERE Id = @id";
            cmd6.Parameters.AddWithValue("@id", id);
            reader = cmd6.ExecuteReader();

            while (reader.Read())
            {
                prod.Cantitate = reader.GetInt32(0);
            }


            SQLiteCommand cmd7 = conn.CreateCommand();

            cmd7.CommandText = "SELECT Categorie FROM Produse WHERE Id = @id";
            cmd7.Parameters.AddWithValue("@id", id);
            reader = cmd7.ExecuteReader();

            while (reader.Read())
            {
                prod.Categorie = reader.GetString(0);
            }

            return prod;

        }


        public static bool ValidateUsername(SQLiteConnection conn, string username)
        {

            bool valid = false;

            string validuser = null;

            SQLiteDataReader reader = null;

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT Username FROM Accounts WHERE Username = @username";
            cmd.Parameters.AddWithValue("@username", username);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                validuser = reader.GetString(0);
            }

            if (validuser == username)
            {
                return true;
            } 
            else 
            { 
                return false; 
            }

        }
        
        public static bool ValidateNume(SQLiteConnection conn, string username, string Nume)
        {

            string validNume = null;

            SQLiteDataReader reader = null;

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT Nume FROM Accounts WHERE Username = @username";
            cmd.Parameters.AddWithValue("@username", username);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                validNume = reader.GetString(0);
            }

            if (validNume.Equals(Nume))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void ModificaNume(SQLiteConnection conn, string Username, string Nume)
        {

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Accounts SET Nume = @nume WHERE Username = @username";
            cmd.Parameters.AddWithValue("@nume", Nume);
            cmd.Parameters.AddWithValue("@username", Username);
            cmd.ExecuteNonQuery();

        }

        
        public static bool ValidatePrenume(SQLiteConnection conn, string username, string Prenume)
        {

            string validNume = null;

            SQLiteDataReader reader = null;

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT Prenume FROM Accounts WHERE Username = @username";
            cmd.Parameters.AddWithValue("@username", username);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                validNume = reader.GetString(0);
            }

            if (validNume.Equals(Prenume))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void ModificaPrenume(SQLiteConnection conn, string Username, string Prenume)
        {

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Accounts SET Prenume = @prenume WHERE Username = @username";
            cmd.Parameters.AddWithValue("@prenume", Prenume);
            cmd.Parameters.AddWithValue("@username", Username);
            cmd.ExecuteNonQuery();

        }
        
        public static string GetPassword(SQLiteConnection conn, string username)
        {

            string passhash = null;

            SQLiteDataReader reader = null;

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT Password FROM Accounts WHERE Username = @username";
            cmd.Parameters.AddWithValue("@username", username);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                passhash = reader.GetString(0);
            }

            return passhash;

        }

        public static void ModificaPassword(SQLiteConnection conn, string Username, string Password)
        {

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Accounts SET Password = @password WHERE Username = @username";
            cmd.Parameters.AddWithValue("@password", Password);
            cmd.Parameters.AddWithValue("@username", Username);
            cmd.ExecuteNonQuery();

        }

        public static Accounts GetUserInfo(SQLiteConnection conn, string username)
        {

            Accounts p1 = new Accounts();

            SQLiteDataReader reader = null;

            // p/u Nume
            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT Nume FROM Accounts WHERE Username = @username";
            cmd.Parameters.AddWithValue("@username", username);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                p1.Nume = reader.GetString(0);
            }

            // p/u Prenume
            SQLiteCommand cmd1 = conn.CreateCommand();

            cmd1.CommandText = "SELECT Prenume FROM Accounts WHERE Username = @username";
            cmd1.Parameters.AddWithValue("@username", username);
            reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                p1.Prenume = reader.GetString(0);
            }

            // p/u Username
            SQLiteCommand cmd2 = conn.CreateCommand();

            cmd2.CommandText = "SELECT Username FROM Accounts WHERE Username = @username";
            cmd2.Parameters.AddWithValue("@username", username);
            reader = cmd2.ExecuteReader();

            while (reader.Read())
            {
                p1.Username = reader.GetString(0);
            }

            //p/u Parola
            SQLiteCommand cmd3 = conn.CreateCommand();

            cmd3.CommandText = "SELECT Password FROM Accounts WHERE Username = @username";
            cmd3.Parameters.AddWithValue("@username", username);
            reader = cmd3.ExecuteReader();

            while (reader.Read())
            {
                p1.Password = reader.GetString(0);
            }

            // p/u prioritate
            SQLiteCommand cmd4 = conn.CreateCommand();

            cmd4.CommandText = "SELECT Administrator FROM Accounts WHERE Username = @username";
            cmd4.Parameters.AddWithValue("@username", username);
            reader = cmd4.ExecuteReader();

            while (reader.Read())
            {
                p1.Administrator = reader.GetInt32(0);
            }

            return p1;

        }

        public static void StergereCont(SQLiteConnection conn, string Username)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Accounts WHERE Username = @username";
            cmd.Parameters.AddWithValue("@username", Username);
            cmd.ExecuteNonQuery();
        }

    }
}
