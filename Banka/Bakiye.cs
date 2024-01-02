using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class Bakiye : Form
    {
        public Bakiye()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Bakiye_Load(object sender, EventArgs e)
        {
            label3.Text = Form1.mBakiye.ToString() + " TL ";
            HareketKaydet.kaydet(Form1.mID, "Bakiye Sorgulandı");

        }
    }
}
