using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace курсач
{
    public partial class login : Form
    {
        private SqlConnection sqlConnection = null;

        public login()
        {
            InitializeComponent();
            password.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBA"].ConnectionString);
            sqlConnection.Open();
            if(sqlConnection.State == ConnectionState.Open)
            {
               // MessageBox.Show("Подключение установлено!"); 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            
            DataTable table = new DataTable();
            
            string loadstring = $"select id, Login, Password from Users where login = '{login1.Text}' and Password = '{password.Text}'";
            
            SqlCommand command = new SqlCommand(loadstring, sqlConnection);
            
            adapter.SelectCommand = command;
           
            adapter.Fill(table);
            
            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!");
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fpass fpass = new fpass();
            fpass.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registration registration = new registration();
            registration.Show();
            Hide();
        }
        private void checkpass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkpass.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }
    }
}
