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
    public partial class AddHospital : Form
    {
        public AddHospital()
        {
            InitializeComponent();
        }

        private void addHospitalButton_Click(object sender, EventArgs e)
        {
            // строка подключения к БД
            string connStr = "server =  localhost; port = 8889; username = root; password = root; database = database;";
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();

            //string ID = textBox1.Text;
            string hospitalName = hospitalNameTextBox.Text;
            string address = hospitalAddressTextBox.Text;
            string number = hospitalNumberTextBox.Text;
            string email = emailAddressTextBox.Text;


            string query = string.Format(
               "INSERT INTO hospital ( Hospital, 	AdressHospital, NumberHospital, MailHospital) VALUES ('{0}', '{1}', '{2}', '{3}')",
               hospitalName,
               address,
               number,
               email
               );

            MySqlCommand sqlCommand = new MySqlCommand(query, conn);
            MySqlDataReader mySqlDataReader = sqlCommand.ExecuteReader();


            conn.Close();

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
