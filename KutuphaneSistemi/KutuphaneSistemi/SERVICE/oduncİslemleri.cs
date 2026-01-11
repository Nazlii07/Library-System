using KutuphaneSistemi.DAO;
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
    public partial class oduncİslemleri : Form
    {
        public oduncİslemleri()
        {
            InitializeComponent();
        }

        private void btnIadeAl_Click(object sender, EventArgs e)
        {
            try
            {
                int uyeId = Convert.ToInt32(cmbUye.SelectedValue);
                int kitapId = Convert.ToInt32(cmbKitap.SelectedValue);
                DateTime iadeTarihi = dtpTeslim.Value;

                islemlerSERVICE service = new islemlerSERVICE();
                service.IadeAl(uyeId, kitapId, iadeTarihi);

                MessageBox.Show("Kitap başarıyla iade alındı ✅");
            }
            catch (Exception ex)
            {
                MessageBox.Show("İade hatası: " + ex.Message);
            }
        }

        private void btnTabloyaGit_Click(object sender, EventArgs e)
        {
            oduncListesi frm = new oduncListesi();
            frm.Show(); 
        }

        private void oduncİslemleri_Load(object sender, EventArgs e)
        {
            kullanicilarDAO uDao = new kullanicilarDAO();
            cmbUye.DataSource = uDao.TumKullanicilariGetir();
            cmbUye.DisplayMember = "Ad"; 
            cmbUye.ValueMember = "Id";  

            kitaplarDAO kDao = new kitaplarDAO();
            cmbKitap.DataSource = kDao.TumKitaplariGetir();
            cmbKitap.DisplayMember = "KitapAd";
            cmbKitap.ValueMember = "Id";
        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            islemlerSERVICE service = new islemlerSERVICE();

            islemlerDOMAIN islem = new islemlerDOMAIN
            {
                KullaniciId = Convert.ToInt32(cmbUye.SelectedValue),
                KitapId = Convert.ToInt32(cmbKitap.SelectedValue),
                IslemTuru = "Odunc",
                IslemTarihi = dtpVerilis.Value,
                Durum = "Devam"
            };

            service.OduncVer(islem);
            MessageBox.Show("Kitap ödünç verildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }

