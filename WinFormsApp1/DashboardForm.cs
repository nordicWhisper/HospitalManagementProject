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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            Home home = new Home();
            home.TopLevel = false;
            panel2.Controls.Add(home);

            home.Size = panel2.Size;
            home.Location = new Point(0, 0);

            home.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            Home home = new Home();
            home.TopLevel = false;
            panel2.Controls.Add(home);

            home.Size = panel2.Size;
            home.Location = new Point(0, 0);

            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            AddRoom addRoom = new AddRoom();
            addRoom.TopLevel = false;
            panel2.Controls.Add(addRoom);

            addRoom.Size = panel2.Size;
            addRoom.Location = new Point(0, 0);

            addRoom.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            AddDoctor addDoctor = new AddDoctor();
            addDoctor.TopLevel = false;
            panel2.Controls.Add(addDoctor);

            addDoctor.Size = panel2.Size;
            addDoctor.Location = new Point(0, 0);

            addDoctor.Show();
        }


    }
}
