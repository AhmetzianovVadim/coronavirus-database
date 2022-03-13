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
    public partial class ChangePatientStatus : Form
    {
        public ChangePatientStatus()
        {
            InitializeComponent();
        }
        string connStr = "server =  localhost; port = 8889; username = root; password = root; database = database;";

        private void changeStatusButton_Click(object sender, EventArgs e)
        {
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();

            string newStatus = (newStatusComboBox.SelectedItem as ComboBoxItem).Value.ToString();
            string patient = (fullNameComboBox.SelectedItem as ComboBoxItem).Value.ToString();
           

            string query = "UPDATE sick SET StatusID = " + "'" + newStatus + "'" + " WHERE SickID =  " + "'%" + patient + "%'";
            
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

        private void ChangePatientStatus_Load(object sender, EventArgs e)
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
                fullNameComboBox.DataSource = sick;
                connection.Close();
            }
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                string sql = "SELECT * FROM statussick";
                connection.Open();
                // Создаем объект DataAdapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                List<ComboBoxItem> status = new List<ComboBoxItem>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Text = row["StatusSick"].ToString();
                    item.Value = row["StatusSickID"].ToString();
                    status.Add(item);
                }
                newStatusComboBox.DataSource = status;
                connection.Close();
            }
        }
    }
}
