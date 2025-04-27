using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ticket_queue_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue kuyruk=new Queue();
        int sira = 0;

        public void Listele()
        {
            lstGise.Items.Clear();
            foreach (var s in kuyruk)
            {
                lstGise.Items.Add(s);
            }
        }

        private void btnSiraAl_Click(object sender, EventArgs e)
        {
            sira++;
            kuyruk.Enqueue(sira);
            Listele();
        }

        private void btnGise1_Click(object sender, EventArgs e)
        {
            try
            {
                int alinanSira = (int)kuyruk.Dequeue();
                btnGise1.Text = "Gişe 1\n" + alinanSira.ToString();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Sıra Bitti", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGise2_Click(object sender, EventArgs e)
        {
            try
            {
                int alinanSira = (int)kuyruk.Dequeue();
                btnGise2.Text = "Gişe 2\n" + alinanSira.ToString();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Sıra Bitti", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGise3_Click(object sender, EventArgs e)
        {
            try
            {
                int alinanSira = (int)kuyruk.Dequeue();
                btnGise3.Text = "Gişe 3\n" + alinanSira.ToString();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Sıra Bitti", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            sira = 0;
        }
    }
}
