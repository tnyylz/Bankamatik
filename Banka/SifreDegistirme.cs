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
    public partial class SifreDegistirme : Form
    {
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RPF1DV4\\SQLEXPRESS;Initial Catalog=bankamatik;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
           




            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Lütfen gerekli alanları giriniz", "Şifre Değiştirme İşlemi");
            }
            else if (textBox1.Text != Form1.mSifre)
            {
                MessageBox.Show("Şifreniz Geçersizdir", "Şifre Değiştirme İşlemi");
            }
            
            else
            {
                SqlCommand cmd2 = new SqlCommand("update musteri set sifre =  @p1 where ID = @p2", conn);


                cmd2.Parameters.AddWithValue("@p1", textBox2.Text);
                cmd2.Parameters.AddWithValue("@p2", Form1.mID);
                
                conn.Open();

                

                    int sonuc = cmd2.ExecuteNonQuery();
                    if (sonuc == 1)
                    {
                        Form1.mSifre = textBox2.Text;
                        MessageBox.Show("Başarılı bir şekilde şifreniz değiştirilmiştir.", "Şifre Değiştirme İşlemi", MessageBoxButtons.OK);
                        HareketKaydet.kaydet(Form1.mID, "Şifre Değiştirme");

                        }
                else
                    {
                        MessageBox.Show("Şifre değiştirme işleminiz başarısız !", "Şifre Değiştirme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    conn.Close();
                textBox1.Text = "";
                textBox2.Text = "";


            }

        }
    }
}
