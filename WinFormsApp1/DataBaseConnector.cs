using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections;

namespace WinFormsApp1
{
    public class DataBaseConnector
    {
        private string connectionString = "Server=localhost;Database=hospital;Uid=root;Pwd=root1;";
        private MySqlConnection connection;

        // konstruktor
        public DataBaseConnector()
        {
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }


        public bool UserLogin(string userName, string userPassword)
        {
            try
            {
                connection.Open();
                string query = "SELECT Username, Password FROM users WHERE Username = @userName";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@userName", userName);

                MySqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    string username = reader["Username"].ToString();
                    string password = reader["Password"].ToString();

                    if (username == userName && password == userPassword)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Błąd połączenia z bazą danych " + ex);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
