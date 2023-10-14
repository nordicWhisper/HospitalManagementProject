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

        public int PatientID { get; set; }

        DataBaseConnector connector = new DataBaseConnector();
        public AddPatient()
        {
            InitializeComponent();
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            HandleByDoctorSELECT();
            RoomTypeSELECT();
            PatientNameSELECT();
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

        private bool AddPatients(string patientName, string gender, string age, string mobile, string address, string city, string pincode, string referByDoctor, string disease, string handleByDoctor, string roomType, string estimatedBill)
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

        private void PatientNameSELECT()
        {
            try
            {
                connector.connection.Open();
                string query = "SELECT PatientName from patients";
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

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView3.Columns["DeleteButton"].Index)
            {

                try
                {
                    connector.connection.Open();

                    int recordIdToDelete = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["PatientID"].Value);
                    string query = "DELETE FROM patients WHERE PatientID=@PatientID;";

                    DialogResult result = MessageBox.Show("Are you sure to do this?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        MySqlCommand command = new MySqlCommand(query, connector.connection);
                        command.Parameters.AddWithValue("@PatientID", recordIdToDelete);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data has been update.");
                            dataGridView3.Refresh();
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
        }

        private void PatientNameSELECT__PatientName(string patientName)
        {
            try
            {
                connector.connection.Open();

                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();

                deleteButtonColumn.Name = "DeleteButton";
                deleteButtonColumn.HeaderText = "Delete";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;

                deleteButtonColumn.FlatStyle = FlatStyle.Flat;
                deleteButtonColumn.DefaultCellStyle.BackColor = Color.Red;
                deleteButtonColumn.DefaultCellStyle.ForeColor = Color.White;
                deleteButtonColumn.DefaultCellStyle.SelectionForeColor = Color.White;

                string query = "SELECT PatientID, PatientName, Mobile, Address, City, HandleByDoctor, RoomType FROM patients WHERE PatientName=@PatientName";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                command.Parameters.AddWithValue("@PatientName", patientName);



                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView3.DataSource = dataTable;
                    dataGridView3.Columns.Add(deleteButtonColumn);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
            finally { connector.connection.Close(); }
        }

        private void PatientNameTextBox__MobileNo(string mobileNo)
        {
            try
            {
                connector.connection.Open();
                string query = "SELECT PatientID, PatientName, Mobile, Address, City, HandleByDoctor, RoomType FROM patients WHERE Mobile=@Mobile";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                command.Parameters.AddWithValue("@Mobile", mobileNo);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView3.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
            finally { connector.connection.Close(); }
        }

        private void Show__Patient__Details(string patientDetails)
        {
            panel1.Visible = true;
            try
            {
                connector.connection.Open();

                string query = "SELECT * FROM patients WHERE PatientName = @PatientName";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                command.Parameters.AddWithValue("@PatientName", patientDetails);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
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
                    PatientID = (int)reader["PatientID"];
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

        private void Show__Patient__Payments()
        {
            try
            {
                connector.connection.Open();
                string query = "SELECT * FROM payments WHERE PatientID = @PatientID";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                command.Parameters.AddWithValue("@PatientID", PatientID);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;
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

        private void Show__Patient__Bills()
        {
            try
            {
                connector.connection.Open();
                string query = "SELECT * FROM bills WHERE PatientID = @PatientID";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                command.Parameters.AddWithValue("@PatientID", PatientID);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    label33.Text = reader["RoomBill"].ToString();
                    label34.Text = reader["DoctorBill"].ToString();
                    label35.Text = reader["MedicineBill"].ToString();
                    label36.Text = reader["TotalBill"].ToString();
                    label37.Text = reader["PaidBill"].ToString();
                    label38.Text = reader["RemainingBill"].ToString();
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
            AddPatients(PatientName, Gender, Age, Mobile, Address, City, Pincode, ReferByDoctor, Disease, HandleByDoctor, RoomType, EstimatedBill);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string patientDetails = comboBox1.Text;
                Show__Patient__Details(patientDetails);
                Show__Patient__Payments();
                Show__Patient__Bills();
            }
            else
            {
                MessageBox.Show("You must choose patient name.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != string.Empty)
            {
                PatientNameTextBox__MobileNo(textBox5.Text);
            }
            else
            {
                MessageBox.Show("You must write patient mobile phone.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex != -1)
            {
                PatientNameSELECT__PatientName(comboBox6.Text);
            }
            else
            {
                MessageBox.Show("You must choose patient name.");
            }
        }
    }
}
