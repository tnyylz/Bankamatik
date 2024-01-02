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
    public partial class SifreUret : Form
    {
        public SifreUret()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RPF1DV4\\SQLEXPRESS;Initial Catalog=bankamatik;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || maskedTextBox1.Text == "")
            {
                MessageBox.Show("Lütfen gerekli alanları giriniz", "Şifre Değiştirme İşlemi");
            }
            else if (textBox1.Text.Length < 5)
            {
                MessageBox.Show("En Az 5 karakter uzunluğunda bir şifre giriniz!", "Şifre Değiştirme İşlemi");
            }

            else
            {
                SqlCommand cmd2 = new SqlCommand("update musteri set sifre =  @p1 where ID = @p2 and telefon = @p3", conn);


                cmd2.Parameters.AddWithValue("@p1", textBox3.Text);
                cmd2.Parameters.AddWithValue("@p2", textBox1.Text);
                cmd2.Parameters.AddWithValue("@p3", maskedTextBox1.Text);


                conn.Open();



                int sonuc = cmd2.ExecuteNonQuery();
                if (sonuc == 1)
                {
                    MessageBox.Show("Başarılı bir şekilde şifreniz değiştirilmiştir.", "Şifre Değiştirme İşlemi", MessageBoxButtons.OK);
                   // HareketKaydet.kaydet(Form1.mID, "Şifre Değiştirme");

                }
                else
                {
                    MessageBox.Show("Şifre değiştirme işleminiz başarısız !", "Şifre Değiştirme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                conn.Close();
                textBox1.Text = "";
                maskedTextBox1.Text = "";
                textBox3.Text = "";



            }
        }
    }
}

