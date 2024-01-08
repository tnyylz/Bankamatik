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
    public partial class MusteriAra : Form
    {
        public MusteriAra()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RPF1DV4\\SQLEXPRESS;Initial Catalog=bankamatik;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
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

                }
                else
                {
                    MessageBox.Show(txtAra.Text + " " + "Numaralı Kayıt Bulunamadı!", "Arama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Text = "";
                    txtTC.Text = "";
                    txtİsim.Text = "";
                    txtSoyisim.Text = "";
                    txtBakiye.Text = "";
                }

                conn.Close();


            }


        }
    }
}
