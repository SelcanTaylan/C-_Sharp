namespace restaurant_ordering_system
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMusteri = new System.Windows.Forms.TabPage();
            this.tpMenu = new System.Windows.Forms.TabPage();
            this.tpSiparis = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.numCorba = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numAyran = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numEtDoner = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numTavukDoner = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numSutlac = new System.Windows.Forms.NumericUpDown();
            this.lblFis = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpMusteri.SuspendLayout();
            this.tpMenu.SuspendLayout();
            this.tpSiparis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCorba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAyran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEtDoner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTavukDoner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSutlac)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMusteri);
            this.tabControl1.Controls.Add(this.tpMenu);
            this.tabControl1.Controls.Add(this.tpSiparis);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 451);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpMusteri
            // 
            this.tpMusteri.Controls.Add(this.txtMusteri);
            this.tpMusteri.Controls.Add(this.label1);
            this.tpMusteri.Location = new System.Drawing.Point(4, 22);
            this.tpMusteri.Name = "tpMusteri";
            this.tpMusteri.Padding = new System.Windows.Forms.Padding(3);
            this.tpMusteri.Size = new System.Drawing.Size(792, 425);
            this.tpMusteri.TabIndex = 0;
            this.tpMusteri.Text = "Müşteri Bilgileri";
            this.tpMusteri.UseVisualStyleBackColor = true;
            // 
            // tpMenu
            // 
            this.tpMenu.Controls.Add(this.label6);
            this.tpMenu.Controls.Add(this.numSutlac);
            this.tpMenu.Controls.Add(this.label5);
            this.tpMenu.Controls.Add(this.numTavukDoner);
            this.tpMenu.Controls.Add(this.label4);
            this.tpMenu.Controls.Add(this.numEtDoner);
            this.tpMenu.Controls.Add(this.label3);
            this.tpMenu.Controls.Add(this.numAyran);
            this.tpMenu.Controls.Add(this.label2);
            this.tpMenu.Controls.Add(this.numCorba);
            this.tpMenu.Location = new System.Drawing.Point(4, 22);
            this.tpMenu.Name = "tpMenu";
            this.tpMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tpMenu.Size = new System.Drawing.Size(792, 425);
            this.tpMenu.TabIndex = 1;
            this.tpMenu.Text = "Menü";
            this.tpMenu.UseVisualStyleBackColor = true;
            // 
            // tpSiparis
            // 
            this.tpSiparis.Controls.Add(this.lblFis);
            this.tpSiparis.Location = new System.Drawing.Point(4, 22);
            this.tpSiparis.Name = "tpSiparis";
            this.tpSiparis.Padding = new System.Windows.Forms.Padding(3);
            this.tpSiparis.Size = new System.Drawing.Size(792, 425);
            this.tpSiparis.TabIndex = 2;
            this.tpSiparis.Text = "Sipariş Fişi";
            this.tpSiparis.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri İsim";
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(239, 123);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(100, 20);
            this.txtMusteri.TabIndex = 1;
            // 
            // numCorba
            // 
            this.numCorba.Location = new System.Drawing.Point(355, 117);
            this.numCorba.Name = "numCorba";
            this.numCorba.Size = new System.Drawing.Size(120, 20);
            this.numCorba.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çorba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tavuk Döner";
            // 
            // numAyran
            // 
            this.numAyran.Location = new System.Drawing.Point(355, 195);
            this.numAyran.Name = "numAyran";
            this.numAyran.Size = new System.Drawing.Size(120, 20);
            this.numAyran.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Et Döner";
            // 
            // numEtDoner
            // 
            this.numEtDoner.Location = new System.Drawing.Point(355, 169);
            this.numEtDoner.Name = "numEtDoner";
            this.numEtDoner.Size = new System.Drawing.Size(120, 20);
            this.numEtDoner.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ayran";
            // 
            // numTavukDoner
            // 
            this.numTavukDoner.Location = new System.Drawing.Point(355, 143);
            this.numTavukDoner.Name = "numTavukDoner";
            this.numTavukDoner.Size = new System.Drawing.Size(120, 20);
            this.numTavukDoner.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sütlaç";
            // 
            // numSutlac
            // 
            this.numSutlac.Location = new System.Drawing.Point(355, 221);
            this.numSutlac.Name = "numSutlac";
            this.numSutlac.Size = new System.Drawing.Size(120, 20);
            this.numSutlac.TabIndex = 8;
            // 
            // lblFis
            // 
            this.lblFis.AutoSize = true;
            this.lblFis.Location = new System.Drawing.Point(105, 36);
            this.lblFis.Name = "lblFis";
            this.lblFis.Size = new System.Drawing.Size(57, 13);
            this.lblFis.TabIndex = 0;
            this.lblFis.Text = "Sipariş Fiş:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpMusteri.ResumeLayout(false);
            this.tpMusteri.PerformLayout();
            this.tpMenu.ResumeLayout(false);
            this.tpMenu.PerformLayout();
            this.tpSiparis.ResumeLayout(false);
            this.tpSiparis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCorba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAyran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEtDoner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTavukDoner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSutlac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMusteri;
        private System.Windows.Forms.TabPage tpMenu;
        private System.Windows.Forms.TabPage tpSiparis;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSutlac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numTavukDoner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numEtDoner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numAyran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCorba;
        private System.Windows.Forms.Label lblFis;
    }
}

