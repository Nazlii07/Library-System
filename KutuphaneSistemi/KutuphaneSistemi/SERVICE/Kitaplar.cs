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
    public partial class Kitaplar : Form
    {
        public Kitaplar()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            kitaplarDOMAIN kitap = new kitaplarDOMAIN();

            kitap.KitapAd = txtKitapAdi.Text;
            kitap.Yazar = txtYazar.Text;
            kitap.Tur = txtTur.Text;
            kitap.SayfaSayisi = Convert.ToInt32(txtSayfaSayisi.Text);
            kitap.StokAdedi = Convert.ToInt32(txtStokAdeti.Text);

            kitaplarSERVICE service = new kitaplarSERVICE();
            service.KitapKaydet(kitap);

            MessageBox.Show("Kitap başarıyla kaydedildi ✅");

            
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtTur.Clear();
            txtSayfaSayisi.Clear();
            txtStokAdeti.Clear();
        }
    }
}
