using KutuphaneSistemi.DOMAIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneSistemi.SERVICE
{
    public partial class kullaniciOlusturma : Form
    {
        public kullaniciOlusturma()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            kullanicilarSERVICE service = new kullanicilarSERVICE();

            kullanicilarDOMAIN yeniKullanici = new kullanicilarDOMAIN()
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Eposta = txtEposta.Text,
                KullaniciAdi = txtKullaniciadi.Text,
                Sifre = txtSifre.Text
            };

            service.KayitOl(yeniKullanici);

            MessageBox.Show("Kayıt başarılı 🎉");

            login frm = new login();
            frm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login frm = new login ();
            frm.Show();
            this.Hide();
        }
    }
}
