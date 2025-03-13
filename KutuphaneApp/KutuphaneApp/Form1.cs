using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<KitapOdunc> kitapListe = new List<KitapOdunc>(); //Adım 1

        KitapOdunc secilen;

        private void Form1_Load(object sender, EventArgs e)
        {
            OrnekVeriEkle(); //Adım 3
            dataGridView1.DataSource = kitapListe.ToList();
            


        }

        void Listele()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = kitapListe.ToList();

        }

        private void OrnekVeriEkle() //Adım 2
        {
            kitapListe.Add(new KitapOdunc("Sümeyye Sahi", "Avucumuzdaki Kelebek", DateTime.Now.AddDays(-20),DateTime.Now.AddDays(-5)));
            kitapListe.Add(new KitapOdunc("Tuğba Aslan", "Küçük Ağa", DateTime.Now.AddDays(-7),null));
            kitapListe.Add(new KitapOdunc("Selcan Taylan", "Bir İdam Mahkumu", DateTime.Now.AddDays(-32),DateTime.Now.AddDays(-5)));
            kitapListe.Add(new KitapOdunc("İnci Çolo", "Ayşegül Tatilde", DateTime.Now.AddDays(-10),null));
            kitapListe.Add(new KitapOdunc("Derya Uyan", "Nohut Adam", DateTime.Now.AddDays(-10),DateTime.Now.AddDays(-1)));
            kitapListe.Add(new KitapOdunc("Damla Yiğit", "Ailema", DateTime.Now.AddDays(-20),null));
        }

        private void btnEkle_Click(object sender, EventArgs e) //Adım 4
        {
            string ad = txtOgrenciAdi.Text;
            string kitap = txtKitapAdi.Text;
            DateTime alisTarih = dtpAlisTarihi.Value;

            DateTime? teslimTarihi = null;

            if (dtpTeslimTarihi.Checked == true)
            {
                teslimTarihi = dtpTeslimTarihi.Value;
            }

            DialogResult result = MessageBox.Show("Girilen bilgiler eklensin mi?", "Bilgi Ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                kitapListe.Add(new KitapOdunc(ad, kitap, alisTarih, teslimTarihi));
                Listele();
                txtKitapAdi.Clear();
                txtOgrenciAdi.Clear();
                MessageBox.Show("Kayıt Eklendi","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Kayıt Sİlinsin mi?","Kayıt Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                kitapListe.Remove((KitapOdunc)dataGridView1.CurrentRow.DataBoundItem);
                Listele();
            }
            
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2; //Güncelle tab' ına geçer
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçili tab'ın 2. tab (index 2) olup olmadığını kontrol ediyoruz
            if (tabControl1.SelectedIndex == 2)
            {
                // DataGridView'de seçili satır olup olmadığını kontrol et
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    secilen = (KitapOdunc)dataGridView1.SelectedRows[0].DataBoundItem;
                    txtAdGuncelle.Text = secilen.OgrenciAdi;
                    txtKitapGuncelle.Text = secilen.KitapAdi;
                    dtpAlisGuncelle.Value = secilen.AlisTarihi;

                    // TeslimTarihi null ise kontrol
                    if (secilen.TeslimTarihi == null)
                    {
                        dtpTeslimGuncelle.Checked = false;
                    }
                    else
                    {
                        dtpTeslimGuncelle.Checked = true; // Teslim tarihi var ise kontrol kutusunu işaretle
                        dtpTeslimGuncelle.Value = secilen.TeslimTarihi.Value;
                    }
                }
                else
                {
                    // Eğer seçili satır yoksa, bu durumda formu temizle veya hata mesajı ver
                    MessageBox.Show("Lütfen geçerli bir satır seçin.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //Güncelle butonu
        { 
            secilen.OgrenciAdi = txtAdGuncelle.Text;
            secilen.KitapAdi=txtKitapGuncelle.Text;
            secilen.AlisTarihi = dtpAlisGuncelle.Value;

            if (dtpTeslimGuncelle.Checked == false)
            {
                secilen.TeslimTarihi = null; 
            }
            else
            { 
                secilen.TeslimTarihi = dtpTeslimGuncelle.Value; 
            }

            tabControl1.SelectedIndex = 1;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
