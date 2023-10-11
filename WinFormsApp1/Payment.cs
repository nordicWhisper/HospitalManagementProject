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
    public partial class Payment : Form
    {
        DataBaseConnector connector = new DataBaseConnector();
        public int PatientID { get; set; }
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            PatientBill__SELECT__By__PatientName();
        }

        //panel7
        private void ShowPatientDetails()
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
                        label59.Text = reader["PatientName"].ToString();
                        label58.Text = reader["Mobile"].ToString();
                        label57.Text = reader["Address"].ToString();
                        label56.Text = reader["City"].ToString();
                        label9.Text = reader["Pincode"].ToString();
                        label54.Text = reader["ReferByDoctor"].ToString();
                        label53.Text = reader["Disease"].ToString();
                        label52.Text = reader["HandleByDoctor"].ToString();
                        label51.Text = reader["RoomType"].ToString();
                        label11.Text = reader["EstimatedBill"].ToString();
                        PatientID = (int)reader["PatientID"];
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

        private void PatientBill__SELECT__By__PatientName()
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
                    comboBox6.Items.Add(reader["PatientName"].ToString());
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
                panel8.Visible = true;
                ShowPatientDetails();
            }
            else
            {
                MessageBox.Show("You must choose patient name.");
            }
        }
    }
}
