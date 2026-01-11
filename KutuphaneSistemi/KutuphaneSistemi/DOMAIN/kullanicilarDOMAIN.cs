using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSistemi.DOMAIN
{
    public class kullanicilarDOMAIN
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; }
        public static int AktifKullaniciId { get; set; }
        public static string AktifKullaniciAdi { get; set; }
        public static string AktifRol { get; set; }
    }
}
