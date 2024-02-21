using System;
using System.Windows.Forms;

namespace kotomasyon
{
    public partial class Frmyonetici : Form
    {
        Frmgiris frmgiris = new Frmgiris();
        public Frmyonetici()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmgiris.Show();

        }

        private void btnkullanici(object sender, EventArgs e)
        {
            Frmkullaniciislem frmkullaniciislem = new Frmkullaniciislem();
            frmkullaniciislem.Show();
        }

        private void btnkitap(object sender, EventArgs e)
        {
            Frmkitapislem frmkitapislem =new Frmkitapislem();
            frmkitapislem.lblmail.Text = lblkullaniciadi.Text;
            frmkitapislem.Show();
        }

        private void btnodunciade(object sender, EventArgs e)
        {
            Frmislem frmislem=new Frmislem();
            frmislem.Show();
            frmislem.lblkullaniciadi.Text = lblkullaniciadi.Text;
            frmislem.lblborc.Text=lblborc.Text;
            frmislem.lbltarih.Text=lbltarih.Text;
            this.Hide();
        }

        private void btnodunclistele(object sender, EventArgs e)
        {
            Frmodunclistele frmodunclistele= new Frmodunclistele();
            frmodunclistele.Show();
        }

        private void Frmyonetici_Load(object sender, EventArgs e)
        {

        }
    }
}
