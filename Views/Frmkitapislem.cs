using Baglantilar;
using Model;
using System;
using System.Windows.Forms;

namespace kotomasyon
{
    public partial class Frmkitapislem : Form
    {
        public Frmkitapislem()
        {
            InitializeComponent();
        }

        Kitapislemleri kitapislemleri= new Kitapislemleri();
        Kitapmodel kitapmodel= new Kitapmodel();
        Comboboxislemleri combocontrol =new Comboboxislemleri();
        Frmyykislem frmyykislem = new Frmyykislem();
        Yykislemleri yykislemleri= new Yykislemleri();

        public void txttemizle()
        {
            txtisbn.Clear();
            txtkitapadi.Clear();
        }

        public void listele()
        {
             ;
            if (kitapislemleri.kitaplistele(txtara.Text) != null)
            {
                datagridkitap.DataSource =kitapislemleri.kitaplistele(txtara.Text);
                datagridkitap.Columns["kitap_adi"].HeaderText = "Kitap";
                datagridkitap.Columns["ad_soyad"].HeaderText = "Yazar";
                datagridkitap.Columns["baski_yili"].HeaderText = "Baskı";
                datagridkitap.Columns["yayinevi_adi"].HeaderText = "Yayınevi";
                datagridkitap.Columns["kategori_adi"].HeaderText = "Kategori";
                datagridkitap.Columns["kayit_tarihi"].HeaderText = "Kayıt Tarihi";
                datagridkitap.Columns["raftami"].HeaderText = "Raftamı";
                datagridkitap.Columns["kitap_durumu"].HeaderText = "Aktifmi";
                datagridkitap.Columns["ekleyen"].HeaderText = "Ekleyen Kişi";
                datagridkitap.Columns["id"].Visible = false;
                

            }





        }
        private void Frmkitapislem_Load(object sender, EventArgs e)
        {
            listele();
            combocontrol.combodoldur( "ad_soyad", "id", "sp_yazar_listele", comboyazar);
            combocontrol.combodoldur("yayinevi_adi", "id", "sp_yayinevi_listele", comboyayinevi);
            combocontrol.combodoldur("kategori_adi", "id", "sp_kategori_listele", combokategori);


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            kitapmodel.isbn = txtisbn.Text;
            kitapmodel.kitap_adi = txtkitapadi.Text;
            kitapmodel.yazar_id = comboyazar.SelectedValue.ToString();
            kitapmodel.yayinevi_id = comboyayinevi.SelectedValue.ToString();
            kitapmodel.baski_yili = numericbaskiyili.Value.ToString();
            kitapmodel.kategori_id = combokategori.SelectedValue.ToString();
            kitapmodel.stok=numericstok.Value.ToString();
            kitapmodel.ekleyen_mail=lblmail.Text;
            if (Validasyon.validasyondogrula(kitapmodel))
            {
                bool sonuc = kitapislemleri.kitapvarmi(kitapmodel.isbn);
                if (sonuc == false)
                {

                    if (kitapislemleri.kitapekle(kitapmodel.isbn, kitapmodel.kitap_adi, kitapmodel.yazar_id, kitapmodel.baski_yili, kitapmodel.yayinevi_id, kitapmodel.kategori_id, kitapmodel.stok,kitapmodel.ekleyen_mail))
                    {
                        MessageBox.Show("kitap başarıyla eklendi ");
                        listele();
                    }

                    else
                    {
                        MessageBox.Show("Hata! kitap eklenemedi");
                    }
                }
                else
                {
                    MessageBox.Show("böyle bir kitap zaten kayıtlı");
                }

               

            }
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            kitapmodel.isbn = txtisbn.Text;
            kitapmodel.kitap_adi = txtkitapadi.Text;
            kitapmodel.yazar_id = comboyazar.SelectedValue.ToString();
            kitapmodel.yayinevi_id = comboyayinevi.SelectedValue.ToString();
            kitapmodel.baski_yili = numericbaskiyili.Value.ToString();
            kitapmodel.kategori_id = combokategori.SelectedValue.ToString();
            kitapmodel.stok= numericstok.Value.ToString();

            if (Validasyon.validasyondogrula(kitapmodel) == true)
            {
                bool guncelle = kitapislemleri.kitapguncelle(kitapmodel.isbn, kitapmodel.kitap_adi, kitapmodel.yazar_id, kitapmodel.baski_yili, kitapmodel.yayinevi_id, kitapmodel.kategori_id,kitapmodel.stok);
                if (guncelle == true)
                {
                    MessageBox.Show("kayıt başarıyla güncellendi");
                }
                else
                {
                    MessageBox.Show("güncelleme başarısız");
                }
            }
            listele();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            kitapmodel.isbn = datagridkitap.SelectedRows[0].Cells[0].Value.ToString();
            bool sonuc=kitapislemleri.kitapsil(kitapmodel.isbn);
            if (sonuc == true)
            {
                MessageBox.Show("kayıt başarıyla silindi");
            }
            else
            {
                MessageBox.Show("güncelleme başarısız");
            }

            listele();
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
         datagridkitap.DataSource=kitapislemleri.kitapara(txtara);   
        }

        private void btnyazar_Click(object sender, EventArgs e)
        {
            frmyykislem.Show();
            frmyykislem.lbltablo.Text = "Yazar Adı :";
            frmyykislem.lblbaslik.Text = "Yazar İşlem Sayfası";
            frmyykislem.datagridyyk.DataSource = yykislemleri.yyklistele("0");
        }

        private void btnyayinevi_Click(object sender, EventArgs e)
        {
            frmyykislem.Show();
            frmyykislem.lbltablo.Text = "Yayınevi Adı :";
            frmyykislem.lblbaslik.Text = "Yayınevi İşlem Sayfası";

            frmyykislem.datagridyyk.DataSource = yykislemleri.yyklistele("1");
        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            
            frmyykislem.Show();
            frmyykislem.lbltablo.Text = "Kategori Adı :";
            frmyykislem.lblbaslik.Text = "Kategori İşlem Sayfası";
            frmyykislem.datagridyyk.DataSource = yykislemleri.yyklistele("2");

        }

      

        private void datagridkitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtisbn.Text = datagridkitap.SelectedRows[0].Cells[0].Value.ToString();
            txtkitapadi.Text = datagridkitap.SelectedRows[0].Cells[1].Value.ToString();
            comboyazar.SelectedValue= datagridkitap.SelectedRows[0].Cells[11].Value.ToString();
            numericbaskiyili.Value = Convert.ToDecimal(datagridkitap.SelectedRows[0].Cells[3].Value);
            comboyayinevi.SelectedValue = datagridkitap.SelectedRows[0].Cells[12].Value.ToString();
            combokategori.SelectedValue = datagridkitap.SelectedRows[0].Cells[13].Value.ToString();
            numericstok.Value=Convert.ToDecimal(datagridkitap.SelectedRows[0].Cells[9].Value);

        }

        private void numericbaskiyili_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datagridkitap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

