using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Banka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            radioButton2.Checked = true;
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RPF1DV4\\SQLEXPRESS;Initial Catalog=bankamatik;Integrated Security=True");
        public static string ad = "";
        public static int mID = 0;
        public static float mBakiye = 0.00f;
        public static string mSifre = "";
        private int durum;

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            bool sonuc = false;



            if (radioButton1.Checked)
            {
                if (username =="admin" &&  password =="1")
                {
                    administration administration = new administration();
                    administration.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı/TC veya Parola !");
                }

            }
            else
            {

                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("select * from musteri where Tc = @p1 and sifre = @p2 and durum = 1 ",conn);
                        cmd.Parameters.AddWithValue("@p1",username);
                        cmd.Parameters.AddWithValue("@p2", password);


                        SqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            durum = int.Parse(rdr["durum"].ToString());
                            ad = rdr["ad"].ToString();
                            mSifre = rdr["sifre"].ToString();
                            mID = int.Parse(rdr["ID"].ToString());
                            mBakiye = float.Parse(rdr["bakiye"].ToString());

                            sonuc = true;
                        }

                        conn.Close();

                        if (sonuc)
                        {
                            sonuc = false;
                            customer customer = new customer();
                            customer.Show();
                            this.Hide();
                        }
                   
                        else
                        {
                            if (durum == 0)
                            {
                            MessageBox.Show("Aktif Olmayan Kullanıcı Girişi Lütfen Bankanızla Görüşünüz!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                            MessageBox.Show("Hatalı Kullanıcı Adı/TC veya Parola !", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        textBox1.Text = "";
                        textBox2.Text = "";




                    }



                }
                catch (Exception warning)
                {
                    MessageBox.Show("Sorun" + warning);
                }

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreUret sifreUret = new SifreUret();
            sifreUret.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MusteriKayit musteriKayit = new MusteriKayit();
            musteriKayit.Show();
            this.Hide();
        }
    }
}
