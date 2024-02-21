using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Baglantilar
{
    public class Kullaniciislemleri
    {
        Dbconnect db = new Dbconnect();

        public bool kullanicivarmi(string tc, string gsm, string mail)
        {
            DataTable dtb = new DataTable();
            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_kullanici_varmi";
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@tc", tc);
                    komut.Parameters.AddWithValue("tel", gsm);
                    komut.Parameters.AddWithValue("@mail", mail);

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

        public bool kullanciekle(string ad, string soyad, string tc, string tel, string mail, string sifre, string adres, bool yetki_durumu)
        {

            using (SqlConnection conn = db.baglanti())
            {

                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_kullanici_ekle"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@ad", ad); komut.Parameters.AddWithValue("@soyad", soyad);
                    komut.Parameters.AddWithValue("@tc", tc);
                    komut.Parameters.AddWithValue("@mail", mail);
                    komut.Parameters.AddWithValue("@sifre", sifre);
                    komut.Parameters.AddWithValue("@tel", tel);
                    komut.Parameters.AddWithValue("@adres", adres);
                    komut.Parameters.AddWithValue("@yetki_durumu", yetki_durumu);



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


        public bool kullanciguncelle(string ad, string soyad, string tc, string tel, string mail, string sifre, string adres, bool yetki_durumu, bool kayit_durumu, string a_kitap_sayisi, string borc, int id)
        {
            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_kullanici_guncelle"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@ad", ad); komut.Parameters.AddWithValue("@soyad", soyad);
                    komut.Parameters.AddWithValue("@tc", tc);
                    komut.Parameters.AddWithValue("@tel", tel);
                    komut.Parameters.AddWithValue("@mail", mail);
                    komut.Parameters.AddWithValue("@sifre", sifre);
                    komut.Parameters.AddWithValue("@adres", adres);
                    komut.Parameters.AddWithValue("@yetki_durumu", yetki_durumu);
                    komut.Parameters.AddWithValue("@kayit_durumu", kayit_durumu);
                    komut.Parameters.AddWithValue("@a_kitap_sayisi", Convert.ToInt32(a_kitap_sayisi));
                    komut.Parameters.AddWithValue("@borc", Convert.ToInt32(borc));

                    komut.Parameters.AddWithValue("@id", id);



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


        public bool kullanicisil(int id)
        {
            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_kullanici_sil"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@id", id);

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


        public DataTable kullaniciara(TextBox deger, RadioButton durum)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {

                    komut.CommandText = "sp_kullanici_ara"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@deger", string.Format("{0}%", deger.Text));
                    if (durum.Checked)
                    {
                        komut.Parameters.AddWithValue("@durum", true);
                    }
                    else
                    {
                        komut.Parameters.AddWithValue("@durum", false);

                    }

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



        public DataTable kullanicilistele(TextBox deger)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = db.baglanti())
            {
                using (SqlCommand komut = conn.CreateCommand())
                {
                    komut.CommandText = "sp_kullanici_listele"; komut.CommandType = CommandType.StoredProcedure; komut.Parameters.AddWithValue("@deger", string.Format("{0}%", deger.Text));


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

