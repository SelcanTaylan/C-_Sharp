namespace örnek1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPerformans1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPerformans2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.dgvHesapla = new System.Windows.Forms.DataGridView();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSonuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHesapla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Adı:";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.Location = new System.Drawing.Point(108, 9);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 25);
            this.txtAd.TabIndex = 1;
            // 
            // txtSaat
            // 
            this.txtSaat.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaat.Location = new System.Drawing.Point(108, 40);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(100, 25);
            this.txtSaat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ders Saati:";
            // 
            // txtNot1
            // 
            this.txtNot1.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNot1.Location = new System.Drawing.Point(108, 69);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(100, 25);
            this.txtNot1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Not 1:";
            // 
            // txtNot2
            // 
            this.txtNot2.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNot2.Location = new System.Drawing.Point(108, 100);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(100, 25);
            this.txtNot2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Not 2:";
            // 
            // txtPerformans1
            // 
            this.txtPerformans1.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerformans1.Location = new System.Drawing.Point(108, 132);
            this.txtPerformans1.Name = "txtPerformans1";
            this.txtPerformans1.Size = new System.Drawing.Size(100, 25);
            this.txtPerformans1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Performans 1:";
            // 
            // txtPerformans2
            // 
            this.txtPerformans2.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerformans2.Location = new System.Drawing.Point(108, 163);
            this.txtPerformans2.Name = "txtPerformans2";
            this.txtPerformans2.Size = new System.Drawing.Size(100, 25);
            this.txtPerformans2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(2, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Performans 2:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.Location = new System.Drawing.Point(9, 194);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(96, 41);
            this.btnHesapla.TabIndex = 12;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // dgvHesapla
            // 
            this.dgvHesapla.AllowUserToAddRows = false;
            this.dgvHesapla.AllowUserToDeleteRows = false;
            this.dgvHesapla.BackgroundColor = System.Drawing.Color.White;
            this.dgvHesapla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHesapla.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvHesapla.Location = new System.Drawing.Point(214, 7);
            this.dgvHesapla.Name = "dgvHesapla";
            this.dgvHesapla.ReadOnly = true;
            this.dgvHesapla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHesapla.Size = new System.Drawing.Size(644, 204);
            this.dgvHesapla.TabIndex = 13;
            this.dgvHesapla.SelectionChanged += new System.EventHandler(this.dgvHesapla_SelectionChanged);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurum.ForeColor = System.Drawing.Color.White;
            this.lblDurum.Location = new System.Drawing.Point(226, 225);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(65, 20);
            this.lblDurum.TabIndex = 14;
            this.lblDurum.Text = "Durum:";
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeni.Location = new System.Drawing.Point(108, 194);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(100, 40);
            this.btnYeni.TabIndex = 15;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click_1);
            // 
            // btnSonuc
            // 
            this.btnSonuc.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSonuc.Location = new System.Drawing.Point(12, 240);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(196, 40);
            this.btnSonuc.TabIndex = 16;
            this.btnSonuc.Text = "Sonuç Göster";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(870, 304);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.dgvHesapla);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtPerformans2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPerformans1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNot2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNot1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSaat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHesapla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPerformans1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPerformans2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.DataGridView dgvHesapla;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSonuc;
    }
}

