﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{
    public partial class Payment : Form
    {
        DataBaseConnector connector = new DataBaseConnector();
        private List<string> paymentMethod = new List<string> { "CHECK", "CASH" };
        public int PatientID { get; set; }
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            PatientBill__SELECT__By__PatientName();
            comboBox3.DataSource = paymentMethod;
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

        private void ShowPatientBills()
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
                    if (reader["PatientID"].ToString() == PatientID.ToString())
                    {
                        label31.Text = reader["RoomBill"].ToString();
                        label30.Text = reader["DoctorBill"].ToString();
                        label29.Text = reader["MedicineBill"].ToString();

                        label2.Text = reader["TotalBill"].ToString();
                        label28.Text = reader["PaidBill"].ToString();
                        label3.Text = reader["RemainingBill"].ToString();
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

        private void InsertINTO__Payments(string amount, string paymentType, string bankName, string checkNo)
        {
            try
            {
                connector.connection.Open();
                string query = "INSERT INTO payments (BillAmount, PaymentBy, BankName, CheckNo, PatientID) VALUES (@BillAmount, @PaymentBy, @BankName, @CheckNo, @PatientID);";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                command.Parameters.AddWithValue("@BillAmount", amount);
                command.Parameters.AddWithValue("@PaymentBy", paymentType);
                command.Parameters.AddWithValue("@BankName", bankName);
                command.Parameters.AddWithValue("@CheckNo", checkNo);
                command.Parameters.AddWithValue("@PatientID", PatientID);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Payment done by " + paymentType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has been occured " + ex);
            }
            finally
            {
                connector.connection.Close();
            }
        }

        private void InsertINTO__Bills__PaidBill(string amount)
        {
            try
            {
                connector.connection.Open();
                string query = "UPDATE bills SET PaidBill = PaidBill + @PaidBill, RemainingBill = RemainingBill - @PaidBill WHERE PatientID = @PatientID;";
                MySqlCommand command = new MySqlCommand(query, connector.connection);
                command.Parameters.AddWithValue("@PaidBill", amount);
                command.Parameters.AddWithValue("@PatientID", PatientID);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Paid bill have been updated " + amount);
                } else
                {
                    MessageBox.Show("Error has been occured.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has been occured " + ex);
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
                ShowPatientBills();
            }
            else
            {
                MessageBox.Show("You must choose patient name.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to make this operation?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string amount = textBox2.Text;
            string paymentType = comboBox3.Text;
            string bankName = textBox3.Text ?? "-";
            string checkNo = textBox4.Text ?? "-";

            if (result == DialogResult.Yes)
            {
                if (amount != string.Empty && paymentType != string.Empty)
                {
                    InsertINTO__Payments(amount, paymentType, bankName, checkNo);
                    InsertINTO__Bills__PaidBill(amount);
                    panel8.Visible = false;
                }
                else
                {
                    MessageBox.Show("You must fill require field");
                }
            }
        }
    }
}
