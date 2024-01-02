using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Banka
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RPF1DV4\\SQLEXPRESS;Initial Catalog=bankamatik;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into musteri (Tc,ad,soyad,sifre,bakiye,durum) values (@p1,@p2,@p3,@p4,@p5,@p6)",conn );
            cmd.Parameters.AddWithValue("@p1", txtTC.Text);
            cmd.Parameters.AddWithValue("@p2", txtİsim.Text);
            cmd.Parameters.AddWithValue("@p3", txtSoyisim.Text);
            cmd.Parameters.AddWithValue("@p4", txtSifre.Text);
            cmd.Parameters.AddWithValue("@p5", 0);
            cmd.Parameters.AddWithValue("@p6", 1);

            if (txtTC.Text == "" || txtİsim.Text == "" || txtSoyisim.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Tüm Alanları Doldurun","Müşteri Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
            }
            else
            {

                    conn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                conn.Close();
                if (sonuc == 1)
                {
                    MessageBox.Show("Üye Kaydedilmiştir!","Müşteri Kaydı");
                }
                else
                {
                    MessageBox.Show("Bir Hata Oluştu!","Müşteri Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }   

            txtTC.Text = "";
            txtİsim.Text = "";
            txtSoyisim.Text = "";
            txtSifre.Text = "";


            
                
        }
    }
}
