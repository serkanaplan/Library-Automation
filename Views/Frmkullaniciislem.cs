using Baglantilar;
using Model;
using System;
using System.Windows.Forms;

namespace kotomasyon
{
    public partial class Frmkullaniciislem : Form
    {
        public Frmkullaniciislem()
        {
            InitializeComponent();
        }

        Kullaniciislemleri kullaniciislemleri = new Kullaniciislemleri();
        Kullanicimodel kullanicimodel = new Kullanicimodel();

        public void listele()
        {
           
            dataGridView1.DataSource = kullaniciislemleri.kullanicilistele(txtara);
            dataGridView1.Columns["yetki_durumu"].HeaderText = "Yetki";
            dataGridView1.Columns["a_kitap_sayisi"].HeaderText = "Kitap Sayisi";
            dataGridView1.Columns["kayit_durumu"].HeaderText = "Kayıtlımı";
            dataGridView1.Columns["uyelik_tarihi"].HeaderText = "Üyelik Tarihi";
            dataGridView1.Columns["ceza_tarihi"].HeaderText = "Ceza Tarihi";
            dataGridView1.Columns["a_kitap_sayisi"].HeaderText = "Kitap Sayisi";

        }

        public void txttemizle()
        {
            txtad.Clear();
            txtsoyad.Clear();
            txttc.Clear();
            txttel.Clear();
            txtmail.Clear();
            txtsifre.Clear();
            txtadres.Clear();
        }


        private void Kayıtol_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            kullanicimodel.ad = txtad.Text;
            kullanicimodel.soyad = txtsoyad.Text;
            kullanicimodel.tc = txttc.Text;
            kullanicimodel.tel = txttel.Text;
            kullanicimodel.mail = txtmail.Text;
            kullanicimodel.sifre = txtsifre.Text;
            kullanicimodel.adres = txtadres.Text;

            if (radiokullanici.Checked == true)
            {
                kullanicimodel.yetki_durumu = false;
            }
            else
            {
                kullanicimodel.yetki_durumu = true;
            }




            if (Validasyon.validasyondogrula(kullanicimodel) == true)
            {
                bool sonuc = kullaniciislemleri.kullanicivarmi(kullanicimodel.tc, kullanicimodel.tel, kullanicimodel.mail);
                if (sonuc==false)
                {
                    if (kullaniciislemleri.kullanciekle(kullanicimodel.ad, kullanicimodel.soyad, kullanicimodel.tc, kullanicimodel.tel, kullanicimodel.mail, kullanicimodel.sifre, kullanicimodel.adres, kullanicimodel.yetki_durumu))
                    {
                        MessageBox.Show("kayı başarıyla eklendi ");
                        listele();
                    }
                    else
                    {
                        MessageBox.Show("Hata! kayıt eklenemedi");
                    }
                    
                   
                }
                else
                {
                    MessageBox.Show("böyle bir kullanıcı zaten kayıtlı");
                }
            }
         
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            kullanicimodel.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            kullanicimodel.ad = txtad.Text;
            kullanicimodel.soyad = txtsoyad.Text;
            kullanicimodel.tc = txttc.Text;
            kullanicimodel.tel = txttel.Text;
            kullanicimodel.mail = txtmail.Text;
            kullanicimodel.sifre = txtsifre.Text;
            kullanicimodel.adres = txtadres.Text;
            kullanicimodel.a_kitap_sayisi = numerickitapsayisi.Value.ToString();
            kullanicimodel.borc =numericborc.Value.ToString();

            if (radiokullanici.Checked == true)
            {
                kullanicimodel.yetki_durumu = false;
            }
            else
            {
                kullanicimodel.yetki_durumu = true;
            }
            if (radioaktif.Checked)
            {
                kullanicimodel.kayit_durumu = true;

            }
            else
            {
                kullanicimodel.kayit_durumu = false;

            }

            if (Validasyon.validasyondogrula(kullanicimodel) == true)
            {
                bool guncelle = kullaniciislemleri.kullanciguncelle(kullanicimodel.ad, kullanicimodel.soyad, kullanicimodel.tc, kullanicimodel.tel, kullanicimodel.mail, kullanicimodel.sifre, kullanicimodel.adres, kullanicimodel.yetki_durumu,kullanicimodel.kayit_durumu,kullanicimodel.a_kitap_sayisi,kullanicimodel.borc, kullanicimodel.id);
                if (guncelle == true)
                {
                    MessageBox.Show("kayıt başarıyla güncellendi");
                }
                else
                {
                    MessageBox.Show("güncelleme başarısız");
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numerickitapsayisi.Visible = true;
            numericborc.Visible = true;
            lblkitapsayisi.Visible = true;
            lblborc.Visible = true;
            txtad.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txttc.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txttel.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtmail.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtsifre.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtadres.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            numerickitapsayisi.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[9].Value);
            numericborc.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[13].Value);

            if (Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[8].Value.ToString()) == true)
            {
                radioyonetici.Checked = true;
            }
            else
            {
                radiokullanici.Checked = true;
            }
            if (Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[10].Value.ToString())==true)
            {
                radioaktif.Checked = true;

            }
            else
            {
                radiopasif.Checked = true;

            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            kullanicimodel.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            bool sonuc =kullaniciislemleri.kullanicisil(kullanicimodel.id);
            if (sonuc== true)
            {
                MessageBox.Show("kayıt başarıyla silindi ");
            }
            else
            {
                MessageBox.Show("hata kayıt silinemedi");
            }
        }




        private void txtarama_TextChanged(object sender, EventArgs e)
        {

            //dataGridView1.DataSource = kullaniciislemleri.kullaniciara(txtara, radioaktif);
            listele();
       
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
