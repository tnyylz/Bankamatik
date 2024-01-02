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
    public partial class HesapHareketleri : Form
    {
        public HesapHareketleri()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RPF1DV4\\SQLEXPRESS;Initial Catalog=bankamatik;Integrated Security=True");

        private void HesapHareketleri_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from hareketler where mID = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", Form1.mID);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;


        }
    }
}
