namespace WindowsFormsApp4
{
    partial class Form1
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
            this.lblAdSad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAdSad = new System.Windows.Forms.TextBox();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtS3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdSad
            // 
            this.lblAdSad.AutoSize = true;
            this.lblAdSad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSad.Location = new System.Drawing.Point(97, 103);
            this.lblAdSad.Name = "lblAdSad";
            this.lblAdSad.Size = new System.Drawing.Size(83, 16);
            this.lblAdSad.TabIndex = 0;
            this.lblAdSad.Text = "Ad Soyad: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(545, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtAdSad
            // 
            this.txtAdSad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSad.Location = new System.Drawing.Point(186, 103);
            this.txtAdSad.Name = "txtAdSad";
            this.txtAdSad.Size = new System.Drawing.Size(125, 20);
            this.txtAdSad.TabIndex = 1;
            this.txtAdSad.Click += new System.EventHandler(this.txtAdSad_Click);
            // 
            // cmbDers
            // 
            this.cmbDers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Items.AddRange(new object[] {
            "Matematik",
            "Edebiyat",
            "Coğrafya",
            "Tarih"});
            this.cmbDers.Location = new System.Drawing.Point(186, 129);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(125, 21);
            this.cmbDers.TabIndex = 1;
            this.cmbDers.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(131, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ders:";
            // 
            // txtS1
            // 
            this.txtS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtS1.Location = new System.Drawing.Point(431, 99);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(40, 20);
            this.txtS1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(323, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "1. Sınav Notu:";
            // 
            // txtS2
            // 
            this.txtS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtS2.Location = new System.Drawing.Point(431, 124);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(40, 20);
            this.txtS2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(323, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "2. Sınav Notu:";
            // 
            // txtS3
            // 
            this.txtS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtS3.Location = new System.Drawing.Point(431, 150);
            this.txtS3.Name = "txtS3";
            this.txtS3.Size = new System.Drawing.Size(40, 20);
            this.txtS3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(323, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "3. Sınav Notu:";
            // 
            // txtOrt
            // 
            this.txtOrt.Enabled = false;
            this.txtOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOrt.Location = new System.Drawing.Point(577, 98);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(59, 20);
            this.txtOrt.TabIndex = 13;
            this.txtOrt.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(497, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ortalama:";
            // 
            // txtDurum
            // 
            this.txtDurum.Enabled = false;
            this.txtDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDurum.Location = new System.Drawing.Point(577, 124);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(59, 20);
            this.txtDurum.TabIndex = 15;
            this.txtDurum.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(516, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Durum:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(81, 232);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(307, 186);
            this.listBox1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(120, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Öğrencilerin Geçtiği Dersler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(451, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Öğrencilerin Kaldığı Dersler";
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 14;
            this.listBox2.Location = new System.Drawing.Point(412, 232);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(307, 186);
            this.listBox2.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(194, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(402, 33);
            this.label9.TabIndex = 20;
            this.label9.Text = "Öğrenci Sınav Durum Hesaplama";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOrt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtS3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDers);
            this.Controls.Add(this.txtAdSad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAdSad);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdSad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAdSad;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtS3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label9;
    }
}

