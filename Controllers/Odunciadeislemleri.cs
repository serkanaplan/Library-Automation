using System;
using System.Data.SqlClient;
using System.Data;

namespace Baglantilar
{
    public class Odunciadeislemleri
    {
        Dbconnect db = new Dbconnect();
        public DataTable kitaplistele(Int16 durum)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_kullanici_kitap_listele"; komut.Parameters.AddWithValue("@durum", durum);
                    komut.CommandType = CommandType.StoredProcedure;

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
        public bool oduncal(string mail, string kitap_isbn)
        {

            using (SqlConnection conn = db.baglanti())
            {

                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_odunc_al"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@mail", mail); komut.Parameters.AddWithValue("@kitap_isbn", kitap_isbn);



                    int sonuc = db.ackapat(komut); if (sonuc == 2)
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

        public bool iadeet(int islem_id, int kullanici_id)
        {

            using (SqlConnection conn = db.baglanti())
            {

                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_iade_et"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@islem_id", islem_id); komut.Parameters.AddWithValue("@kullanici_id", kullanici_id);



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

        public DataTable oduncbilgi(string mail)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_odunc_bilgi"; komut.Parameters.AddWithValue("@mail", mail);
                    komut.CommandType = CommandType.StoredProcedure;

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

        public DataTable kitapstok(string isbn)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_stok_kontrol"; komut.Parameters.AddWithValue("@isbn", isbn);
                    komut.CommandType = CommandType.StoredProcedure;

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

        public bool sureuzat(int id)
        {

            using (SqlConnection conn = db.baglanti())
            {

                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_sure_uzat"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@id", id);



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
