using System.Data.SqlClient;

namespace Baglantilar
{
    public class Dbconnect
    {
        public SqlConnection baglanti()
        {
            SqlConnection conn = new SqlConnection("Data Source=ACER\\SQLEXPRESS;Initial Catalog=kutuphaneotomasyon;Integrated Security=True");
            return conn;
        }

        public int ackapat(SqlCommand komut)
        {
            komut.Connection.Open();

            int sonuc = komut.ExecuteNonQuery();
            komut.Connection.Close(); return sonuc;
        }



    }


}
