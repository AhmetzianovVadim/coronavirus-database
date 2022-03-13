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
    public partial class FindPatient : Form
    {
        public FindPatient()
        {
            InitializeComponent();
        }

        private void findPatientButton_Click(object sender, EventArgs e)
        {
            // строка подключения к БД
            string connStr = "server =  localhost; port = 8889; username = root; password = root; database = database;";
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            string LastName = fullnameTextBox.Text;

            //string loginUser = loginField.Text;
            // запрос
            //string sql = "SELECT AuthorId, BookName FROM book WHERE BookName =" + "'" + loginUser + "'";//

            //string query = "SELECT book.BookName, author.AuthorName, book.Quantity FROM book JOIN author on book.AuthorId=author.AuthorId WHERE BookName = " + "'" + loginUser + "'";
            string query = "SELECT sick.FIO, severity.severity FROM sick JOIN severity on severity.severityID=sick.severityID WHERE FIO LIKE " + "'%" + LastName + "%'";
           // "SELECT book.BookName, author.AuthorName, book.Quantity FROM book JOIN author on book.AuthorId=author.AuthorId WHERE book.AuthorId LIKE " + authorid;// + "'" + loginUser + "'";

            MySqlCommand sqlCommand = new MySqlCommand(query, conn);
            MySqlDataReader mySqlDataReader = sqlCommand.ExecuteReader();
            if (mySqlDataReader.Read())
            {
                MessageBox.Show(" У больного " + mySqlDataReader[0].ToString() + " " + mySqlDataReader[1].ToString());
            }

            else
            {
                MessageBox.Show("Больной не найден");
            }

            // объект для выполнения SQL-запроса
            //MySqlCommand command = new MySqlCommand(sql, conn);//
            // выполняем запрос и получаем ответ
            //MySqlDataReader reader = command.ExecuteReader();//





            // закрываем соединение с БД
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
