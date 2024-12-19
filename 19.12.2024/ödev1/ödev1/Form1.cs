using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string eposta = txtEPosta.Text;
            // TextBox'tan girilen e-posta adresini alır ve 'eposta' değişkenine atar.

            if (string.IsNullOrEmpty(eposta)) // E-posta alanı boş veya null ise
            {
                MessageBox.Show("Lütfen E-Posta Alanını Boş Bırakmayınız!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Kullanıcıya uyarı mesajı gösterir.
            }
            else
            {
                if (eposta.Contains('@') && eposta.Contains('.')) // E-posta '@' ve '.' karakterlerini içeriyorsa
                {
                    int indexno = eposta.IndexOf('@');
                    // E-posta adresinde '@' karakterinin pozisyonunu belirler ve 'indexno' değişkenine atar.

                    if (eposta.Substring(0, indexno).Length >= 6)
                    {
                        // '@' karakterinden önceki kısmın uzunluğunun en az 6 karakter olup olmadığını kontrol eder.

                        if (eposta.IndexOf('.', indexno) > indexno)
                        {
                            lstEPosta.Items.Add(eposta.Substring(0, indexno));
                            // '@' karakterinden önceki kısmı ListBox'a ekler.
                        }
                        else
                        {
                            MessageBox.Show("@ İşaretinden Sonra '.' Olmalıdır!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // '@' karakterinden sonra '.' karakteri yoksa, kullanıcıya uyarı mesajı gösterir.
                        }
                    }
                    else
                    {
                        MessageBox.Show("E-Posta Adresiniz En Az 6 Karakterden Oluşmalıdır!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // '@' karakterinden önceki kısım en az 6 karakter değilse, kullanıcıya uyarı mesajı gösterir.
                    }
                }
                else
                {
                    MessageBox.Show("E-Posta Adresinizi Kontrol Ediniz!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // E-posta adresinde '@' ve '.' karakterleri yoksa, kullanıcıya uyarı mesajı gösterir.
                }
            }


        }
    

    }
}
