using KutuphaneSistemi.DAO;
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
    public partial class raporlar : Form
    {
        public raporlar()
        {
            InitializeComponent();
        }

        private void raporlar_Load(object sender, EventArgs e)
        {
            islemlerDAO dao = new islemlerDAO();

            gbToplamKitap.Text = "Toplam Kitap Sayısı : " + dao.ToplamKitapSayisi();
            gbToplamUye.Text = "Toplam Üye Sayısı : " + dao.ToplamUyeSayisi();
            gbEmanet.Text = "Emanetteki Kitap Sayısı : " + dao.EmanettekiKitapSayisi();
            gbGeciken.Text = "Geciken Kitap Sayısı : " + dao.GecikenKitapSayisi();
        }
    }
}
