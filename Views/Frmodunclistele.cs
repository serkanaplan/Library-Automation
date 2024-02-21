using Controller;
using System;
using System.Windows.Forms;

namespace kotomasyon
{
    public partial class Frmodunclistele : Form
    {
        Odunclistele odunclistele=new Odunclistele();
        public Frmodunclistele()
        {
            InitializeComponent();
        }
        public void listele()
        {
            datagridodunc.DataSource = odunclistele.islemlistele(txtara.Text);
            datagridodunc.Columns["kitap_adi"].HeaderText = "Kitap adı";
            datagridodunc.Columns["ad_soyad"].HeaderText = "Yazar";
            datagridodunc.Columns["islem_tarihi"].HeaderText = "işlem tarihi";
            datagridodunc.Columns["islem_durumu"].HeaderText = "Durum";
            datagridodunc.Columns["sure_uzatma_sayisi"].HeaderText = "Süre uzatma s.";





        }
        private void Frmodunclistele_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void txtara_TextChanged(object sender, EventArgs e)
        {
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
                odunclistele.islemguncelle(Convert.ToInt32(datagridodunc.SelectedRows[0].Cells[8].Value),radioodunc.Checked);

            
        }

        private void datagridodunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Convert.ToBoolean(datagridodunc.SelectedRows[0].Cells[6].Value)==true)
            {
                radioodunc.Checked = true;
            }
            else
            {
                radioiade.Checked = true;

            }
        }

        private void datagridodunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
