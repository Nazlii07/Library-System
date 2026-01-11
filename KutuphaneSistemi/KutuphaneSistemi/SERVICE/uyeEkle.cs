using KutuphaneSistemi.DOMAIN;
using MySql.Data.MySqlClient;
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
    public partial class uyeEkle : Form
    {
        public uyeEkle()
        {
            InitializeComponent();
        }

        private void uyeEkle_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtAd.Text == "" || txtSoyad.Text == "" || txtKullanici.Text == "")
                {
                    MessageBox.Show("Lütfen zorunlu alanları doldurun!");
                    return;
                }

                kullanicilarDOMAIN yeniUye = new kullanicilarDOMAIN();
               
                yeniUye.Ad = txtAd.Text.Trim();
                yeniUye.Soyad = txtSoyad.Text.Trim();
                yeniUye.KullaniciAdi = txtKullanici.Text.Trim();
                yeniUye.Sifre = txtSifre.Text.Trim();
                yeniUye.Eposta = txtEposta.Text.Trim();

                kullanicilarSERVICE service = new kullanicilarSERVICE();
                service.YeniUyeKaydet(yeniUye);

                MessageBox.Show("Yeni üye başarıyla eklendi! ✅");

               
                txtAd.Clear();
                txtSoyad.Clear();
                txtKullanici.Clear();
                txtSifre.Clear();
                txtEposta.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
