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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }
        string connStr = "server =  localhost; port = 8889; username = root; password = root; database = database;";
        private void addPatientButton_Click(object sender, EventArgs e)
        {

            // строка подключения к БД
         
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();

            string patientName = fullnameTextBox.Text;
            string country = countryTextBox.Text;
            string registration = registrationCityTextBox.Text;
            string age = ageTextBox.Text;
            string dateOfBirth = dateOfDiagnosisTextBox.Text;
            string disease = (diseaseComboBox.SelectedItem as ComboBoxItem).Value.ToString();
            string dateOfDiagnosis = dateOfDiagnosisTextBox.Text;
            string hospital = (hospitalComboBox.SelectedItem as ComboBoxItem).Value.ToString();
            string doctor = (doctorComboBox.SelectedItem as ComboBoxItem).Value.ToString();
            string severity = (severityComboBox.SelectedItem as ComboBoxItem).Value.ToString();
            string treatment = (treatmentComboBox.SelectedItem as ComboBoxItem).Value.ToString();
            string status = (patientStatusComboBox.SelectedItem as ComboBoxItem).Value.ToString();

            string query = string.Format(
                "INSERT INTO sick ( FIO, 	Nationality, Registration, Age, DateDiagnosis, DiseaseID, severityID, MethodID, HospitalID, DoctorID, BirthDay, StatusID) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')", 
                patientName,
                country,
                registration,
                age,
                dateOfDiagnosis,
                disease,
                severity,
                treatment,
                hospital,
                doctor,
                dateOfBirth,
                status
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

        private void AddPatient_Load(object sender, EventArgs e)
        {
            
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                string sql = "SELECT * FROM disease";
                connection.Open();
                // Создаем объект DataAdapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                List<ComboBoxItem> disease = new List<ComboBoxItem>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Text = row["Disease"].ToString();
                    item.Value = row["DiseaseID"].ToString();
                    disease.Add(item);
                }
                diseaseComboBox.DataSource = disease;
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

            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                string sqlQuery = string.Format("SELECT * FROM doctor WHERE MestoRaboti = {0}", (hospitalComboBox.SelectedItem as ComboBoxItem).Value.ToString());

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
                string sql = "SELECT * FROM severity";
                connection.Open();
                // Создаем объект DataAdapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                List<ComboBoxItem> severity = new List<ComboBoxItem>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Text = row["severity"].ToString();
                    item.Value = row["severityID"].ToString();
                    severity.Add(item);
                }
                severityComboBox.DataSource = severity;
                connection.Close();
            }

            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                string sql = "SELECT * FROM methodtreatment";
                connection.Open();
                // Создаем объект DataAdapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                List<ComboBoxItem> method = new List<ComboBoxItem>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Text = row["Description"].ToString();
                    item.Value = row["MethodID"].ToString();
                    method.Add(item);
                }
                treatmentComboBox.DataSource = method;
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
                patientStatusComboBox.DataSource = status;
                connection.Close();
            }
        }

        private void hospitalComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                ComboBox comboBox = sender as ComboBox;
                string sqlQuery = string.Format("SELECT * FROM doctor WHERE MestoRaboti = {0}", (comboBox.SelectedItem as ComboBoxItem).Value.ToString());

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
        }
    }
}
