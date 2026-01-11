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
    public partial class uyeListele : Form
    {
        kullanicilarSERVICE service = new kullanicilarSERVICE();
        public uyeListele()
        {
            InitializeComponent();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            List<kullanicilarDOMAIN> uyeler = service.TumUyeleriGetir();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = uyeler;
        }

        
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek üyeyi seçin");
                return;
            }

            int kullaniciId = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["Id"].Value
            );

            DialogResult sonuc = MessageBox.Show(
                "Seçilen üye silinsin mi?",
                "Onay",
                MessageBoxButtons.YesNo
            );

            if (sonuc == DialogResult.Yes)
            {
                service.KullaniciSil(kullaniciId);
                MessageBox.Show("Üye silindi");

                btnListele_Click(null, null);
            }
        }

        private void btnListele_Click_1(object sender, EventArgs e)
        {
            List<kullanicilarDOMAIN> uyeler = service.TumUyeleriGetir();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = uyeler;

        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek üyeyi seçin");
                return;
            }

            int kullaniciId = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["Id"].Value
            );

            DialogResult sonuc = MessageBox.Show(
                "Seçilen kullanıcı silinsin mi?",
                "Onay",
                MessageBoxButtons.YesNo
            );

            if (sonuc == DialogResult.Yes)
            {
                service.KullaniciSil(kullaniciId);
                MessageBox.Show("Kullanıcı silindi");

               
                btnListele_Click(null, null);
            }
        }

        private void uyeListele_Load(object sender, EventArgs e)
        {

        }
    }

}

