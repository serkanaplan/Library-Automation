using Baglantilar;
using Model;
using System;
using System.Windows.Forms;

namespace kotomasyon
{
    public partial class Frmyykislem : Form
    {
        public Frmyykislem()
        {
            InitializeComponent();
        }

        Yykislemleri yykislemleri = new Yykislemleri();
        Yazarmodel yazarmodel = new Yazarmodel();
        public void yyyklistele(string tablo)
        {
            datagridyyk.DataSource = yykislemleri.yyklistele(tablo);
        }

     

        private void Frmyykislem_Load(object sender, EventArgs e)
        {
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void datagridyyk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtyykdeger.Text = datagridyyk.SelectedRows[0].Cells[1].Value.ToString();
           
        }


        private void btnekle_Click(object sender, EventArgs e)
        {

            yazarmodel.ad_soyad = txtyykdeger.Text;

            if (Validasyon.validasyondogrula(yazarmodel))
            {
                if (lbltablo.Text == "Yazar Adı :")
                {
                    if (yykislemleri.yykvarmi(0, txtyykdeger.Text) == false && yykislemleri.yykekle(0, txtyykdeger.Text))
                    {
                        MessageBox.Show("kayıt eklendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        yyyklistele("0");

                    }
                    else
                    {
                        MessageBox.Show("Bu yazar zaten kayıtlı");
                    }
                }
                else if (lbltablo.Text == "Yayınevi Adı :")
                {

                    if (yykislemleri.yykvarmi(1, txtyykdeger.Text) == false && yykislemleri.yykekle(1, txtyykdeger.Text))
                    {
                        MessageBox.Show("kayıt eklendi");
                        yyyklistele("1");

                    }
                    else
                    {
                        MessageBox.Show("bu yayınevi zaten var");
                    }

                }
                else
                {
                    if (yykislemleri.yykvarmi(2, txtyykdeger.Text) == false && yykislemleri.yykekle(2, txtyykdeger.Text)
)
                    {
                        MessageBox.Show("kayıt eklendi");
                        yyyklistele("2");

                    }
                    else
                    {
                        MessageBox.Show("böyle bir kategori zaten var");
                    }
                }

            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            yazarmodel.id = datagridyyk.SelectedRows[0].Cells[0].Value.ToString();
            yazarmodel.ad_soyad = txtyykdeger.Text;
            if (Validasyon.validasyondogrula(yazarmodel))
            {
                if (lbltablo.Text == "Yazar Adı :")
                {
                    if (yykislemleri.yykguncelle(yazarmodel.id, txtyykdeger.Text, 0))
                    {
                        MessageBox.Show("kayıt başarıyla güncellendi");
                        yyyklistele("0");

                    }
                    else
                    {
                        MessageBox.Show("güncelleme başarısız");
                    }
                }
                else if (lbltablo.Text == "Yayınevi Adı :")
                {
                    if (yykislemleri.yykguncelle(yazarmodel.id, txtyykdeger.Text, 1))
                    {
                        MessageBox.Show("kayıt başarıyla güncellendi");
                        yyyklistele("1");

                    }
                    else
                    {
                        MessageBox.Show("güncelleme başarısız");
                    }
                }
                else
                {
                    if (yykislemleri.yykguncelle(yazarmodel.id, txtyykdeger.Text, 2))
                    {
                        MessageBox.Show("kayıt başarıyla güncellendi");
                        yyyklistele("2");

                    }
                    else
                    {
                        MessageBox.Show("güncelleme başarısız");
                    }
                }


            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            yazarmodel.id = datagridyyk.SelectedRows[0].Cells[0].Value.ToString();

            if (lbltablo.Text == "Yazar Adı :")
            {
                if (yykislemleri.yyksil(0, yazarmodel.id))
                {
                    MessageBox.Show("kayıt başarıyla silindi");
                    yyyklistele("0");
                }
                else
                {
                    MessageBox.Show("hata! kayıt silinemedi");
                }
            }
            else if (lbltablo.Text == "Yayınevi Adı :")
            {
                if (yykislemleri.yyksil(1, yazarmodel.id))
                {
                    MessageBox.Show("kayıt başarıyla silindi");
                    yyyklistele("1");

                }
                else
                {
                    MessageBox.Show("Hata! jayıt silinemedi");
                }
            }
            else
            {
                if (yykislemleri.yyksil(2, yazarmodel.id))
                {
                    MessageBox.Show("kayıt başarıyla silindi");
                    yyyklistele("2");

                }
                else
                {
                    MessageBox.Show("Hata! kayıt silinemedi");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
