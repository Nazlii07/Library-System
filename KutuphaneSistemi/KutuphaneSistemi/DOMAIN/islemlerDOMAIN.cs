using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSistemi.DOMAIN
{
    public class islemlerDOMAIN
    {
        public int Id { get; set; }
        public int KitapId { get; set; }
        public int KullaniciId { get; set; }
        public string IslemTuru { get; set; }
        public DateTime IslemTarihi { get; set; }
        public DateTime? IadeTarihi { get; set; }
        public string Durum { get; set; }
        public class islemlerListeDOMAIN
        {
            public string UyeAdi { get; set; }
            public string KitapAdi { get; set; }
            public DateTime AlisTarihi { get; set; }
            public DateTime? TeslimTarihi { get; set; }
        }
    }
}
