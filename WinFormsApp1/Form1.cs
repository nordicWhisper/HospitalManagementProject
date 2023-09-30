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


            if (db.TryToLogin(textBox1.Text, textBox2.Text))
            {
                // Jeœli logowanie jest udane, prze³¹cz siê na nowe okno
                Form2 dashboardForm = new Form2(); // "MainForm" to nazwa twojego g³ównego okna
                this.Hide(); // Ukryj okno logowania
                dashboardForm.ShowDialog(); // Wyœwietl nowe okno jako dialog
                this.Close(); // Zamknij okno logowania po zamkniêciu g³ównego okna
            }
            else
            {
                MessageBox.Show("U¿ytkownik nie istnieje w bazie danych.");
            }
        }
    }
}