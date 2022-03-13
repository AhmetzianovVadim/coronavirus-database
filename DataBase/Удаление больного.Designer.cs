namespace DataBase
{
    partial class DeletePatient
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
            this.deletePatientButton = new System.Windows.Forms.Button();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.returnBackButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deletePatientButton
            // 
            this.deletePatientButton.Location = new System.Drawing.Point(112, 58);
            this.deletePatientButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deletePatientButton.Name = "deletePatientButton";
            this.deletePatientButton.Size = new System.Drawing.Size(123, 28);
            this.deletePatientButton.TabIndex = 0;
            this.deletePatientButton.Text = "Удалить больного";
            this.deletePatientButton.UseVisualStyleBackColor = true;
            this.deletePatientButton.Click += new System.EventHandler(this.deletePatientButton_Click);
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Location = new System.Drawing.Point(5, 31);
            this.fullnameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fullnameTextBox.Multiline = true;
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(230, 22);
            this.fullnameTextBox.TabIndex = 28;
            // 
            // returnBackButton
            // 
            this.returnBackButton.Image = global::DataBase.Properties.Resources.NgXbZ;
            this.returnBackButton.Location = new System.Drawing.Point(5, 57);
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
            this.groupBox1.Controls.Add(this.deletePatientButton);
            this.groupBox1.Controls.Add(this.returnBackButton);
            this.groupBox1.Controls.Add(this.fullnameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(238, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 89);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "ФИО";
            // 
            // DeletePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataBase.Properties.Resources.vi;
            this.ClientSize = new System.Drawing.Size(687, 459);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeletePatient";
            this.Text = "Удаление_больного";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deletePatientButton;
        private System.Windows.Forms.TextBox fullnameTextBox;
        private System.Windows.Forms.Button returnBackButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}