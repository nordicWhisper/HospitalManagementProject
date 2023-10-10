using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class AddBill : Form
    {
        DataBaseConnector connector = new DataBaseConnector();
        public string MobilePhonePatient { get; }
        public int PatientID { get; }

        public AddBill(string mobilePhonePatient, int patientID)
        {
            InitializeComponent();
            MobilePhonePatient = mobilePhonePatient;
            PatientID = patientID;
        }

        private void AddBill_Load(object sender, EventArgs e)
        {
            ShowPatientReports();
            ShowRoomReports();
        }

        private void ShowPatientReports()
        {
            try
            {
                connector.connection.Open();

                string query = "SELECT * FROM patients";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (MobilePhonePatient == reader["Mobile"].ToString())
                    {
                        label41.Text = reader["PatientName"].ToString();
                        label42.Text = reader["Mobile"].ToString();
                        label43.Text = reader["Address"].ToString();
                        label44.Text = reader["City"].ToString();
                        label45.Text = reader["Pincode"].ToString();
                        label46.Text = reader["ReferByDoctor"].ToString();
                        label47.Text = reader["Disease"].ToString();
                        label48.Text = reader["HandleByDoctor"].ToString();
                        label49.Text = reader["RoomType"].ToString();
                        label50.Text = reader["EstimatedBill"].ToString();
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

        private void ShowRoomReports()
        {
            try
            {
                connector.connection.Open();

                string query = "SELECT * FROM rooms";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    if (label49.Text == reader["RoomType"].ToString())
                    {
                        label33.Text = reader["RateDay"].ToString();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double textToDouble = 0;
            if (double.TryParse(textBox1.Text, out double value))
            {
                textToDouble = value * double.Parse(label33.Text);
            }
            else
            {
                textToDouble = 0;
            }
            label4.Text = textToDouble.ToString();
            Sum();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label9.Text = textBox2.Text;
            Sum();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label10.Text = textBox3.Text;
            Sum();
        }

        private void Sum()
        {
            double value1, value2, value3;

            if (double.TryParse(label4.Text, out value1) &&
                double.TryParse(label9.Text, out value2) &&
                double.TryParse(label10.Text, out value3))
            {
                double result = value1 + value2 + value3;
                label36.Text = result.ToString();
                label12.Text = result.ToString();
            }
            else
            {
                label36.Text = "Błąd: Nieprawidłowe dane";
                label12.Text = "Błąd: Nieprawidłowe dane";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connector.connection.Open();

                string roomBill = label4.Text;
                string doctorBill = label9.Text;
                string medicineBill = label10.Text;
                string totalBill = label36.Text;
                string paidBill = label37.Text;
                string remainingBill = totalBill;
                int patientID = PatientID;


                string query = "INSERT INTO bills (RoomBill, DoctorBill, MedicineBill, TotalBill, PaidBill, RemainingBill, PatientID) VALUES (@RoomBill, @DoctorBill, @MedicineBill, @TotalBill, @PaidBill, @RemainingBill, @PatientID)";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                command.Parameters.AddWithValue("@RoomBill", roomBill);
                command.Parameters.AddWithValue("@DoctorBill", doctorBill);
                command.Parameters.AddWithValue("@MedicineBill", medicineBill);
                command.Parameters.AddWithValue("@TotalBill", totalBill);
                command.Parameters.AddWithValue("@PaidBill", paidBill);
                command.Parameters.AddWithValue("@RemainingBill", remainingBill);
                command.Parameters.AddWithValue("@PatientID", patientID);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Bill has been added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add bill.");
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
