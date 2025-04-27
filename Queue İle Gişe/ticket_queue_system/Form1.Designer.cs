namespace ticket_queue_system
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
            this.btnGise1 = new System.Windows.Forms.Button();
            this.btnGise3 = new System.Windows.Forms.Button();
            this.btnGise2 = new System.Windows.Forms.Button();
            this.lstGise = new System.Windows.Forms.ListBox();
            this.btnSiraAl = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGise1
            // 
            this.btnGise1.Location = new System.Drawing.Point(77, 29);
            this.btnGise1.Name = "btnGise1";
            this.btnGise1.Size = new System.Drawing.Size(112, 98);
            this.btnGise1.TabIndex = 0;
            this.btnGise1.Text = "Gişe 1";
            this.btnGise1.UseVisualStyleBackColor = true;
            this.btnGise1.Click += new System.EventHandler(this.btnGise1_Click);
            // 
            // btnGise3
            // 
            this.btnGise3.Location = new System.Drawing.Point(77, 237);
            this.btnGise3.Name = "btnGise3";
            this.btnGise3.Size = new System.Drawing.Size(112, 98);
            this.btnGise3.TabIndex = 1;
            this.btnGise3.Text = "Gişe 3";
            this.btnGise3.UseVisualStyleBackColor = true;
            this.btnGise3.Click += new System.EventHandler(this.btnGise3_Click);
            // 
            // btnGise2
            // 
            this.btnGise2.Location = new System.Drawing.Point(77, 133);
            this.btnGise2.Name = "btnGise2";
            this.btnGise2.Size = new System.Drawing.Size(112, 98);
            this.btnGise2.TabIndex = 1;
            this.btnGise2.Text = "Gişe 2";
            this.btnGise2.UseVisualStyleBackColor = true;
            this.btnGise2.Click += new System.EventHandler(this.btnGise2_Click);
            // 
            // lstGise
            // 
            this.lstGise.FormattingEnabled = true;
            this.lstGise.Location = new System.Drawing.Point(196, 29);
            this.lstGise.Name = "lstGise";
            this.lstGise.Size = new System.Drawing.Size(120, 199);
            this.lstGise.TabIndex = 2;
            // 
            // btnSiraAl
            // 
            this.btnSiraAl.Location = new System.Drawing.Point(196, 238);
            this.btnSiraAl.Name = "btnSiraAl";
            this.btnSiraAl.Size = new System.Drawing.Size(120, 40);
            this.btnSiraAl.TabIndex = 3;
            this.btnSiraAl.Text = "Sıra Al";
            this.btnSiraAl.UseVisualStyleBackColor = true;
            this.btnSiraAl.Click += new System.EventHandler(this.btnSiraAl_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(195, 294);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(121, 41);
            this.btnSifirla.TabIndex = 4;
            this.btnSifirla.Text = "Sıfrılama";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnSiraAl);
            this.Controls.Add(this.lstGise);
            this.Controls.Add(this.btnGise2);
            this.Controls.Add(this.btnGise3);
            this.Controls.Add(this.btnGise1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGise1;
        private System.Windows.Forms.Button btnGise3;
        private System.Windows.Forms.Button btnGise2;
        private System.Windows.Forms.ListBox lstGise;
        private System.Windows.Forms.Button btnSiraAl;
        private System.Windows.Forms.Button btnSifirla;
    }
}

