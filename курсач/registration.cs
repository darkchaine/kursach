using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсач
{
    public partial class registration : Form
    {
        private SqlConnection sqlConnection = null;
        public registration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBA"].ConnectionString);
            sqlConnection.Open();
                if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Подключение установлено!");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Users] (Email, Login, Password) VALUES (N'{EmailBox.Text}', N'{LoginBox.Text}', N'{PasswordBox.Text}')",sqlConnection);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }
    }
}
