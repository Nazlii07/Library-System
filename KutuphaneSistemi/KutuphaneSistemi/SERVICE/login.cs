using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneSistemi.SERVICE;
using KutuphaneSistemi.DOMAIN;
using MySqlX.XDevAPI;

namespace KutuphaneSistemi.SERVICE
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void kullanicAdiTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            
            string kullaniciAdi = kullaniciBox.Text.Trim();
            string sifre = girisYapTB.Text.Trim();

            kullanicilarSERVICE service = new kullanicilarSERVICE();
            kullanicilarDOMAIN kullanici = service.GirisYap(kullaniciAdi, sifre);

            if (kullanici != null)
            {
                kullanicilarDOMAIN.AktifKullaniciId = kullanici.Id;
                kullanicilarDOMAIN.AktifKullaniciAdi = kullanici.KullaniciAdi;
                kullanicilarDOMAIN.AktifRol = kullanici.Rol;

                anaMenu frmAna = new anaMenu();
                frmAna.Show();
                this.Hide();
            }
            else
            {
                
                MessageBox.Show($"Kullanıcı adı veya şifre yanlış!\n" +
                                $"Denene Ad: '{kullaniciAdi}'\n" +
                                $"Denene Şifre: '{sifre}'");
            }

            
        }

        private void login_Load(object sender, EventArgs e)
        {
            kullanicilarSERVICE service = new kullanicilarSERVICE();
            service.TestKullanicilar();

        }

        private void üyeDeğilmisiniz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kullaniciOlusturma frm = new kullaniciOlusturma();
            frm.Show();
            this.Hide();
        }
      

    }
}
