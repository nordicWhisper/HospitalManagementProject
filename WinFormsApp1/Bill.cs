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
    public partial class Bill : Form
    {
        public int PatientID { get; set; }
        DataBaseConnector connector = new DataBaseConnector();
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            PatientDetail__SELECT__PatientName();
        }

        private void PatientDetail__SELECT__PatientName()
        {
            try
            {
                connector.connection.Open();

                string query = "SELECT PatientName, discharge FROM patients";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Refresh();

                while (reader.Read())
                {
                    if ((bool)reader["discharge"] == true)
                    {
                        comboBox6.Items.Add(reader["PatientName"].ToString());
                    } else
                    {
                        comboBox1.Items.Add(reader["PatientName"].ToString());
                        comboBox6.Items.Add(reader["PatientName"].ToString());
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

        private void ShowPatientReports(string patientName)
        {
            try
            {
                connector.connection.Open();

                bool addButtonColumnExists = false;
                string targetColumnName = "AddButton";
                DataGridViewButtonColumn addButtonColumn = new DataGridViewButtonColumn();

                addButtonColumn.Name = "AddButton";
                addButtonColumn.HeaderText = "ADD";
                addButtonColumn.Text = "ADD";
                addButtonColumn.UseColumnTextForButtonValue = true;

                addButtonColumn.FlatStyle = FlatStyle.Flat;
                addButtonColumn.DefaultCellStyle.BackColor = Color.Green;
                addButtonColumn.DefaultCellStyle.ForeColor = Color.White;
                addButtonColumn.DefaultCellStyle.SelectionForeColor = Color.White;

                string query = "SELECT PatientID, PatientName, Mobile, Address, City, HandleByDoctor, RoomType FROM patients WHERE PatientName=@PatientName";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                command.Parameters.AddWithValue("@PatientName", patientName);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        if (column.Name == targetColumnName)
                        {
                            addButtonColumnExists = true;
                            break;
                        }
                    }

                    if (!addButtonColumnExists)
                    {
                        dataGridView1.Columns.Add(addButtonColumn);
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
                    if (comboBox6.SelectedItem.ToString() == reader["PatientName"].ToString())
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

        private void ShowPatientBills()
        {
            try
            {
                connector.connection.Open();

                string query = "SELECT * FROM bills";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (PatientID.ToString() == reader["PatientID"].ToString())
                    {
                        label12.Text = reader["RoomBill"].ToString();
                        label13.Text = reader["DoctorBill"].ToString();
                        label14.Text = reader["MedicineBill"].ToString();
                        label15.Text = reader["PaidBill"].ToString();
                        label16.Text = reader["TotalBill"].ToString();
                        label27.Text = reader["RemainingBill"].ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                ShowPatientReports(comboBox1.Text);
            }
            else
            {
                MessageBox.Show("You must choose patient name.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (comboBox6.SelectedIndex != -1)
            {
                panel4.Visible = true;
                ShowPatientDetails();
                ShowPatientBills();
            }
            else
            {
                MessageBox.Show("You must choose patient name.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mobilePhonePatient = dataGridView1.Rows[e.RowIndex].Cells["Mobile"].Value.ToString();
            int patientID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value);

            AddBill addBill = new AddBill(mobilePhonePatient, patientID);
            addBill.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
