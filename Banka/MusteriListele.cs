using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class MusteriListele : Form
    {

        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dataTable;
        public MusteriListele()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RPF1DV4\\SQLEXPRESS;Initial Catalog=bankamatik;Integrated Security=True");

        private void MusteriListele_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("select * from musteri", conn);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from musteri where ad like '" + textBox1.Text +"%' ", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(dataTable);

            MessageBox.Show("Veriler güncellendi.");


        }

        
    }
}
