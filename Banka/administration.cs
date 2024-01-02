using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class administration : Form
    {
        public administration()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriEkle = new MusteriEkle();
            musteriEkle.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriAra musteriAra = new MusteriAra();
            musteriAra.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriGuncelle musteriGuncelle = new MusteriGuncelle();
            musteriGuncelle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriSil musteriSil = new MusteriSil();
            musteriSil.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MusteriListele musteriListele = new MusteriListele();
            musteriListele.Show();
        }
    }
}
