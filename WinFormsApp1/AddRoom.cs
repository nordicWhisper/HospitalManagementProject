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
    public partial class AddRoom : Form
    {
        DataBaseConnector connector = new DataBaseConnector();
        public AddRoom()
        {
            InitializeComponent();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {

            connector.ShowRoomReports(dataGridView1);
            connector.EditRoomDetailSELECT(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string roomtype = textBox1.Text;
            string totalroom = textBox2.Text;
            string rateday = textBox3.Text;

            connector.AddRooms(roomtype, Int32.Parse(totalroom), Int32.Parse(rateday));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy coś jest wybrane w ComboBox
            if (comboBox1.SelectedIndex != -1)
            {
                // Pobierz indeks wybranej pozycji
                int selectedIndex = comboBox1.SelectedIndex;

                // Pobierz wybrany element (tekst)
                string selectedItem = comboBox1.SelectedItem.ToString();
                string totalroom = textBox5.Text;
                string rateday = textBox4.Text;

                connector.EditRoomDetailUPDATE(selectedItem, Int32.Parse(totalroom), Int32.Parse(rateday));


            }
            else
            {
                MessageBox.Show("Nic nie zostało wybrane z listy ComboBox.");
            }
        }
    }
}
