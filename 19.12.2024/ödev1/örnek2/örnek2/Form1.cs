using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          DateTime bugun=DateTime.Now;
          DateTime dogumgunu = new DateTime(2025, 3, 30);
          TimeSpan fark=dogumgunu-bugun;
          label1.Text= "Doğum Günüme: "+fark.Days.ToString();
        }
    }
}
