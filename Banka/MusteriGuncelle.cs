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
    public partial class MusteriGuncelle : Form
    {
        public MusteriGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RPF1DV4\\SQLEXPRESS;Initial Catalog=bankamatik;Integrated Security=True");

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from musteri where ID = @p1 or Tc = @p2", conn);
            cmd.Parameters.AddWithValue("@p1", txtAra.Text);
            cmd.Parameters.AddWithValue("@p2", txtAra.Text);




            if (txtAra.Text == "")
            {
                MessageBox.Show("ID/TC No değerini giriniz", "Arama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtID.Text = reader["ID"].ToString();
                    txtTC.Text = reader["Tc"].ToString();
                    txtİsim.Text = reader["ad"].ToString();
                    txtSoyisim.Text = reader["soyad"].ToString();
                    txtBakiye.Text = reader["bakiye"].ToString();
                    maskedTextBox1.Text = reader["durum"].ToString();


                }
                else
                {
                    MessageBox.Show(txtAra.Text + " "+ "Numaralı Kayıt Bulunamadı!", "Arama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Text = "";
                    txtTC.Text = "";
                    txtİsim.Text = "";
                    txtSoyisim.Text = "";
                    txtBakiye.Text = "";
                }

                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update musteri set ad = @p3, soyad = @p4, durum = @p5 where ID = @p1 or Tc = @p2", conn);
            cmd.Parameters.AddWithValue("@p1", txtAra.Text);
            cmd.Parameters.AddWithValue("@p2", txtAra.Text);
            cmd.Parameters.AddWithValue("@p3", txtİsim.Text);
            cmd.Parameters.AddWithValue("@p4", txtSoyisim.Text);
            cmd.Parameters.AddWithValue("@p5", maskedTextBox1.Text);



            conn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc == 1)
                {
                    MessageBox.Show("Güncelleme Yapıldı", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
                {
                    MessageBox.Show(txtAra.Text + "Güncelleme Yapılamadı!", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    txtID.Text = "";
                    txtTC.Text = "";
                    txtİsim.Text = "";
                    txtSoyisim.Text = "";
                    txtBakiye.Text = "";
                    maskedTextBox1.Text = "";

                conn.Close();
            }
        }
    }

