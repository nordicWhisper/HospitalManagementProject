using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataBaseConnector db = new DataBaseConnector();

            if (db.UserLogin(textBox1.Text, textBox2.Text))
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