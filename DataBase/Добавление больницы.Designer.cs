namespace DataBase
{
    partial class AddHospital
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
            this.components = new System.ComponentModel.Container();
            this.addHospitalButton = new System.Windows.Forms.Button();
            this.returnBackButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hospitalNameTextBox = new System.Windows.Forms.TextBox();
            this.hospitalNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.hospitalAddressTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addHospitalButton
            // 
            this.addHospitalButton.Location = new System.Drawing.Point(222, 130);
            this.addHospitalButton.Margin = new System.Windows.Forms.Padding(2);
            this.addHospitalButton.Name = "addHospitalButton";
            this.addHospitalButton.Size = new System.Drawing.Size(125, 33);
            this.addHospitalButton.TabIndex = 36;
            this.addHospitalButton.Text = "Добавить больницу";
            this.addHospitalButton.UseVisualStyleBackColor = true;
            this.addHospitalButton.Click += new System.EventHandler(this.addHospitalButton_Click);
            // 
            // returnBackButton
            // 
            this.returnBackButton.Image = global::DataBase.Properties.Resources.NgXbZ;
            this.returnBackButton.Location = new System.Drawing.Point(5, 134);
            this.returnBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.returnBackButton.Name = "returnBackButton";
            this.returnBackButton.Size = new System.Drawing.Size(32, 29);
            this.returnBackButton.TabIndex = 37;
            this.returnBackButton.UseVisualStyleBackColor = true;
            this.returnBackButton.Click += new System.EventHandler(this.returnBackButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.returnBackButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addHospitalButton);
            this.groupBox1.Controls.Add(this.hospitalNameTextBox);
            this.groupBox1.Controls.Add(this.hospitalNumberTextBox);
            this.groupBox1.Controls.Add(this.emailAddressTextBox);
            this.groupBox1.Controls.Add(this.hospitalAddressTextBox);
            this.groupBox1.Location = new System.Drawing.Point(187, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 168);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Электронный адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Адрес больницы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Номер больницы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Название";
            // 
            // hospitalNameTextBox
            // 
            this.hospitalNameTextBox.Location = new System.Drawing.Point(5, 36);
            this.hospitalNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.hospitalNameTextBox.Multiline = true;
            this.hospitalNameTextBox.Name = "hospitalNameTextBox";
            this.hospitalNameTextBox.Size = new System.Drawing.Size(164, 21);
            this.hospitalNameTextBox.TabIndex = 31;
            // 
            // hospitalNumberTextBox
            // 
            this.hospitalNumberTextBox.Location = new System.Drawing.Point(5, 92);
            this.hospitalNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.hospitalNumberTextBox.Multiline = true;
            this.hospitalNumberTextBox.Name = "hospitalNumberTextBox";
            this.hospitalNumberTextBox.Size = new System.Drawing.Size(164, 24);
            this.hospitalNumberTextBox.TabIndex = 34;
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(173, 92);
            this.emailAddressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailAddressTextBox.Multiline = true;
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(174, 24);
            this.emailAddressTextBox.TabIndex = 35;
            // 
            // hospitalAddressTextBox
            // 
            this.hospitalAddressTextBox.Location = new System.Drawing.Point(173, 36);
            this.hospitalAddressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.hospitalAddressTextBox.Multiline = true;
            this.hospitalAddressTextBox.Name = "hospitalAddressTextBox";
            this.hospitalAddressTextBox.Size = new System.Drawing.Size(174, 21);
            this.hospitalAddressTextBox.TabIndex = 33;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AddHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataBase.Properties.Resources.vi;
            this.ClientSize = new System.Drawing.Size(687, 459);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddHospital";
            this.Text = "Добавление_больницы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addHospitalButton;
        private System.Windows.Forms.Button returnBackButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox hospitalNameTextBox;
        private System.Windows.Forms.TextBox hospitalNumberTextBox;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.TextBox hospitalAddressTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}