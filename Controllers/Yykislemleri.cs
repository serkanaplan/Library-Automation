using System;
using System.Data.SqlClient;
using System.Data;


namespace Baglantilar
{
    public class Yykislemleri
    {
        Dbconnect db = new Dbconnect();
        public bool yykvarmi(int tablo, string deger)
        {
            DataTable dtb = new DataTable();
            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_yyk_varmi";
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@tablo", tablo);
                    komut.Parameters.AddWithValue("@deger", deger);

                    if (db.ackapat(komut) == -1)
                    {
                        using (SqlDataAdapter adap = new SqlDataAdapter(komut))
                        {
                            adap.Fill(dtb);
                        }
                    }
                }
            }
            if (dtb.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool yykekle(int tablo, string deger)
        {

            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_yyk_ekle"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@tablo", tablo); komut.Parameters.AddWithValue("@deger", deger);



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

        public bool yykguncelle(string id, string deger, int tablo)
        {
            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {

                    komut.CommandText = "sp_yyk_guncelle"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@id", Convert.ToInt32(id)); komut.Parameters.AddWithValue("@deger", deger);
                    komut.Parameters.AddWithValue("@tablo", tablo);




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

        public bool yyksil(int tablo, string id)
        {
            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_yyk_sil"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                    komut.Parameters.AddWithValue("@tablo", tablo);

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
        public DataTable yyklistele(string deger)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_yyk_listele"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@tablo", Convert.ToInt32(deger));


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


    }
}
