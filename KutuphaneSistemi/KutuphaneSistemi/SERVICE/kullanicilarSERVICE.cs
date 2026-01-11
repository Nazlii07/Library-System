using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneSistemi.DAO;
using KutuphaneSistemi.DOMAIN;

namespace KutuphaneSistemi.SERVICE
{
    public class kullanicilarSERVICE
    {
        kullanicilarDAO dao = new kullanicilarDAO();

        
        public void KayitOl(kullanicilarDOMAIN yeniKullanici)
        {
            dao.KullaniciEkle(yeniKullanici);
        }
      
        public void TestKullanicilar()
        {
            var liste = dao.TumKullanicilariGetir();
            foreach (var k in liste)
            {
                Console.WriteLine($"KADI: '{k.KullaniciAdi}' | SIFRE: '{k.Sifre}'");
            }
        }
        public kullanicilarDOMAIN GirisYap(string kullaniciAdi, string sifre)
        {
            List<kullanicilarDOMAIN> tumKullanicilar = dao.TumKullanicilariGetir();

            return tumKullanicilar.FirstOrDefault(k =>
                k.KullaniciAdi.Trim() == kullaniciAdi.Trim() &&
                k.Sifre.Trim() == sifre.Trim()
            );
        }
        public void YeniUyeKaydet(kullanicilarDOMAIN kullanici)
        {
            kullanicilarDAO dao = new kullanicilarDAO();
            dao.uyeEkle(kullanici);
        }

       

        public List<kullanicilarDOMAIN> TumUyeleriGetir()
        {
            return dao.TumKullanicilariGetir();
        }

        public void KullaniciSil(int kullaniciId)
        {
            dao.KullaniciSil(kullaniciId);
        }



    }
}
