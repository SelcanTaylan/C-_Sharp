namespace exam_day_tracker
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
            this.lblEdebiyat = new System.Windows.Forms.Label();
            this.dtpEdb = new System.Windows.Forms.DateTimePicker();
            this.dtpMat = new System.Windows.Forms.DateTimePicker();
            this.lblMatematik = new System.Windows.Forms.Label();
            this.dtpNTP = new System.Windows.Forms.DateTimePicker();
            this.lblNTP = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEdebiyat
            // 
            this.lblEdebiyat.AutoSize = true;
            this.lblEdebiyat.Location = new System.Drawing.Point(100, 63);
            this.lblEdebiyat.Name = "lblEdebiyat";
            this.lblEdebiyat.Size = new System.Drawing.Size(80, 13);
            this.lblEdebiyat.TabIndex = 0;
            this.lblEdebiyat.Text = "Edebiyat Sınavı";
            // 
            // dtpEdb
            // 
            this.dtpEdb.Location = new System.Drawing.Point(278, 63);
            this.dtpEdb.Name = "dtpEdb";
            this.dtpEdb.Size = new System.Drawing.Size(200, 20);
            this.dtpEdb.TabIndex = 1;
            // 
            // dtpMat
            // 
            this.dtpMat.Location = new System.Drawing.Point(278, 89);
            this.dtpMat.Name = "dtpMat";
            this.dtpMat.Size = new System.Drawing.Size(200, 20);
            this.dtpMat.TabIndex = 3;
            // 
            // lblMatematik
            // 
            this.lblMatematik.AutoSize = true;
            this.lblMatematik.Location = new System.Drawing.Point(100, 89);
            this.lblMatematik.Name = "lblMatematik";
            this.lblMatematik.Size = new System.Drawing.Size(88, 13);
            this.lblMatematik.TabIndex = 2;
            this.lblMatematik.Text = "Matematik Sınavı";
            // 
            // dtpNTP
            // 
            this.dtpNTP.Location = new System.Drawing.Point(278, 115);
            this.dtpNTP.Name = "dtpNTP";
            this.dtpNTP.Size = new System.Drawing.Size(200, 20);
            this.dtpNTP.TabIndex = 5;
            // 
            // lblNTP
            // 
            this.lblNTP.AutoSize = true;
            this.lblNTP.Location = new System.Drawing.Point(100, 115);
            this.lblNTP.Name = "lblNTP";
            this.lblNTP.Size = new System.Drawing.Size(172, 13);
            this.lblNTP.TabIndex = 4;
            this.lblNTP.Text = "Nesne Tabanlı Programlama Sınavı";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(278, 155);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(200, 23);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.dtpNTP);
            this.Controls.Add(this.lblNTP);
            this.Controls.Add(this.dtpMat);
            this.Controls.Add(this.lblMatematik);
            this.Controls.Add(this.dtpEdb);
            this.Controls.Add(this.lblEdebiyat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdebiyat;
        private System.Windows.Forms.DateTimePicker dtpEdb;
        private System.Windows.Forms.DateTimePicker dtpMat;
        private System.Windows.Forms.Label lblMatematik;
        private System.Windows.Forms.DateTimePicker dtpNTP;
        private System.Windows.Forms.Label lblNTP;
        private System.Windows.Forms.Button btnHesapla;
    }
}

