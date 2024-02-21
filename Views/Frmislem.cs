using Baglantilar;
using Model;
using System;
using System.Data;
using System.Windows.Forms; 

namespace kotomasyon
{
    public partial class Frmislem : Form
    {
        public Frmislem()
        {
            InitializeComponent();
        }
        DateTime tarih=DateTime.Now;
        Kitapislemleri kitapislemleri= new Kitapislemleri();
        Odunciadeislemleri odunciadeislemleri =new Odunciadeislemleri();
        Frmgiris frmgiris= new Frmgiris();
        Girismodel girismodel= new Girismodel();
        Girisislemleri giriskontrol=new Girisislemleri();
        private void button4_Click(object sender, EventArgs e)
        {

        }
        public void listele()
        {
            datagridkitap.DataSource = kitapislemleri.kitapara(txtara);
            datagridkitap.Columns["kitap_adi"].HeaderText = "Kitap";
            datagridkitap.Columns["ad_soyad"].HeaderText = "Yazar";
            datagridkitap.Columns["baski_yili"].HeaderText = "Baskı";
            datagridkitap.Columns["yayinevi_adi"].HeaderText = "Yayınevi";
            datagridkitap.Columns["kategori_adi"].HeaderText = "Kategori";
            datagridkitap.Columns["raftami"].HeaderText = "Raftamı";

            datagridkitap.Columns["kitap_durumu"].Visible = false;
            datagridkitap.Columns["kayit_tarihi"].Visible = false;

          

            DataTable dtb = odunciadeislemleri.oduncbilgi(lblkullaniciadi.Text);
          
            if (dtb!=null)
            {
                lbltarih.Text = dtb.Rows[0]["ceza_tarihi"].ToString();
                lblkitapsayisi.Text = dtb.Rows[0]["a_kitap_sayisi"].ToString();
                lblborc.Text = dtb.Rows[0]["borc"].ToString();
                datagridodunc.DataSource = dtb;
                datagridodunc.Columns["kitap_id"].HeaderText = "isbn";
                datagridodunc.Columns["kitap_adi"].HeaderText = "Kitap";
                datagridodunc.Columns["ad_soyad"].HeaderText = "Yazar";
                datagridodunc.Columns["baski_yili"].HeaderText = "Baskı";
                datagridodunc.Columns["yayinevi_adi"].HeaderText = "Yayınevi";
                datagridodunc.Columns["kategori_adi"].HeaderText = "Kategori";



                datagridodunc.Columns["a_kitap_sayisi"].Visible = false;
                datagridodunc.Columns["borc"].Visible = false;
                datagridodunc.Columns["id"].Visible = false;
                datagridodunc.Columns["ceza_tarihi"].Visible = false;
                datagridodunc.Columns["sure_uzatma_sayisi"].Visible = false;

            }
            else
            {
                datagridodunc.DataSource = null;
            }


        }

        private void frmkullanici_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            listele();
        }

        private void btnexit(object sender, EventArgs e)
        {
            this.Hide();
            Frmgiris frmgiris= new Frmgiris();
            frmgiris.Show();
        }


