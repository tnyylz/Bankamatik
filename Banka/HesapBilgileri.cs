using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Banka
{
    public partial class HesapBilgileri : Form
    {
        public HesapBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RPF1DV4\\SQLEXPRESS;Initial Catalog=bankamatik;Integrated Security=True");

        private void HesapBilgileri_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from musteri where ID = @p1 ", conn);
            cmd.Parameters.AddWithValue("@p1", Form1.mID);

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
               
                txtAd.Text = rdr["ad"].ToString();
                txtSifre.Text = Form1.mSifre.ToString();
                txtID.Text = Form1.mID.ToString();
                txtSoyad.Text = rdr["soyad"].ToString();
                txtTC.Text = rdr["Tc"].ToString();
                txtTel.Text = rdr["telefon"].ToString();
                txtCinsiyet.Text = rdr["cinsiyet"].ToString();


            }


        }
    }
}
