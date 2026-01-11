using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneSistemi.DAO;
using KutuphaneSistemi.DOMAIN;

namespace KutuphaneSistemi.SERVICE
{
    public class kitaplarSERVICE
    {
        kitaplarDAO dao = new kitaplarDAO();

        public void KitapKaydet(kitaplarDOMAIN kitap)
        {
            dao.KitapEkle(kitap);
        }
        public List<kitaplarDOMAIN> KitaplariGetir()
        {
            return dao.KitaplariGetir();
        }

        public void KitapSil(int kitapId)
        {
            dao.kitapSil(kitapId);
        }
    }

}
