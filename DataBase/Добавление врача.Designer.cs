namespace DataBase
{
    partial class AddDoctor
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
            this.experienceTextBox = new System.Windows.Forms.TextBox();
            this.doctorPositionTextBox = new System.Windows.Forms.TextBox();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.addDoctorButton = new System.Windows.Forms.Button();
            this.returnBackButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.placeOfWorkComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // experienceTextBox
            // 
            this.experienceTextBox.Location = new System.Drawing.Point(182, 75);
            this.experienceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.experienceTextBox.Multiline = true;
            this.experienceTextBox.Name = "experienceTextBox";
            this.experienceTextBox.Size = new System.Drawing.Size(166, 22);
            this.experienceTextBox.TabIndex = 28;
            // 
            // doctorPositionTextBox
            // 
            this.doctorPositionTextBox.Location = new System.Drawing.Point(182, 31);
            this.doctorPositionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doctorPositionTextBox.Multiline = true;
            this.doctorPositionTextBox.Name = "doctorPositionTextBox";
            this.doctorPositionTextBox.Size = new System.Drawing.Size(166, 19);
            this.doctorPositionTextBox.TabIndex = 27;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Location = new System.Drawing.Point(5, 31);
            this.fullnameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fullnameTextBox.Multiline = true;
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(162, 19);
            this.fullnameTextBox.TabIndex = 25;
            // 
            // addDoctorButton
            // 
            this.addDoctorButton.Location = new System.Drawing.Point(223, 103);
            this.addDoctorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addDoctorButton.Name = "addDoctorButton";
            this.addDoctorButton.Size = new System.Drawing.Size(125, 24);
            this.addDoctorButton.TabIndex = 30;
            this.addDoctorButton.Text = "Добавить врача";
            this.addDoctorButton.UseVisualStyleBackColor = true;
            this.addDoctorButton.Click += new System.EventHandler(this.addDoctorButton_Click);
            // 
            // returnBackButton
            // 
            this.returnBackButton.Image = global::DataBase.Properties.Resources.NgXbZ;
            this.returnBackButton.Location = new System.Drawing.Point(5, 101);
            this.returnBackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.returnBackButton.Name = "returnBackButton";
            this.returnBackButton.Size = new System.Drawing.Size(32, 29);
            this.returnBackButton.TabIndex = 35;
            this.returnBackButton.UseVisualStyleBackColor = true;
            this.returnBackButton.Click += new System.EventHandler(this.returnBackButtonButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.placeOfWorkComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addDoctorButton);
            this.groupBox1.Controls.Add(this.returnBackButton);
            this.groupBox1.Controls.Add(this.fullnameTextBox);
            this.groupBox1.Controls.Add(this.experienceTextBox);
            this.groupBox1.Controls.Add(this.doctorPositionTextBox);
            this.groupBox1.Location = new System.Drawing.Point(198, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 136);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Место работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Стаж работы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "ФИО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Должность";
            // 
            // placeOfWorkComboBox
            // 
            this.placeOfWorkComboBox.FormattingEnabled = true;
            this.placeOfWorkComboBox.Location = new System.Drawing.Point(5, 76);
            this.placeOfWorkComboBox.Name = "placeOfWorkComboBox";
            this.placeOfWorkComboBox.Size = new System.Drawing.Size(162, 21);
            this.placeOfWorkComboBox.TabIndex = 37;
            // 
            // AddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataBase.Properties.Resources.vi;
            this.ClientSize = new System.Drawing.Size(687, 459);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddDoctor";
            this.Text = "Добавление_врача";
            this.Load += new System.EventHandler(this.AddDoctor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox experienceTextBox;
        private System.Windows.Forms.TextBox doctorPositionTextBox;
        private System.Windows.Forms.TextBox fullnameTextBox;
        private System.Windows.Forms.Button addDoctorButton;
        private System.Windows.Forms.Button returnBackButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox placeOfWorkComboBox;
    }
}