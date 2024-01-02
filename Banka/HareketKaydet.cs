using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    internal class HareketKaydet
    {
        public static void kaydet( int mId, string msj)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RPF1DV4\\SQLEXPRESS;Initial Catalog=bankamatik;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into hareketler (mID,islem,tarih) values (@p1,@p2,@p3)" , conn);
            cmd.Parameters.AddWithValue("@p1", Form1.mID);
            cmd.Parameters.AddWithValue("@p2", msj);
            cmd.Parameters.AddWithValue("@p3", DateTime.Now);

            conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
