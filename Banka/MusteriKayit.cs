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
    public partial class MusteriKayit : Form
    {
        public MusteriKayit()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RPF1DV4\\SQLEXPRESS;Initial Catalog=bankamatik;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            conn.Open();
          


            SqlCommand cmd2 = new SqlCommand("select * from musteri where telefon = @p5 or Tc = @p1", conn);
            cmd2.Parameters.AddWithValue("@p1", txtTC.Text);
            cmd2.Parameters.AddWithValue("@p5", maskedTextBox1.Text);
            SqlDataReader reader = cmd2.ExecuteReader();



                if (reader.Read())  
                {
                    MessageBox.Show("Bu Kimlik No / Telefon No'sunda bir kullanıcı bulunmaktadır!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                if (txtTC.Text == "" || txtİsim.Text == "" || txtSoyisim.Text == "" || txtSifre.Text == "" || maskedTextBox1.Text == "")
                {
                    MessageBox.Show("Tüm Alanları Doldurun", "Müşteri Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    reader.Close();
                    SqlCommand cmd = new SqlCommand("insert into musteri (Tc,ad,soyad,sifre,telefon,bakiye,durum,cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", conn);

                    cmd.Parameters.AddWithValue("@p1", txtTC.Text);
                    cmd.Parameters.AddWithValue("@p2", txtİsim.Text);
                    cmd.Parameters.AddWithValue("@p3", txtSoyisim.Text);
                    cmd.Parameters.AddWithValue("@p4", txtSifre.Text);
                    cmd.Parameters.AddWithValue("@p5", maskedTextBox1.Text);
                    cmd.Parameters.AddWithValue("@p6", 0);
                    cmd.Parameters.AddWithValue("@p7", 1);
                    cmd.Parameters.AddWithValue("@p8", comboBox1.SelectedItem.ToString());



                    int sonuc = cmd.ExecuteNonQuery();

                    if (sonuc == 1)
                    {
                        MessageBox.Show("Kaydınız Başarılı Bir Şekilde Oluşturulmuştur!", "Kayıt işlemi");
                    }
                    else
                    {
                        MessageBox.Show("Bir Hata Oluştu!", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
             }




                            conn.Close();





                    txtTC.Text = "";
                    txtİsim.Text = "";
                    txtSoyisim.Text = "";
                    txtSifre.Text = "";
                    maskedTextBox1.Text = "";
                    


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void MusteriKayit_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Erkek");
            comboBox1.Items.Add("Kadın");

        }
    }
}
    



