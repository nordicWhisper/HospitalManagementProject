using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public bool AddRooms(string roomType, int totalRoom, int rateDay)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO rooms (RoomType, TotalRoom, RateDay) VALUES (@RoomType, @TotalRoom, @RateDay)";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@RoomType", roomType);
                command.Parameters.AddWithValue("@TotalRoom", totalRoom);
                command.Parameters.AddWithValue("@RateDay", rateDay);

                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Room detail has added successfully.");
                return rowsAffected > 0;
            } catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
                return false;
            } finally
            {
                connection.Close();
            }
        }

        public void ShowRoomReports(DataGridView dataGridView)
        {
            try
            {
                connection.Open();

                string query = "SELECT RoomID, RoomType, TotalRoom, RateDay, EntryDate FROM rooms";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void EditRoomDetailSELECT(System.Windows.Forms.ComboBox comboBox)
        {
            try
            {
                connection.Open();

                string query = "SELECT RoomType FROM rooms";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox.Items.Add(reader["RoomType"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void EditRoomDetailUPDATE(string roomType, int totalRoom, int rateDay)
        {
            try
            {
                connection.Open();

                string query = "UPDATE rooms SET TotalRoom = @TotalRoom, RateDay = @RateDay WHERE RoomType = @RoomType";

 
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@RoomType", roomType);
                    command.Parameters.AddWithValue("@TotalRoom", totalRoom);
                    command.Parameters.AddWithValue("@RateDay", rateDay);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data has been update.");
                    }
                    else
                    {
                        MessageBox.Show("All data must be write.");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
