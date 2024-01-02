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
    public partial class ParaCek : Form
    {
        public ParaCek()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RPF1DV4\\SQLEXPRESS;Initial Catalog=bankamatik;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            float sayi = float.Parse(maskedTextBox1.Text);

            if (sayi > Form1.mBakiye)
            {
                MessageBox.Show("Yetersiz Bakiye", "Para Çekme İşlemi");

            }
            else
            {
                SqlCommand cmd = new SqlCommand("update musteri set bakiye = bakiye - @p1 where ID = @p2", conn);

                cmd.Parameters.AddWithValue("@p1", sayi);
                cmd.Parameters.AddWithValue("@p2", Form1.mID);




                conn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc == 1)
                {
                    MessageBox.Show("Para Çekme İşlemi Yapıldı", "Para Çekme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Form1.mBakiye -= sayi;

                    HareketKaydet.kaydet(Form1.mID, (sayi + "TL Para Çekildi"));


                }
                else
                {
                    MessageBox.Show("Para Çekme İşlemi Başarısız!", "Para Çekme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    maskedTextBox1.Text = "";

                conn.Close();
            }
        }
    }
}
