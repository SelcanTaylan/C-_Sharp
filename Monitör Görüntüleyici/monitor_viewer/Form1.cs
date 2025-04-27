using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monitor_viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Monitor> monitors = new List<Monitor>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Monitor m1= new Monitor("LG","l200",19,8000,"1920x1080",true);
            Monitor m2 = new Monitor("Samsung", "sm270", 17, 8000, "1920x1080", true);
            Monitor m3 = new Monitor("Noc", "noc2020", 15.9, 8000, "1920x1080", false);
            Monitor m4 = new Monitor("Arçelik", "arç25", 14, 8000, "1920x1080", true);
            monitors.Add(m1);
            monitors.Add(m2);
            monitors.Add(m3);
            monitors.Add(m4);
            dataGridView1.DataSource = monitors;
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            Monitor m=new Monitor();
            m.Marka=txtMarka.Text;
            m.Model=txtModel.Text;
            m.Boyut=Convert.ToDouble(txtBoyut.Text);
            m.Cozunurluk=txtCozunurluk.Text;
            m.Fiyat=Convert.ToDouble(txtFiyat.Text);
            m.Stokdurumu=chkStok.Checked;
            monitors.Add(m);
            dataGridView1.DataSource = monitors.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Monitor silinecekMonitor = (Monitor)dataGridView1.SelectedRows[0].DataBoundItem;
            monitors.Remove(silinecekMonitor);
            dataGridView1.DataSource= monitors.ToList();
        }
    }
}
