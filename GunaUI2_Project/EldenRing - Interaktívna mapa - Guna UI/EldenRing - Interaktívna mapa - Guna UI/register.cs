using System;
using System.Data.SqlClient;

namespace RegistraciaDatabazy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pripojenie k databaze
            SqlConnection connection = new SqlConnection("Server=YourServerName;Database=YourDatabaseName;Integrated Security=True;");
            try
            {
                connection.Open();

                // Vytvorenie registračnej tabuľky, ak neexistuje
                SqlCommand createTableCommand = new SqlCommand("CREATE TABLE IF NOT EXISTS Registrations (ID INT IDENTITY(1,1) PRIMARY KEY, Username NVARCHAR(50), Email NVARCHAR(50), Password NVARCHAR(50))", connection);
                createTableCommand.ExecuteNonQuery();

                // Vloženie nového záznamu do registračnej tabuľky
                string username = "TestUser";
                string email = "testuser@example.com";
                string password = "TestPassword"; // Môžete použiť bezpečnějšie spôsoby uchovávania hesiel, ako je hašovanie.
                SqlCommand insertCommand = new SqlCommand("INSERT INTO Registrations (Username, Email, Password) VALUES (@Username, @Email, @Password)", connection);
                insertCommand.Parameters.AddWithValue("@Username", username);
                insertCommand.Parameters.AddWithValue("@Email", email);
                insertCommand.Parameters.AddWithValue("@Password", password);
                insertCommand.ExecuteNonQuery();

                Console.WriteLine("Registracia bola úspešne vykonaná.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba: " + ex.Message);
            }
            finally
            {
                // Uzavretie pripojenia k databáze
                connection.Close();
            }

            Console.ReadLine();
        }
    }
}