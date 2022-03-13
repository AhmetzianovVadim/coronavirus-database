using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class DeletePatient : Form
    {
        public DeletePatient()
        {
            InitializeComponent();
        }

        private void deletePatientButton_Click(object sender, EventArgs e)
        {
            // строка подключения к БД
            string connStr = "server =  localhost; port = 8889; username = root; password = root; database = database;";
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();

            string loginUser = fullnameTextBox.Text;
            int q;
            string query = "DELETE FROM sick WHERE FIO LIKE " + "'%" + loginUser + "%'";

            MySqlCommand sqlCommand = new MySqlCommand(query, conn);
            MySqlDataReader mySqlDeleteReader = sqlCommand.ExecuteReader();


            this.Hide();

            Form1 registerForm = new Form1();
            registerForm.Show();

            conn.Close();
        }

        private void returnBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 registerForm = new Form1();
            registerForm.Show();
        }
    }
}
