using Baglantilar;
using Model;
using System;
using System.Data;
using System.Windows.Forms;
namespace kotomasyon
{
    public partial class Frmgiris : Form
    {
        public Frmgiris()
        {
            InitializeComponent();
        }

        Girisislemleri girisislemleri = new Girisislemleri(); Girismodel giris = new Girismodel();

        private void button1_Click_1(object sender, EventArgs e)
        {
            giris.mail = txtemail.Text;
            giris.sifre = txtsifre.Text;



            if (Validasyon.validasyondogrula(giris) == true)
            {
                DataTable kayit = girisislemleri.kullanicivarmı(giris.mail, giris.sifre);
                if (kayit != null)
                {
                    if (Convert.ToBoolean(kayit.Rows[0]["yetki_durumu"]) == true)
                    {
                        Frmyonetici frmyonetici = new Frmyonetici();
                        frmyonetici.lblkullaniciadi.Text = kayit.Rows[0]["mail"].ToString();
                        frmyonetici.lblborc.Text = kayit.Rows[0]["borc"].ToString();
                        frmyonetici.lblkitapsayisi.Text = kayit.Rows[0]["a_kitap_sayisi"].ToString();
                        frmyonetici.lbltarih.Text = kayit.Rows[0]["ceza_tarihi"].ToString();



                        frmyonetici.Show();
                        this.Hide();
                    }
                    else
                    {
                        Frmislem kullaniciformu = new Frmislem();
                        kullaniciformu.lblkullaniciadi.Text = kayit.Rows[0]["mail"].ToString();
                        kullaniciformu.lblborc.Text = kayit.Rows[0]["borc"].ToString();
                        kullaniciformu.lblkitapsayisi.Text = kayit.Rows[0]["a_kitap_sayisi"].ToString();
                        kullaniciformu.lbltarih.Text = kayit.Rows[0]["ceza_tarihi"].ToString();
                        kullaniciformu.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("boyle bir kullanıcı bulunamadı");
                }
            }


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frmgiris_Load(object sender, EventArgs e)
        {
            DataTable kkisayisi = girisislemleri.kkisayisi();
            lblkullanicisayisi.Text = lblkullanicisayisi.Text + kkisayisi.Rows[0]["sayi"].ToString();
            lblkitapsayisi.Text = lblkitapsayisi.Text + kkisayisi.Rows[1]["sayi"].ToString();
            lbloduncsayisi.Text = lbloduncsayisi.Text + kkisayisi.Rows[2]["sayi"].ToString();
        }

        private void Btnsifredegistir(object sender, EventArgs e)
        {
            Frmsifredegistir frmsifredegistir = new Frmsifredegistir();
            frmsifredegistir.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

}
