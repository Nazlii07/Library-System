using KutuphaneSistemi.DAO;
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
    public partial class kitapListele : Form
    {
        public kitapListele()
        {
            InitializeComponent();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            try
            {
               
                kitaplarDAO dao = new kitaplarDAO();

              
                var kitapListesi = dao.TumKitaplariGetir();

              
                dgvKitaplar.DataSource = null;

                dgvKitaplar.DataSource = kitapListesi;



                dgvKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme sırasında hata oluştu: " + ex.Message);
            }
        }

        private void dgvKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kitapListele_Load(object sender, EventArgs e)
        {
            btnYenile_Click(sender, e);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.CurrentRow != null)
            {
              
                int seciliId = Convert.ToInt32(dgvKitaplar.CurrentRow.Cells["Id"].Value);

                try
                {
                    kitaplarDAO dao = new kitaplarDAO();
                    dao.KitapSil(seciliId);

                    MessageBox.Show("Kitap başarıyla silindi ✅");

                    
                    btnYenile_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message);
                }
            }
        }
       
    }
}