        private void btnoduncal(object sender, EventArgs e)
        {
            DateTime cezatarihi=new DateTime();
            if (string.IsNullOrEmpty(lbltarih.Text)==false)
            {
                cezatarihi = Convert.ToDateTime(lbltarih.Text);
            }
            
            if (string.IsNullOrEmpty(lbltarih.Text) || cezatarihi<tarih)
            {
                if (Convert.ToInt32(lblborc.Text) == 0)//borcu sıfır ise kitap alabilecek
                {
                    if (Convert.ToInt32(lblkitapsayisi.Text) < 3)//aldığı kitap sayisi üçten küçükse alabilecek
                    {
                        DataTable dt = odunciadeislemleri.kitapstok(datagridkitap.SelectedRows[0].Cells[0].Value.ToString());
                        int stok = Convert.ToInt32(dt.Rows[0][0].ToString());

                        if (Convert.ToInt32(datagridkitap.SelectedRows[0].Cells[9].Value) >= stok + 1)//kitap rafta ise ödünç alabilir buyüzden işlem yapılan kitabın stok bilgisiyle kullanımdaki sayısı karşılaştırılıyor. value değeri, ödünç alınmasına rağmen en başta 0 döndüğü için +1 verdik
                        {
                            odunciadeislemleri.oduncal(lblkullaniciadi.Text, datagridkitap.SelectedRows[0].Cells[0].Value.ToString());
                            MessageBox.Show("Aldığınız Kitap :" + datagridkitap.SelectedRows[0].Cells[1].Value.ToString() + "\n" +
                                "En Geç İade Etmeniz Gereken Tarih :" + (tarih.Day + 15) + "/" + tarih.Month + "/" + tarih.Year);

                            listele();
                        }
                        else
                        {
                            MessageBox.Show("Bu kitap Şuan Kullanımda");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Alabileceğiniz maximum kitap sayısını aştınız");
                    }

                }


                else
                {
                    MessageBox.Show("kitap alabilmek için borcunuzu ödemeniz gerekiyor");
                }
            }
            else
            {
                DateTime ceza = Convert.ToDateTime(lbltarih.Text);
                MessageBox.Show(ceza.Day+"/"+ ceza.Month+ "/"+ceza.Year+ " Tarihine kadar cezalısınız");

            }

        }

        private void btniadeet(object sender, EventArgs e)
        {
            if (datagridodunc.DataSource!=null)
            {
                if (odunciadeislemleri.iadeet(Convert.ToInt32(datagridodunc.SelectedRows[0].Cells[0].Value), Convert.ToInt32(datagridodunc.SelectedRows[0].Cells[1].Value)))
                {
                    //    MessageBox.Show("İade Edilen Kitap :" + datagridkitap.SelectedRows[0].Cells[1].Value.ToString()+"\n" +
                    //        "İade Etmeniz Gereken Tarih :" + DateTime.Now+15);
                    listele();
                }
            }
            else
            {
                MessageBox.Show("iade edilecek kitap yok","Uyarı");
            }

           
        }

        private void txtara_TextChanged_1(object sender, EventArgs e)
        {
            datagridkitap.DataSource = kitapislemleri.kitapara(txtara);

            if (kitapislemleri.kitapara(txtara)!=null)
            {
                datagridkitap.Columns["kitap_adi"].HeaderText = "Kitap";
                datagridkitap.Columns["ad_soyad"].HeaderText = "Yazar";
                datagridkitap.Columns["baski_yili"].HeaderText = "Baskı";
                datagridkitap.Columns["yayinevi_adi"].HeaderText = "Yayınevi";
                datagridkitap.Columns["kategori_adi"].HeaderText = "Kategori";
                datagridkitap.Columns["raftami"].HeaderText = "Raftamı";

                datagridkitap.Columns["kitap_durumu"].Visible = false;
                datagridkitap.Columns["kayit_tarihi"].Visible = false;
            }
        }

        private void btnsureuzat(object sender, EventArgs e)
        {
            if (datagridodunc.DataSource!=null)
            {
                if (string.IsNullOrEmpty(lbltarih.Text) && Convert.ToInt32(lblborc.Text)==0)
                {
                    if (Convert.ToInt32(datagridodunc.SelectedRows[0].Cells["sure_uzatma_sayisi"].Value) <2)
                    {
                        odunciadeislemleri.sureuzat(Convert.ToInt32(datagridodunc.SelectedRows[0].Cells[0].Value));
                        MessageBox.Show(datagridodunc.SelectedRows[0].Cells["sure_uzatma_sayisi"].Value.ToString());
                        listele();
                    }
                    else
                    {
                        MessageBox.Show("Üçüncü Kez Süre Uzatamazsınız!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Cezanız var süre uzatamazsınız!");
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void datagridkitap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
