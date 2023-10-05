using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace WinFormsApp1
{
    public partial class AddPatient : Form
    {
        public string PatientName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string ReferByDoctor { get; set; }
        public string Disease { get; set; }
        public string HandleByDoctor { get; set; }
        public string RoomType { get; set; }
        public string EstimatedBill { get; set; }

        DataBaseConnector connector = new DataBaseConnector();
        public AddPatient()
        {
            InitializeComponent();
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            HandleByDoctorSELECT();
            RoomTypeSELECT();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PatientName = textBox1.Text;
            Gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            Age = textBox2.Text;
            Mobile = textBox3.Text;
            Address = textBox4.Text;
            City = textBox6.Text;
            Pincode = textBox7.Text;
            ReferByDoctor = textBox8.Text;
            Disease = textBox9.Text;
            HandleByDoctor = comboBox2.SelectedItem.ToString();
            RoomType = comboBox4.SelectedItem.ToString();
            EstimatedBill = textBox10.Text;
            AddDoctors(PatientName, Gender, Age, Mobile, Address, City, Pincode, ReferByDoctor, Disease, HandleByDoctor, RoomType, EstimatedBill);
        }

        private void HandleByDoctorSELECT()
        {
            try
            {
                connector.connection.Open();

                string query = "SELECT DoctorName FROM doctors";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["DoctorName"].ToString());
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

        private void RoomTypeSELECT()
        {
            try
            {
                connector.connection.Open();

                string query = "SELECT RoomType FROM rooms";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox4.Items.Add(reader["RoomType"].ToString());
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

        private bool AddDoctors(string patientName, string gender, string age, string mobile, string address, string city, string pincode, string referByDoctor, string disease, string handleByDoctor, string roomType, string estimatedBill)
        {
            try
            {
                connector.connection.Open();
                string query = "INSERT INTO patients (PatientName, Gender, Age, Mobile, Address, City, Pincode, ReferByDoctor, Disease, HandleByDoctor, RoomType, EstimatedBill) VALUES (@PatientName, @Gender, @Age, @Mobile, @Address, @City, @Pincode, @ReferByDoctor, @Disease, @HandleByDoctor, @RoomType, @EstimatedBill)";

                MySqlCommand command = new MySqlCommand(query, connector.connection);

                command.Parameters.AddWithValue("@PatientName", patientName);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Mobile", mobile);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@Pincode", pincode);
                command.Parameters.AddWithValue("@ReferByDoctor", referByDoctor);
                command.Parameters.AddWithValue("@Disease", disease);
                command.Parameters.AddWithValue("@HandleByDoctor", handleByDoctor);
                command.Parameters.AddWithValue("@RoomType", roomType);
                command.Parameters.AddWithValue("@EstimatedBill", estimatedBill);

                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Patient detail has added successfully.");
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

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
