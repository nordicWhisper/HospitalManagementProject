using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
       DataBaseConnector connector = new DataBaseConnector();
        public Form1()
        {
            InitializeComponent();
        }

        public bool UserLogin(string userName, string userPassword)
        {
            try
            {
                connector.connection.Open();
                string query = "SELECT Username, Password FROM users WHERE Username = @userName";
                MySqlCommand command = new MySqlCommand(query, connector.connection);

                command.Parameters.AddWithValue("@userName", userName);

                MySqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    string username = reader["Username"].ToString();
                    string password = reader["Password"].ToString();

                    if (username == userName && password == userPassword)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("B³¹d po³¹czenia z baz¹ danych " + ex);
                return false;
            }
            finally
            {
                connector.connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (UserLogin(textBox1.Text, textBox2.Text))
            {
                DashboardForm dashboardForm = new DashboardForm();
                this.Hide();
                dashboardForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login or password has been incorrect.");
            }
        }
    }
}