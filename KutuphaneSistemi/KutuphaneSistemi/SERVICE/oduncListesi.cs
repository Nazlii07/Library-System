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
    public partial class oduncListesi : Form
    {
        public oduncListesi()
        {
            InitializeComponent();
        }

        private void oduncListesi_Load(object sender, EventArgs e)
        {
            islemlerSERVICE service = new islemlerSERVICE();

            dgvIslemler.DataSource = service.OduncListele();

            dgvIslemler.ReadOnly = true;
            dgvIslemler.AllowUserToAddRows = false;
            dgvIslemler.AllowUserToDeleteRows = false;
            dgvIslemler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIslemler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvIslemler.Columns["UyeAdi"].HeaderText = "Üye Adı";
            dgvIslemler.Columns["KitapAdi"].HeaderText = "Kitap Adı";
            dgvIslemler.Columns["AlisTarihi"].HeaderText = "Alış Tarihi";
            dgvIslemler.Columns["TeslimTarihi"].HeaderText = "Teslim Tarihi";
        }
    }
}
