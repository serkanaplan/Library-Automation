using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Baglantilar
{
    public class Kitapislemleri
    {
        Dbconnect db = new Dbconnect();

        public bool kitapvarmi(string isbn)
        {
            DataTable dtb = new DataTable();
            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_kitap_varmi";
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@isbn", isbn);

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

        public bool kitapekle(string isbn, string kitap_adi, string yazar_id, string baski_yili, string yayinevi_id, string kategori_id, string stok, string ekleyen_mail)
        {

            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_kitap_ekle"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@isbn", isbn); komut.Parameters.AddWithValue("@kitap_adi", kitap_adi);
                    komut.Parameters.AddWithValue("@yazar_id", Convert.ToInt32(yazar_id));
                    komut.Parameters.AddWithValue("@baski_yili", Convert.ToInt32(baski_yili));
                    komut.Parameters.AddWithValue("@yayinevi_id", Convert.ToInt32(yayinevi_id));
                    komut.Parameters.AddWithValue("@kategori_id", Convert.ToInt32(kategori_id));
                    komut.Parameters.AddWithValue("@stok", Convert.ToInt32(stok));
                    komut.Parameters.AddWithValue("@ekleyen_mail", ekleyen_mail);



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


        public bool kitapguncelle(string isbn, string kitap_adi, string yazar_id, string baski_yili, string yayinevi_id, string kategori_id, string stok)
        {
            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_kitap_guncelle"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@isbn", isbn); komut.Parameters.AddWithValue("@kitap_adi", kitap_adi);
                    komut.Parameters.AddWithValue("@yazar_id", Convert.ToInt32(yazar_id));
                    komut.Parameters.AddWithValue("@baski_yili", Convert.ToInt32(baski_yili));
                    komut.Parameters.AddWithValue("@yayinevi_id", Convert.ToInt32(yayinevi_id));
                    komut.Parameters.AddWithValue("@kategori_id", Convert.ToInt32(kategori_id));
                    komut.Parameters.AddWithValue("@stok", Convert.ToInt32(stok));




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


        public bool kitapsil(string isbn)
        {
            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_kitap_sil"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@isbn", isbn);

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


        public DataTable kitapara(TextBox deger)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {

                    komut.CommandText = "sp_kitap_ara"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@deger", string.Format("{0}%", deger.Text));



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



        public DataTable kitaplistele(string deger)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_kitap_listele"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@deger", deger);

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

