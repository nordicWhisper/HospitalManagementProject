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

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            AddPatient addPatient = new AddPatient();
            addPatient.TopLevel = false;
            panel2.Controls.Add(addPatient);

            addPatient.Size = panel2.Size;
            addPatient.Location = new Point(0, 0);

            addPatient.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            Bill bill = new Bill();
            bill.TopLevel = false;
            panel2.Controls.Add(bill);

            bill.Size = panel2.Size;
            bill.Location = new Point(0, 0);

            bill.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            Payment payment = new Payment();
            payment.TopLevel = false;
            panel2.Controls.Add(payment);

            payment.Size = panel2.Size;
            payment.Location = new Point(0, 0);

            payment.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            AdminReports adminReports = new AdminReports();
            adminReports.TopLevel = false;
            panel2.Controls.Add(adminReports);

            adminReports.Size = panel2.Size;
            adminReports.Location = new Point(0, 0);

            adminReports.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to log out?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Form1 form1 = new Form1();
            if (result == DialogResult.Yes)
            {
                panel2.Controls.Clear();
                this.Close();
                this.Hide();
                form1.ShowDialog();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
