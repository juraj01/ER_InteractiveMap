
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EldenRing___Interaktívna_mapa___Guna_UI
{
    public class connecttomysql
    {
        ///* Local Mysql
        private string server { get; } = "localhost";
        private string database { get; } = "registrationdatabase";
        private string username { get; } = "root";



        private string ConnectionString { get; }

        //Local Mysql
        public connecttomysql()
        {
            ConnectionString = $"SERVER={server};DATABASE={database};UID={username};";
        }

       
        public bool IsValueExistsName(string tableName, string columnName, string valueToCheck)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();

                string query = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @ValueToCheck";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ValueToCheck", valueToCheck);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool IsValueExistsLogin(string tableName, string column1, string column2, string value1, string value2)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();

                string query = $"SELECT COUNT(*) FROM {tableName} WHERE {column1} = @Value1 AND {column2} = @Value2";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Value1", value1);
                    cmd.Parameters.AddWithValue("@Value2", value2);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool InsertDataIntoUsers(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();

                string query = $"INSERT INTO `users` (`id`, `name`, `password`) VALUES(NULL, '{username}', '{password}');";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }

            }
        }
    }
}
