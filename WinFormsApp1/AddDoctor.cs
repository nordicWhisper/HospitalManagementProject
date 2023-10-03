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
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        DataBaseConnector connector = new DataBaseConnector();

        //private enum DoctorSpecializations
        //{
        //    [Description("General Medicine")]
        //    GeneralMedicine,
        //    [Description("Master Of Surgery")]
        //    MasterOfSurgery,
        //    [Description("General Surgery")]
        //    GeneralSurgery,
        //    [Description("Orthopaedics")]
        //    Orthopaedics,
        //    [Description("Gynaecology")]
        //    Gynaecology,
        //    [Description("Cardiology")]
        //    Cardiology,
        //    [Description("Neurology")]
        //    Neurology,
        //    [Description("Pediatrics")]
        //    Pediatrics
        //}

        private List<string> doctorsSpecialization = new List<string>
        {
            "General Medicine",
            "Master Of Surgery",
            "General Surgery",
            "Orthopaedics",
            "Gynaecology",
            "Cardiology",
            "Neurology",
            "Pediatrics"
        };

        private void AddDoctor_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = doctorsSpecialization;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string doctorName = textBox1.Text;
            string mobileNo = textBox2.Text;
            string speciality = comboBox2.SelectedItem.ToString();

            AddDoctors(doctorName, mobileNo, speciality);
        }

        private bool AddDoctors(string doctorName, string mobileNo, string speciality)
        {
            try
            {
                connector.connection.Open();
                string query = "INSERT INTO doctors (DoctorName, MobileNo, Speciality) VALUES (@DoctorName, @MobileNo, @Speciality)";
                MySqlCommand command = new MySqlCommand(query, connector.connection);

                command.Parameters.AddWithValue("@DoctorName", doctorName);
                command.Parameters.AddWithValue("@MobileNo", mobileNo);
                command.Parameters.AddWithValue("@Speciality", speciality);

                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Doctor detail has added successfully.");
                textBox1.Clear();
                textBox2.Clear();
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
    }
}
