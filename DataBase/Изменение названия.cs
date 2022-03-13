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
    public partial class ChangeNames : Form
    {
        public ChangeNames()
        {
            InitializeComponent();
        }
        string connStr = "server =  localhost; port = 8889; username = root; password = root; database = database;";
        private void changePatientNameButton_Click(object sender, EventArgs e)
        {
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();

            string after = newPatientFullNameTextBox.Text;
            string patient = (patientСomboBox.SelectedItem as ComboBoxItem).Value.ToString();
            //string loginUser = loginField.Text;
            // запрос
            //string sql = "SELECT AuthorId, BookName FROM book WHERE BookName =" + "'" + loginUser + "'";//

            string query = "UPDATE sick SET FIO = " + "'" + after + "'" + " WHERE SickID = " + "'" + patient + "'";
            //"UPDATE book SET Quantity = " + q.ToString() + " WHERE BookName = " + "'" + loginUser + "'"
            MySqlCommand sqlCommand = new MySqlCommand(query, conn);
            MySqlDataReader mySqlDataReader = sqlCommand.ExecuteReader();


            conn.Close();

            this.Hide();

            Form1 registerForm = new Form1();
            registerForm.Show();

            conn.Close();
        }

        private void ChangeDoctorNameButton_Click(object sender, EventArgs e)
        {
            // строка подключения к БД
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();

            string after = newDoctorFullNameTextBox.Text;
            string doctor = (doctorComboBox.SelectedItem as ComboBoxItem).Value.ToString();

            //string loginUser = loginField.Text;
            // запрос
            //string sql = "SELECT AuthorId, BookName FROM book WHERE BookName =" + "'" + loginUser + "'";//

            string query = "UPDATE doctor SET FIO = " + "'" + after + "'" + " WHERE DoctorID = " + "'" + doctor + "'";

            //"UPDATE book SET Quantity = " + q.ToString() + " WHERE BookName = " + "'" + loginUser + "'"
            MySqlCommand sqlCommand = new MySqlCommand(query, conn);
            MySqlDataReader mySqlDataReader = sqlCommand.ExecuteReader();


            conn.Close();

            this.Hide();

            Form1 registerForm = new Form1();
            registerForm.Show();

            conn.Close();
        }

        private void changeHospitalNameButton_Click(object sender, EventArgs e)
        {
            // строка подключения к БД 
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();

            string after = newHospitalNameTextBox.Text;
            string before = (hospitalComboBox.SelectedItem as ComboBoxItem).Value.ToString();
            //string loginUser = loginField.Text;
            // запрос
            //string sql = "SELECT AuthorId, BookName FROM book WHERE BookName =" + "'" + loginUser + "'";//

            string query = "UPDATE hospital SET Hospital = " + "'" + after + "'" + " WHERE HospitalID = " + "'" + before + "'";
            //"UPDATE book SET Quantity = " + q.ToString() + " WHERE BookName = " + "'" + loginUser + "'"
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

        private void ChangeNames_Load(object sender, EventArgs e)
        {

            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                string sql = "SELECT * FROM sick";
                connection.Open();
                // Создаем объект DataAdapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                List<ComboBoxItem> sick = new List<ComboBoxItem>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Text = row["FIO"].ToString();
                    item.Value = row["SickID"].ToString();
                    sick.Add(item);
                }
                patientСomboBox.DataSource = sick;
                connection.Close();
            }

            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                string sqlQuery = string.Format("SELECT * FROM doctor ");

                connection.Open();
                // Создаем объект DataAdapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                List<ComboBoxItem> doctors = new List<ComboBoxItem>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Text = row["FIO"].ToString();
                    item.Value = row["DoctorID"].ToString();
                    doctors.Add(item);
                }
                doctorComboBox.DataSource = doctors;
                connection.Close();
            }

            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                string sql = "SELECT * FROM hospital";
                connection.Open();
                // Создаем объект DataAdapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                List<ComboBoxItem> hospital = new List<ComboBoxItem>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Text = row["Hospital"].ToString();
                    item.Value = row["HospitalID"].ToString();
                    hospital.Add(item);
                }
                hospitalComboBox.DataSource = hospital;
                connection.Close();
            }
        }
    }
}
