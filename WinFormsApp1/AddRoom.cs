using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddRoom : Form
    {
        DataBaseConnector connector = new DataBaseConnector();
        public AddRoom()
        {
            InitializeComponent();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            ShowRoomReports(dataGridView1);
            EditRoomDetailSELECT(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string roomtype = textBox1.Text;
            string totalroom = textBox2.Text;
            string rateday = textBox3.Text;

            AddRooms(roomtype, Int32.Parse(totalroom), Int32.Parse(rateday));
            ShowRoomReports(dataGridView1);
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                string totalroom = textBox5.Text;
                string rateday = textBox4.Text;

                EditRoomDetailUPDATE(selectedItem, totalroom, rateday);
                ShowRoomReports(dataGridView1);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Nic nie zostało wybrane z listy ComboBox.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex != -1)
            {

                DialogResult result = MessageBox.Show("Are you sure to do this?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string selectedItem = comboBox1.SelectedItem.ToString();
                    EditRoomDetailDELETE(selectedItem);
                    ShowRoomReports(dataGridView1);
                    dataGridView1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Nic nie zostało wybrane z listy ComboBox.");
            }
        }


        private bool AddRooms(string roomType, int totalRoom, int rateDay)
        {
            try
            {
                connector.connection.Open();
                string query = "INSERT INTO rooms (RoomType, TotalRoom, RateDay) VALUES (@RoomType, @TotalRoom, @RateDay)";
                MySqlCommand command = new MySqlCommand(query, connector.connection);

                command.Parameters.AddWithValue("@RoomType", roomType);
                command.Parameters.AddWithValue("@TotalRoom", totalRoom);
                command.Parameters.AddWithValue("@RateDay", rateDay);

                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Room detail has added successfully.");
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
                return false;
            }
            finally
            {
                connector.connection.Close();
            }
        }

        private void ShowRoomReports(DataGridView dataGridView)
        {
            try
            {
                connector.connection.Open();

                string query = "SELECT RoomID, RoomType, TotalRoom, RateDay, EntryDate FROM rooms";
                MySqlCommand command = new MySqlCommand(query, connector.connection);

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
                connector.connection.Close();
            }
        }

        private void EditRoomDetailSELECT(System.Windows.Forms.ComboBox comboBox)
        {
            try
            {
                connector.connection.Open();

                string query = "SELECT RoomType FROM rooms";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Refresh();

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
                connector.connection.Close();
            }
        }

        private void EditRoomDetailUPDATE(string roomType, string totalRoom, string rateDay)
        {
            try
            {
                if (totalRoom != string.Empty && rateDay != string.Empty)
                {
                    connector.connection.Open();
                    string query = "UPDATE rooms SET TotalRoom = @TotalRoom, RateDay = @RateDay WHERE RoomType = @RoomType";

                    MySqlCommand command = new MySqlCommand(query, connector.connection);

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
                        MessageBox.Show("Incorrect char or text.");
                    }
                }
                else if (rateDay != string.Empty)
                {
                    connector.connection.Open();
                    string query = "UPDATE rooms SET RateDay = @RateDay WHERE RoomType = @RoomType";

                    MySqlCommand command = new MySqlCommand(query, connector.connection);

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
                        MessageBox.Show("Incorrect char or text.");
                    }
                }
                else if (totalRoom != string.Empty)
                {
                    connector.connection.Open();
                    string query = "UPDATE rooms SET TotalRoom = @TotalRoom WHERE RoomType = @RoomType";

                    MySqlCommand command = new MySqlCommand(query, connector.connection);

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
                        MessageBox.Show("Incorrect char or text.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
            finally
            {
                connector.connection.Close();
            }
        }

        private void EditRoomDetailDELETE(string roomType)
        {
            try
            {
                connector.connection.Open();

                string query = "DELETE FROM rooms WHERE RoomType=@RoomType;";


                MySqlCommand command = new MySqlCommand(query, connector.connection);

                command.Parameters.AddWithValue("@RoomType", roomType);

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
                connector.connection.Close();
            }
        }
    }
}
