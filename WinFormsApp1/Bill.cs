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

                string query = "SELECT PatientName FROM patients";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Refresh();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mobilePhonePatient = dataGridView1.Rows[e.RowIndex].Cells["Mobile"].Value.ToString();
            int patientID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value);

            AddBill addBill = new AddBill(mobilePhonePatient, patientID);
            addBill.Show();
        }
    }
}
