using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public class DataBaseConnector
    {
        private string connectionString = "Server=localhost;Database=hospital;Uid=root;Pwd=root1;";
        public MySqlConnection connection;

        public DataBaseConnector()
        {
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }
    }
}
