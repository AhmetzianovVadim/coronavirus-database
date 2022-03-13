namespace DataBase
{
    partial class FindPatient
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
            this.findPatientButton = new System.Windows.Forms.Button();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.returnBackButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // findPatientButton
            // 
            this.findPatientButton.Location = new System.Drawing.Point(114, 68);
            this.findPatientButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.findPatientButton.Name = "findPatientButton";
            this.findPatientButton.Size = new System.Drawing.Size(106, 29);
            this.findPatientButton.TabIndex = 0;
            this.findPatientButton.Text = "Найти больного";
            this.findPatientButton.UseVisualStyleBackColor = true;
            this.findPatientButton.Click += new System.EventHandler(this.findPatientButton_Click);
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Location = new System.Drawing.Point(5, 31);
            this.fullnameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fullnameTextBox.Multiline = true;
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(215, 23);
            this.fullnameTextBox.TabIndex = 4;
            // 
            // returnBackButton
            // 
            this.returnBackButton.Image = global::DataBase.Properties.Resources.NgXbZ;
            this.returnBackButton.Location = new System.Drawing.Point(5, 68);
            this.returnBackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.returnBackButton.Name = "returnBackButton";
            this.returnBackButton.Size = new System.Drawing.Size(32, 29);
            this.returnBackButton.TabIndex = 36;
            this.returnBackButton.UseVisualStyleBackColor = true;
            this.returnBackButton.Click += new System.EventHandler(this.returnBackButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.findPatientButton);
            this.groupBox1.Controls.Add(this.returnBackButton);
            this.groupBox1.Controls.Add(this.fullnameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(258, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 119);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "ФИО больного";
            // 
            // FindPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataBase.Properties.Resources.vi;
            this.ClientSize = new System.Drawing.Size(687, 459);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FindPatient";
            this.Text = "Поиск_больного";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button findPatientButton;
        private System.Windows.Forms.TextBox fullnameTextBox;
        private System.Windows.Forms.Button returnBackButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}