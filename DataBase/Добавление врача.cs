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
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }
        string connStr = "server =  localhost; port = 8889; username = root; password = root; database = database;";
        private void addDoctorButton_Click(object sender, EventArgs e)
        {
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();

            string fullname = fullnameTextBox.Text;
            string doctorPosition = doctorPositionTextBox.Text;
            string experience = experienceTextBox.Text;
            string hospital = (placeOfWorkComboBox.SelectedItem as ComboBoxItem).Value.ToString();

            string query = string.Format("INSERT INTO doctor (FIO, Doljnost, StajRaboti, MestoRaboti) VALUES ('{0}', '{1}', '{2}', '{3}')", 
                fullname, 
                doctorPosition,
                experience,
                hospital
                );
         
            MySqlCommand sqlCommand = new MySqlCommand(query, conn);
            MySqlDataReader mySqlDataReader = sqlCommand.ExecuteReader();
           

            conn.Close();

            this.Hide();

            Form1 registerForm = new Form1();
            registerForm.Show();

            conn.Close();
        }

        private void returnBackButtonButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 registerForm = new Form1();
            registerForm.Show();
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {
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
                placeOfWorkComboBox.DataSource = hospital;
                connection.Close();
            }
        }
    }
}
