using System.Data;
using System.Data.SqlClient;

namespace Baglantilar
{
    public class Girisislemleri
    {
        Dbconnect db = new Dbconnect();
        public DataTable kullanicivarmı(string mail, string sifre)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_kullanici_kontrol"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@mail", mail); komut.Parameters.AddWithValue("@sifre", sifre);

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
        public DataTable kkisayisi()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_kki_sayisi";
                    komut.CommandType = CommandType.StoredProcedure;

                    if (db.ackapat(komut) == -1)
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

        public bool sifredegistir(string mail, string sifre)
        {

            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_sifre_degistir"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@mail", mail);
                    komut.Parameters.AddWithValue("@sifre", sifre);




                    int sonuc = db.ackapat(komut); if (sonuc != 0)
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
