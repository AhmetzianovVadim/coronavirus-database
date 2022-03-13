namespace DataBase
{
    partial class ChangeNames
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.changePatientNameButton = new System.Windows.Forms.Button();
            this.ChangeDoctorNameButton = new System.Windows.Forms.Button();
            this.changeHospitalNameButton = new System.Windows.Forms.Button();
            this.newPatientFullNameTextBox = new System.Windows.Forms.TextBox();
            this.newDoctorFullNameTextBox = new System.Windows.Forms.TextBox();
            this.returnBackButton = new System.Windows.Forms.Button();
            this.newHospitalNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hospitalComboBox = new System.Windows.Forms.ComboBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.patientСomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // changePatientNameButton
            // 
            this.changePatientNameButton.Location = new System.Drawing.Point(41, 120);
            this.changePatientNameButton.Margin = new System.Windows.Forms.Padding(2);
            this.changePatientNameButton.Name = "changePatientNameButton";
            this.changePatientNameButton.Size = new System.Drawing.Size(157, 29);
            this.changePatientNameButton.TabIndex = 0;
            this.changePatientNameButton.Text = "Изменить имя больного";
            this.changePatientNameButton.UseVisualStyleBackColor = true;
            this.changePatientNameButton.Click += new System.EventHandler(this.changePatientNameButton_Click);
            // 
            // ChangeDoctorNameButton
            // 
            this.ChangeDoctorNameButton.Location = new System.Drawing.Point(202, 120);
            this.ChangeDoctorNameButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeDoctorNameButton.Name = "ChangeDoctorNameButton";
            this.ChangeDoctorNameButton.Size = new System.Drawing.Size(170, 29);
            this.ChangeDoctorNameButton.TabIndex = 1;
            this.ChangeDoctorNameButton.Text = "Изменить имя врача";
            this.ChangeDoctorNameButton.UseVisualStyleBackColor = true;
            this.ChangeDoctorNameButton.Click += new System.EventHandler(this.ChangeDoctorNameButton_Click);
            // 
            // changeHospitalNameButton
            // 
            this.changeHospitalNameButton.Location = new System.Drawing.Point(376, 120);
            this.changeHospitalNameButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeHospitalNameButton.Name = "changeHospitalNameButton";
            this.changeHospitalNameButton.Size = new System.Drawing.Size(194, 29);
            this.changeHospitalNameButton.TabIndex = 2;
            this.changeHospitalNameButton.Text = "Изменить название больницы";
            this.changeHospitalNameButton.UseVisualStyleBackColor = true;
            this.changeHospitalNameButton.Click += new System.EventHandler(this.changeHospitalNameButton_Click);
            // 
            // newPatientFullNameTextBox
            // 
            this.newPatientFullNameTextBox.Location = new System.Drawing.Point(41, 83);
            this.newPatientFullNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newPatientFullNameTextBox.Multiline = true;
            this.newPatientFullNameTextBox.Name = "newPatientFullNameTextBox";
            this.newPatientFullNameTextBox.Size = new System.Drawing.Size(157, 23);
            this.newPatientFullNameTextBox.TabIndex = 29;
            // 
            // newDoctorFullNameTextBox
            // 
            this.newDoctorFullNameTextBox.Location = new System.Drawing.Point(202, 83);
            this.newDoctorFullNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newDoctorFullNameTextBox.Multiline = true;
            this.newDoctorFullNameTextBox.Name = "newDoctorFullNameTextBox";
            this.newDoctorFullNameTextBox.Size = new System.Drawing.Size(170, 23);
            this.newDoctorFullNameTextBox.TabIndex = 32;
            // 
            // returnBackButton
            // 
            this.returnBackButton.Image = global::DataBase.Properties.Resources.NgXbZ;
            this.returnBackButton.Location = new System.Drawing.Point(5, 120);
            this.returnBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.returnBackButton.Name = "returnBackButton";
            this.returnBackButton.Size = new System.Drawing.Size(32, 29);
            this.returnBackButton.TabIndex = 36;
            this.returnBackButton.UseVisualStyleBackColor = true;
            this.returnBackButton.Click += new System.EventHandler(this.returnBackButton_Click);
            // 
            // newHospitalNameTextBox
            // 
            this.newHospitalNameTextBox.Location = new System.Drawing.Point(376, 83);
            this.newHospitalNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newHospitalNameTextBox.Multiline = true;
            this.newHospitalNameTextBox.Name = "newHospitalNameTextBox";
            this.newHospitalNameTextBox.Size = new System.Drawing.Size(194, 23);
            this.newHospitalNameTextBox.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hospitalComboBox);
            this.groupBox1.Controls.Add(this.doctorComboBox);
            this.groupBox1.Controls.Add(this.patientСomboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.changePatientNameButton);
            this.groupBox1.Controls.Add(this.returnBackButton);
            this.groupBox1.Controls.Add(this.newHospitalNameTextBox);
            this.groupBox1.Controls.Add(this.ChangeDoctorNameButton);
            this.groupBox1.Controls.Add(this.newDoctorFullNameTextBox);
            this.groupBox1.Controls.Add(this.changeHospitalNameButton);
            this.groupBox1.Controls.Add(this.newPatientFullNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(49, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 173);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // hospitalComboBox
            // 
            this.hospitalComboBox.FormattingEnabled = true;
            this.hospitalComboBox.Location = new System.Drawing.Point(376, 33);
            this.hospitalComboBox.Name = "hospitalComboBox";
            this.hospitalComboBox.Size = new System.Drawing.Size(194, 21);
            this.hospitalComboBox.TabIndex = 47;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(202, 33);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(170, 21);
            this.doctorComboBox.TabIndex = 46;
            // 
            // patientСomboBox
            // 
            this.patientСomboBox.FormattingEnabled = true;
            this.patientСomboBox.Location = new System.Drawing.Point(41, 33);
            this.patientСomboBox.Name = "patientСomboBox";
            this.patientСomboBox.Size = new System.Drawing.Size(157, 21);
            this.patientСomboBox.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Новое ФИО больного";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Новое название больницы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Новое ФИО врача";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Название больницы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "ФИО врача";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "ФИО больного";
            // 
            // ChangeNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataBase.Properties.Resources.vi;
            this.ClientSize = new System.Drawing.Size(687, 459);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangeNames";
            this.Text = "Изменение_названия";
            this.Load += new System.EventHandler(this.ChangeNames_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changePatientNameButton;
        private System.Windows.Forms.Button ChangeDoctorNameButton;
        private System.Windows.Forms.Button changeHospitalNameButton;
        private System.Windows.Forms.TextBox newPatientFullNameTextBox;
        private System.Windows.Forms.TextBox newDoctorFullNameTextBox;
        private System.Windows.Forms.Button returnBackButton;
        private System.Windows.Forms.TextBox newHospitalNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hospitalComboBox;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.ComboBox patientСomboBox;
    }
}