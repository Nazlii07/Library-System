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
    public partial class anaMenu : Form
    {
        public anaMenu()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login frmLogin = new login();

            frmLogin.Show();

            this.Close();
        }

        

      

        private void btnEkle_Click(object sender, EventArgs e)
        {

            Kitaplar frm = new Kitaplar();
            frm.Show();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            kitapListele frm = new kitapListele();
            frm.Show();

        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            uyeEkle uyeEkle = new uyeEkle();
            uyeEkle.Show();
        }

        private void btnUyeListeleme_Click(object sender, EventArgs e)
        {
            uyeListele frm = new uyeListele();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oduncİslemleri frm = new oduncİslemleri();
            frm.ShowDialog(); 
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            raporlar frm = new raporlar();
            frm.Show();
        }

        private void anaMenu_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Aktif Rol: " + kullanicilarDOMAIN.AktifRol);

            if (kullanicilarDOMAIN.AktifRol != "Admin")
            {
                btnRapor.Enabled = false;
                btnUyeListeleme.Enabled = false;
                btnUyeEkle.Enabled = false;
                btnEkle.Enabled = false;
            }
        }
    }
}
