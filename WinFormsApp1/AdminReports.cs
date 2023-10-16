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
    public partial class AdminReports : Form
    {
        DataBaseConnector connector = new DataBaseConnector();
        public int PatientID { get; set; }
        public string PatientRoomType { get; set; }
        public AdminReports()
        {
            InitializeComponent();
        }

        private void AdminReports_Load(object sender, EventArgs e)
        {
            Room__Shifting__SELECT__By__PatientName();
            SELECT__Patient__Room();
        }

        private void Room__Shifting__SELECT__By__PatientName()
        {
            try
            {
                connector.connection.Open();

                string query = "SELECT PatientName FROM patients";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["PatientName"].ToString());
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

        private void SELECT__Patient__Details()
        {
            try
            {
                connector.connection.Open();

                string query = "SELECT * FROM patients";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (comboBox1.SelectedItem.ToString() == reader["PatientName"].ToString())
                    {
                        label58.Text = reader["PatientName"].ToString();
                        label57.Text = reader["Mobile"].ToString();
                        label56.Text = reader["Address"].ToString();
                        label55.Text = reader["City"].ToString();
                        label54.Text = reader["Pincode"].ToString();
                        label53.Text = reader["ReferByDoctor"].ToString();
                        label52.Text = reader["Disease"].ToString();
                        label51.Text = reader["HandleByDoctor"].ToString();
                        label39.Text = reader["RoomType"].ToString();
                        label38.Text = reader["EstimatedBill"].ToString();
                        PatientID = (int)reader["PatientID"];
                        PatientRoomType = reader["RoomType"].ToString();
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

        private void SELECT__Patient__Room__By__PatientRoomType()
        {
            try
            {
                connector.connection.Open();
                string query = "SELECT RoomType, RateDay FROM rooms WHERE RoomType = @RoomType";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                command.Parameters.AddWithValue("@RoomType", PatientRoomType);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["RoomType"].ToString() == PatientRoomType)
                    {
                        label31.Text = reader["RoomType"].ToString();
                        label30.Text = reader["RateDay"].ToString();
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

        private void SELECT__Patient__Room()
        {
            try
            {
                connector.connection.Open();
                string query = "SELECT RoomType FROM rooms";
                MySqlCommand command = new MySqlCommand(query, connector.connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["RoomType"].ToString());
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

        private void UPDATE__Patient__Room(string choosenPatientRoom)
        {
            try
            {
                connector.connection.Open();
                string query = "UPDATE patients SET RoomType = @RoomType WHERE PatientID = @PatientID";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                command.Parameters.AddWithValue("@RoomType", choosenPatientRoom);
                command.Parameters.AddWithValue("@PatientID", PatientID);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Room type has been updated");
                }
                else
                {
                    MessageBox.Show("Error has been occured.");
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



        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                panel5.Visible = true;
                SELECT__Patient__Details();
                SELECT__Patient__Room__By__PatientRoomType();
            }
            else
            {
                MessageBox.Show("You must choose patient name.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to make this operation?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (comboBox2.SelectedIndex != -1)
            {
                if(result == DialogResult.Yes)
                {
                    string choosenPatientRoom = comboBox2.Text;
                    UPDATE__Patient__Room(choosenPatientRoom);
                    panel5.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("The room type must be chosen");
            }
        }
    }
}
