using Baglantilar;
using Model;
using System;
using System.Windows.Forms;

namespace kotomasyon
{
    public partial class Frmsifredegistir : Form
    {
        public Frmsifredegistir()
        {
            InitializeComponent();
        }

        Girisislemleri girisislemleri = new Girisislemleri();
        Girismodel girismodel = new Girismodel();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frmsifredegistir_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            girismodel.mail = txtmail.Text;
            girismodel.sifre = txteskisifre.Text;
            if (Validasyon.validasyondogrula(girismodel) == true)
            {
                if (string.IsNullOrEmpty(txtyenisifre.Text)==false && string.IsNullOrEmpty(txtyenisifretkrr.Text)==false)
                {
                    if (txtyenisifre.Text == txtyenisifretkrr.Text)
                    {
                        if (girisislemleri.kullanicivarmı(txtmail.Text, txteskisifre.Text) != null)
                        {
                            girisislemleri.sifredegistir(txtmail.Text, txtyenisifre.Text);
                            MessageBox.Show("şifre başarıyla değiştirildi");

                        }
                        else
                        {
                            MessageBox.Show("mail hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("şifreler uyuşmuyor");
                    }
                }
                else
                {
                    MessageBox.Show("Alan boş bırakılamaz!");
                }
              

            }
                        

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    } 
}
