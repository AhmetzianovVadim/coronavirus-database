namespace DataBase
{
    partial class ChangePatientStatus
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
            this.changeStatusButton = new System.Windows.Forms.Button();
            this.returnBackButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newStatusComboBox = new System.Windows.Forms.ComboBox();
            this.fullNameComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeStatusButton
            // 
            this.changeStatusButton.Location = new System.Drawing.Point(240, 64);
            this.changeStatusButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeStatusButton.Name = "changeStatusButton";
            this.changeStatusButton.Size = new System.Drawing.Size(110, 29);
            this.changeStatusButton.TabIndex = 0;
            this.changeStatusButton.Text = "Изменить статус";
            this.changeStatusButton.UseVisualStyleBackColor = true;
            this.changeStatusButton.Click += new System.EventHandler(this.changeStatusButton_Click);
            // 
            // returnBackButton
            // 
            this.returnBackButton.Image = global::DataBase.Properties.Resources.NgXbZ;
            this.returnBackButton.Location = new System.Drawing.Point(5, 64);
            this.returnBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.returnBackButton.Name = "returnBackButton";
            this.returnBackButton.Size = new System.Drawing.Size(32, 29);
            this.returnBackButton.TabIndex = 36;
            this.returnBackButton.UseVisualStyleBackColor = true;
            this.returnBackButton.Click += new System.EventHandler(this.returnBackButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fullNameComboBox);
            this.groupBox1.Controls.Add(this.newStatusComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.changeStatusButton);
            this.groupBox1.Controls.Add(this.returnBackButton);
            this.groupBox1.Location = new System.Drawing.Point(185, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 103);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Новый статус больного";
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
            // newStatusComboBox
            // 
            this.newStatusComboBox.FormattingEnabled = true;
            this.newStatusComboBox.Location = new System.Drawing.Point(183, 38);
            this.newStatusComboBox.Name = "newStatusComboBox";
            this.newStatusComboBox.Size = new System.Drawing.Size(166, 21);
            this.newStatusComboBox.TabIndex = 39;
            // 
            // fullNameComboBox
            // 
            this.fullNameComboBox.FormattingEnabled = true;
            this.fullNameComboBox.Location = new System.Drawing.Point(9, 38);
            this.fullNameComboBox.Name = "fullNameComboBox";
            this.fullNameComboBox.Size = new System.Drawing.Size(168, 21);
            this.fullNameComboBox.TabIndex = 40;
            // 
            // ChangePatientStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataBase.Properties.Resources.vi;
            this.ClientSize = new System.Drawing.Size(687, 459);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangePatientStatus";
            this.Text = "Изменение_статуса_больного";
            this.Load += new System.EventHandler(this.ChangePatientStatus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeStatusButton;
        private System.Windows.Forms.Button returnBackButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fullNameComboBox;
        private System.Windows.Forms.ComboBox newStatusComboBox;
    }
}