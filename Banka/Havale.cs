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
    public partial class Havale : Form
    {
        public Havale()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RPF1DV4\\SQLEXPRESS;Initial Catalog=bankamatik;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            float sayi = float.Parse(txtMiktar.Text);
            int aliciNo = int.Parse(txtHesapNo.Text);
          



            if (sayi > Form1.mBakiye)
            {
                MessageBox.Show("Yetersiz Bakiye", "Havale/EFT işlemi");

            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("update musteri set bakiye = bakiye - @p1 where ID = @p2", conn);


                cmd2.Parameters.AddWithValue("@p1", sayi);
                cmd2.Parameters.AddWithValue("@p2", Form1.mID);

                SqlCommand cmd3 = new SqlCommand("update musteri set bakiye = bakiye + @p3 where ID = @p4", conn);
                cmd3.Parameters.AddWithValue("@p3", sayi);
                cmd3.Parameters.AddWithValue("@p4", aliciNo);

                if (sayi <= 0)
                {
                    MessageBox.Show("Geçersiz Değer", "Havale/EFT işlemi");
                }
                else
                {
                    conn.Open();
                      int sonuc1 = cmd3.ExecuteNonQuery();
                      conn.Close();
                    if (sonuc1 == 1)
                    {
                        conn.Open();
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Havale/EFT İşlemi Yapıldı", "Havale/EFT işlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Form1.mBakiye -= sayi;
                        HareketKaydet.kaydet(Form1.mID, (sayi + "TL Havale/EFT edildi"));


                    }
                    else
                    {
                        MessageBox.Show("Alıcı Hesap No hatalı", "Havale/EFT işlemi");

                    }
                }
            }
                txtMiktar.Text = "";
                txtHesapNo.Text = "";




          
        }
    }
}
