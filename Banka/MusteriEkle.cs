﻿using System;
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

            conn.Open();
          



            SqlCommand cmd2 = new SqlCommand("select * from musteri where telefon = @p5 or Tc = @p1", conn);
            cmd2.Parameters.AddWithValue("@p1", txtTC.Text);
            cmd2.Parameters.AddWithValue("@p5", maskedTextBox1.Text);

            SqlDataReader rdr = cmd2.ExecuteReader();


            if (rdr.Read())
            {
                MessageBox.Show("Bu Kimlik No / Telefon No'sunda bir kullanıcı bulunmaktadır!", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtTC.Text == "" || txtİsim.Text == "" || txtSoyisim.Text == "" || txtSifre.Text == "" || maskedTextBox1.Text == "")
                {
                    MessageBox.Show("Tüm Alanları Doldurun", "Müşteri Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    rdr.Close();
                    SqlCommand cmd = new SqlCommand("insert into musteri (Tc,ad,soyad,sifre,telefon,bakiye,durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", conn);
                    cmd.Parameters.AddWithValue("@p1", txtTC.Text);
                    cmd.Parameters.AddWithValue("@p2", txtİsim.Text);
                    cmd.Parameters.AddWithValue("@p3", txtSoyisim.Text);
                    cmd.Parameters.AddWithValue("@p4", txtSifre.Text);
                    cmd.Parameters.AddWithValue("@p5", maskedTextBox1.Text);
                    cmd.Parameters.AddWithValue("@p6", 0);
                    cmd.Parameters.AddWithValue("@p7", 1);
                    int sonuc = cmd.ExecuteNonQuery();


                    if (sonuc == 1)
                    {
                        MessageBox.Show("Üye Kaydedilmiştir!", "Müşteri Kaydı");
                    }
                    else
                    {
                        MessageBox.Show("Bir Hata Oluştu!", "Müşteri Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
