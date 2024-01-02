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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnparayatir_Click(object sender, EventArgs e)
        {
            ParaYatir frm = new ParaYatir();
            frm.Show();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            labelİsim.Text = Form1.ad;
            labelHesapNo.Text = Form1.mID.ToString();

        }

        private void btnparacek_Click(object sender, EventArgs e)
        {
            ParaCek paraCek = new ParaCek();
            paraCek.Show();
        }

        private void btnbakiye_Click(object sender, EventArgs e)
        {
            Bakiye bakiye = new Bakiye();
            bakiye.Show();
        }

        private void btneft_Click(object sender, EventArgs e)
        {
            Havale havale = new Havale();   
            havale.Show();
        }

        private void btnsifre_Click(object sender, EventArgs e)
        {
            SifreDegistirme sifreDegistirme = new SifreDegistirme();
            sifreDegistirme.Show();
        }

        private void btnhesap_Click(object sender, EventArgs e)
        {
            HesapHareketleri hesapHareketleri = new HesapHareketleri();
            hesapHareketleri.Show();
        }
    }
}
