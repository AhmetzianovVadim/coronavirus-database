
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void findPatientButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            FindPatient registerForm = new FindPatient();
            registerForm.Show();
        }
        private void addPatientButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddPatient registerForm = new AddPatient();
            registerForm.Show();
        }
        private void addDoctorButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddDoctor registerForm = new AddDoctor();
            registerForm.Show();
        }
        private void addHospitalButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddHospital registerForm = new AddHospital();
            registerForm.Show();
        }
        private void changePatientStatusButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            ChangePatientStatus registerForm = new ChangePatientStatus();
            registerForm.Show();
        }
        private void deletePatientButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            DeletePatient registerForm = new DeletePatient();
            registerForm.Show();
        }
        private void changeNamesButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            ChangeNames registerForm = new ChangeNames();
            registerForm.Show();
        }
        private void patientInformationButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            PatientInformation registerForm = new PatientInformation();
            registerForm.Show();
        }
    }
}
