using System.Data.SqlClient;
using System.Data;
using Baglantilar;

namespace Controller
{
    public class Odunclistele
    {
        Dbconnect db = new Dbconnect();
        public DataTable islemlistele(string deger)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_islem_listele"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@deger", string.Format("{0}%", deger));

                    int sonuc = db.ackapat(komut); if (sonuc == -1)
                    {
                        using (SqlDataAdapter adap = new SqlDataAdapter(komut))
                        {
                            adap.Fill(dt);
                        }
                    }


                }
            }
            if (dt.Rows.Count > 0)
            {
                return dt;
            }

            else
            {
                return null;
            }
        }

        public bool islemguncelle(int id, bool islem_durumu)
        {
            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_islem_guncelle"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@id", id);
                    komut.Parameters.AddWithValue("@islem_durumu", islem_durumu);


                    int sonuc = db.ackapat(komut); if (sonuc == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
