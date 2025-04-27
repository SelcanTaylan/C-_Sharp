using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace email_validation_tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            try
            {
                string mail = txtMail.Text;
                if (string.IsNullOrWhiteSpace(mail))
                {
                    MessageBox.Show("Lütfen posta giriniz.");
                    return;
                }
                if (!mail.Contains('.'))
                {
                    MessageBox.Show("Lütfen geçerli mail adresi giriniz.");
                    return;
                }
                string[] nick= mail.Split('@');
                if (nick[0].Length <6)
                {
                    MessageBox.Show("Kullanıcı adı 6 karakterden az olamaz.");
                    return;
                }
                listBox1.Items.Add(nick[0]);
            }
            catch (Exception)
            {

              
            }
        }

        private void btnKullaniciAdi_Click(object sender, EventArgs e)
        {
            try
            {
                string isim = txtKullaniciAdi.Text;
                if (string.IsNullOrWhiteSpace(isim))
                {
                    MessageBox.Show("İsim Giriniz.");
                }
                string buyukHarf = char.ToUpper(isim[0]) + isim.Substring(1);
                lblİsim.Text = "İsim: "+buyukHarf;
            }
            catch (Exception hata)
            {

                MessageBox.Show("İsim giriniz.")
                    ;
            }
        }
    }
}
