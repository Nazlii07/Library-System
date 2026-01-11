using KutuphaneSistemi.DAO;
using KutuphaneSistemi.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KutuphaneSistemi.DOMAIN.islemlerDOMAIN;

namespace KutuphaneSistemi.SERVICE
{
    public class islemlerSERVICE
    {
        islemlerDAO dao = new islemlerDAO();

        public List<islemlerDOMAIN> TumIslemleriGetir()
        {
            return dao.TumIslemleriGetir();
        }

        public void OduncVer(islemlerDOMAIN islem)
        {
            dao.OduncVer(islem);
        }

        public void IadeAl(int kullaniciId, int kitapId, DateTime iadeTarihi)
        {
            dao.IadeAlByUyeKitap(kullaniciId, kitapId, iadeTarihi);
        }
        public List<islemlerListeDOMAIN> OduncListele()
        {
            return dao.OduncListele();
        }
    }
}
