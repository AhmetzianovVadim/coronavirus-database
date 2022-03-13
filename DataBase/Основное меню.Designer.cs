namespace DataBase
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addPatientButton = new System.Windows.Forms.Button();
            this.addDoctorButton = new System.Windows.Forms.Button();
            this.patientInformationButton = new System.Windows.Forms.Button();
            this.findPatientButton = new System.Windows.Forms.Button();
            this.addHospitalButton = new System.Windows.Forms.Button();
            this.changePatientStatusButton = new System.Windows.Forms.Button();
            this.deletePatientButton = new System.Windows.Forms.Button();
            this.changeNamesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPatientButton
            // 
            this.addPatientButton.Location = new System.Drawing.Point(5, 60);
            this.addPatientButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(122, 35);
            this.addPatientButton.TabIndex = 4;
            this.addPatientButton.Text = "Добавить больного";
            this.addPatientButton.UseVisualStyleBackColor = true;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // addDoctorButton
            // 
            this.addDoctorButton.Location = new System.Drawing.Point(5, 102);
            this.addDoctorButton.Margin = new System.Windows.Forms.Padding(2);
            this.addDoctorButton.Name = "addDoctorButton";
            this.addDoctorButton.Size = new System.Drawing.Size(122, 38);
            this.addDoctorButton.TabIndex = 5;
            this.addDoctorButton.Text = "Добавить врача";
            this.addDoctorButton.UseVisualStyleBackColor = true;
            this.addDoctorButton.Click += new System.EventHandler(this.addDoctorButton_Click);
            // 
            // patientInformationButton
            // 
            this.patientInformationButton.Location = new System.Drawing.Point(141, 102);
            this.patientInformationButton.Margin = new System.Windows.Forms.Padding(2);
            this.patientInformationButton.Name = "patientInformationButton";
            this.patientInformationButton.Size = new System.Drawing.Size(112, 38);
            this.patientInformationButton.TabIndex = 6;
            this.patientInformationButton.Text = "Вывод данных о больных";
            this.patientInformationButton.UseVisualStyleBackColor = true;
            this.patientInformationButton.Click += new System.EventHandler(this.patientInformationButton_Click);
            // 
            // findPatientButton
            // 
            this.findPatientButton.Location = new System.Drawing.Point(5, 18);
            this.findPatientButton.Margin = new System.Windows.Forms.Padding(2);
            this.findPatientButton.Name = "findPatientButton";
            this.findPatientButton.Size = new System.Drawing.Size(122, 38);
            this.findPatientButton.TabIndex = 7;
            this.findPatientButton.Text = "Поиск больного";
            this.findPatientButton.UseVisualStyleBackColor = true;
            this.findPatientButton.Click += new System.EventHandler(this.findPatientButton_Click);
            // 
            // addHospitalButton
            // 
            this.addHospitalButton.Location = new System.Drawing.Point(5, 144);
            this.addHospitalButton.Margin = new System.Windows.Forms.Padding(2);
            this.addHospitalButton.Name = "addHospitalButton";
            this.addHospitalButton.Size = new System.Drawing.Size(122, 40);
            this.addHospitalButton.TabIndex = 8;
            this.addHospitalButton.Text = "Добавить больницу";
            this.addHospitalButton.UseVisualStyleBackColor = true;
            this.addHospitalButton.Click += new System.EventHandler(this.addHospitalButton_Click);
            // 
            // changePatientStatusButton
            // 
            this.changePatientStatusButton.Location = new System.Drawing.Point(141, 21);
            this.changePatientStatusButton.Margin = new System.Windows.Forms.Padding(2);
            this.changePatientStatusButton.Name = "changePatientStatusButton";
            this.changePatientStatusButton.Size = new System.Drawing.Size(111, 35);
            this.changePatientStatusButton.TabIndex = 9;
            this.changePatientStatusButton.Text = "Изменить статус больного";
            this.changePatientStatusButton.UseVisualStyleBackColor = true;
            this.changePatientStatusButton.Click += new System.EventHandler(this.changePatientStatusButton_Click);
            // 
            // deletePatientButton
            // 
            this.deletePatientButton.Location = new System.Drawing.Point(141, 60);
            this.deletePatientButton.Margin = new System.Windows.Forms.Padding(2);
            this.deletePatientButton.Name = "deletePatientButton";
            this.deletePatientButton.Size = new System.Drawing.Size(112, 38);
            this.deletePatientButton.TabIndex = 10;
            this.deletePatientButton.Text = "Удалить больного";
            this.deletePatientButton.UseVisualStyleBackColor = true;
            this.deletePatientButton.Click += new System.EventHandler(this.deletePatientButton_Click);
            // 
            // changeNamesButton
            // 
            this.changeNamesButton.Location = new System.Drawing.Point(141, 144);
            this.changeNamesButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeNamesButton.Name = "changeNamesButton";
            this.changeNamesButton.Size = new System.Drawing.Size(111, 47);
            this.changeNamesButton.TabIndex = 11;
            this.changeNamesButton.Text = "Изменить имя больного, врача или больницы";
            this.changeNamesButton.UseVisualStyleBackColor = true;
            this.changeNamesButton.Click += new System.EventHandler(this.changeNamesButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.findPatientButton);
            this.groupBox1.Controls.Add(this.patientInformationButton);
            this.groupBox1.Controls.Add(this.changeNamesButton);
            this.groupBox1.Controls.Add(this.addPatientButton);
            this.groupBox1.Controls.Add(this.deletePatientButton);
            this.groupBox1.Controls.Add(this.addDoctorButton);
            this.groupBox1.Controls.Add(this.changePatientStatusButton);
            this.groupBox1.Controls.Add(this.addHospitalButton);
            this.groupBox1.Location = new System.Drawing.Point(240, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 205);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(687, 459);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Основное меню";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button addDoctorButton;
        private System.Windows.Forms.Button patientInformationButton;
        private System.Windows.Forms.Button findPatientButton;
        private System.Windows.Forms.Button addHospitalButton;
        private System.Windows.Forms.Button changePatientStatusButton;
        private System.Windows.Forms.Button deletePatientButton;
        private System.Windows.Forms.Button changeNamesButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

