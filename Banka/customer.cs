using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class customer : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

        );



        public customer()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

      
        private void label6_Click(object sender, EventArgs e)
        {

        }

      
        private void customer_Load(object sender, EventArgs e)
        {
            labelİsim.Text = Form1.ad;
            labelHesapNo.Text = Form1.mID.ToString();
            lblBakiye.Text = Form1.mBakiye.ToString() + "TL";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button1.Height;
            pnlNav.Top = button1.Top;
            button1.BackColor = Color.FromArgb(46, 51, 73);
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void btnParaEkle_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnParaCek.Height;
            pnlNav.Top = btnParaCek.Top;
            btnParaCek.BackColor = Color.FromArgb(46, 51, 73);
            ParaCekYatir paraCek = new ParaCekYatir();
            paraCek.Show();
        }

       

       
        private void btnEft_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = btnEft.Height;
            pnlNav.Top = btnEft.Top;
            btnEft.BackColor = Color.FromArgb(46, 51, 73);
            Havale havale = new Havale();
            havale.Show();
        }

        private void btnSifre_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = btnSifre.Height;
            pnlNav.Top = btnSifre.Top;
            btnSifre.BackColor = Color.FromArgb(46, 51, 73);
            SifreDegistirme sifreDegistirme = new SifreDegistirme();
            sifreDegistirme.Show();
        }

        private void btnHesap_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = btnHesap.Height;
            pnlNav.Top = btnHesap.Top;
            btnHesap.BackColor = Color.FromArgb(46, 51, 73);
            HesapHareketleri hesapHareketleri = new HesapHareketleri();
            hesapHareketleri.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnParaCek_Leave(object sender, EventArgs e)
        {
            btnParaCek.BackColor = Color.FromArgb(24, 30, 54);

        }

     

        private void btnEft_Leave(object sender, EventArgs e)
        {
            btnEft.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnSifre_Leave(object sender, EventArgs e)
        {
            btnSifre.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnHesap_Leave(object sender, EventArgs e)
        {
            btnHesap.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnParaYatır_Click(object sender, EventArgs e)
        {

        }

        private void btnParaYatır_Leave(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnBilgi.Height;
            pnlNav.Top = btnBilgi.Top;
            btnBilgi.BackColor = Color.FromArgb(46, 51, 73);
            HesapBilgileri hesapBilgileri = new HesapBilgileri();
            hesapBilgileri.Show();
        }

        private void btnBilgi_Leave(object sender, EventArgs e)
        {
            btnBilgi.BackColor = Color.FromArgb(24, 30, 54);

        }
    }
}
