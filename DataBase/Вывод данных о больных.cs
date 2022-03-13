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
    public partial class PatientInformation : Form
    {
        public PatientInformation()
        {
            InitializeComponent();
        }

        string connStr = "server =  localhost; port = 8889; username = root; password = root; database = database;";

        private void PatientInformation_Load(object sender, EventArgs e)
        {
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            string sql = "SELECT * FROM sick";
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                connection.Open();
                // Создаем объект DataAdapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].ReadOnly = true; 
            }
        }

        private void returnBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 registerForm = new Form1();
            registerForm.Show();

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();

            var column = new Dictionary<int, string>()
            {
                { 0, "SickID"},
                { 1, "FIO"},
                { 2, "Nationality"},
                { 3, "Registration"},
                { 4, "Age"},
                { 5, "DateDiagnosis"},
                { 6, "DiseaseID"},
                { 7, "severityID"},
                { 8, "MethodID"},
                { 9, "HospitalID" },
                { 10, "DoctorID" },
                { 11, "BirthDay" },
                { 12, "StatusID" }
            };
            
            string changedValue = this.dataGridView1.CurrentCell.Value.ToString();
            string query = "UPDATE sick SET " + column[e.ColumnIndex] + " = " + "'" + changedValue + "'" + " WHERE SickID = " + "'" + (e.RowIndex + 1).ToString() + "'";
            MySqlCommand sqlCommand = new MySqlCommand(query, conn);
            MySqlDataReader mySqlDataReader = sqlCommand.ExecuteReader();
            conn.Close();
        }


    }
}
