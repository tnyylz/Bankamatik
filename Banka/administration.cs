using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Banka
{
    public partial class administration : Form
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



        public administration()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
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

        private void administration_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor= Color.FromArgb(46, 51, 73);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMekle.Height;
            pnlNav.Top = btnMekle.Top;
            btnMekle.BackColor = Color.FromArgb(46, 51, 73);
            MusteriEkle musteriEkle = new MusteriEkle();
            musteriEkle.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMara.Height;
            pnlNav.Top = btnMara.Top;
            btnMara.BackColor = Color.FromArgb(46, 51, 73);
            MusteriAra musteriAra = new MusteriAra();
            musteriAra.Show();  
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMsil.Height;
            pnlNav.Top = btnMsil.Top;
            btnMsil.BackColor = Color.FromArgb(46, 51, 73);
            MusteriSil musteriSil = new MusteriSil();
            musteriSil.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnEkle_Leave(object sender, EventArgs e)
        {
            btnMekle.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnMara_Leave(object sender, EventArgs e)
        {
            btnMara.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnMsil_Leave(object sender, EventArgs e)
        {
            btnMsil.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMliste_Leave(object sender, EventArgs e)
        {
            btnMliste.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnMliste_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMliste.Height;
            pnlNav.Top = btnMliste.Top;
            btnMliste.BackColor = Color.FromArgb(46, 51, 73);
            MusteriListele musteriListele = new MusteriListele();
            musteriListele.Show();
        }

        private void btnCikis_Leave(object sender, EventArgs e)
        {
            btnCikis.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCikis.Height;
            pnlNav.Top = btnCikis.Top;
            btnCikis.BackColor = Color.FromArgb(46, 51, 73);

            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
    }
}
