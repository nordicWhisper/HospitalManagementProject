using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            ShowDoctorReports(dataGridView1);
            EditDoctorDetailSELECT__DoctorName(comboBox1);
            comboBox2.DataSource = doctorsSpecialization;
            comboBox3.DataSource = doctorsSpecialization;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string doctorName = textBox1.Text;
            string mobileNo = textBox2.Text;
            string speciality = comboBox2.SelectedItem.ToString();

            AddDoctors(doctorName, mobileNo, speciality);
            ShowDoctorReports(dataGridView1);
            EditDoctorDetailSELECT__DoctorName(comboBox1);
            dataGridView1.Refresh();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string speciality = comboBox3.SelectedItem.ToString();
                string doctorName = comboBox1.SelectedItem.ToString();
                string mobileNo = textBox5.Text;

                EditDoctorDetailUPDATE(speciality, doctorName, mobileNo);
                ShowDoctorReports(dataGridView1);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Please set Doctor or fill the correct data.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure to do this?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string doctorName = comboBox1.SelectedItem.ToString();
                    EditDoctorDetailDELETE(doctorName);
                    ShowDoctorReports(dataGridView1);
                    dataGridView1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Nic nie zostało wybrane z listy ComboBox.");
            }
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

        private void ShowDoctorReports(DataGridView dataGridView)
        {
            try
            {
                connector.connection.Open();

                string query = "SELECT * FROM doctors";
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

        private void EditDoctorDetailSELECT__DoctorName(System.Windows.Forms.ComboBox comboBox)
        {
            try
            {
                connector.connection.Open();

                string query = "SELECT DoctorName FROM doctors";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Refresh();

                while (reader.Read())
                {
                    comboBox.Items.Add(reader["DoctorName"].ToString());
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

        private void EditDoctorDetailUPDATE(string speciality, string doctorName, string mobileNo)
        {
            try
            {

                if (doctorName != string.Empty && mobileNo != string.Empty)
                {

                    string query = "UPDATE doctors SET DoctorName = @DoctorName, MobileNo = @MobileNo WHERE Speciality = @Speciality";

                    connector.connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connector.connection);

                    command.Parameters.AddWithValue("@Speciality", speciality);
                    command.Parameters.AddWithValue("@DoctorName", doctorName);
                    command.Parameters.AddWithValue("@MobileNo", mobileNo);

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
                else if (doctorName != string.Empty)
                {
                    connector.connection.Open();
                    string query = "UPDATE doctors SET Speciality = @Speciality WHERE DoctorName = @DoctorName";

                    MySqlCommand command = new MySqlCommand(query, connector.connection);

                    command.Parameters.AddWithValue("@Speciality", speciality);
                    command.Parameters.AddWithValue("@DoctorName", doctorName);
                    command.Parameters.AddWithValue("@MobileNo", mobileNo);

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
                else if (mobileNo != string.Empty)
                {
                    connector.connection.Open();
                    string query = "UPDATE doctors SET MobileNo = @MobileNo WHERE Speciality = @Speciality";

                    MySqlCommand command = new MySqlCommand(query, connector.connection);

                    command.Parameters.AddWithValue("@Speciality", speciality);
                    command.Parameters.AddWithValue("@DoctorName", doctorName);
                    command.Parameters.AddWithValue("@MobileNo", mobileNo);

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

        private void EditDoctorDetailDELETE(string doctorName)
        {
            try
            {
                connector.connection.Open();

                string query = "DELETE FROM doctors WHERE DoctorName=@DoctorName;";


                MySqlCommand command = new MySqlCommand(query, connector.connection);

                command.Parameters.AddWithValue("@DoctorName", doctorName);

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
