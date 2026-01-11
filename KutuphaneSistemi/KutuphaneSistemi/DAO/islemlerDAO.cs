using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneSistemi.DOMAIN;
using MySql.Data.MySqlClient;
using static KutuphaneSistemi.DOMAIN.islemlerDOMAIN;

namespace KutuphaneSistemi.DAO
{
    public class islemlerDAO
    {
        string baglantiCumlesi = "Server=172.21.54.253; Database=26_132430039; User=26_132430039; Password=İnif123.";

        public List<islemlerDOMAIN> TumIslemleriGetir()
        {
            List<islemlerDOMAIN> islemler = new List<islemlerDOMAIN>();

            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sorgu = "SELECT * FROM Islemler";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                baglanti.Open();

                using (MySqlDataReader oku = komut.ExecuteReader())
                {
                    while (oku.Read())
                    {
                        islemler.Add(new islemlerDOMAIN
                        {
                            Id = Convert.ToInt32(oku["id"]),
                            KitapId = Convert.ToInt32(oku["kitap_id"]),
                            KullaniciId = Convert.ToInt32(oku["kullanici_id"]),
                            IslemTuru = oku["islem_turu"].ToString(),
                            IslemTarihi = Convert.ToDateTime(oku["islem_tarihi"]),
                            IadeTarihi = oku["iade_tarihi"] == DBNull.Value
    ? (DateTime?)null
    : Convert.ToDateTime(oku["iade_tarihi"]),
                            Durum = oku["durum"].ToString()
                        });
                    }
                }
            }
            return islemler;
        }
        public void OduncVer(islemlerDOMAIN islem)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sorgu = @"INSERT INTO Islemler
                (kitap_id, kullanici_id, islem_turu, islem_tarihi, durum)
                VALUES (@kitapId, @kullaniciId, @islemTuru, @islemTarihi, @durum)";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kitapId", islem.KitapId);
                komut.Parameters.AddWithValue("@kullaniciId", islem.KullaniciId);
                komut.Parameters.AddWithValue("@islemTuru", islem.IslemTuru);
                komut.Parameters.AddWithValue("@islemTarihi", islem.IslemTarihi);
                komut.Parameters.AddWithValue("@durum", islem.Durum);

                baglanti.Open();
                komut.ExecuteNonQuery();
            }
        }

        public void IadeAl(int islemId, DateTime iadeTarihi)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sorgu = @"UPDATE Islemler 
                                 SET iade_tarihi = @iadeTarihi,
                                     durum = 'Tamamlandı'
                                 WHERE id = @id";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@iadeTarihi", iadeTarihi);
                komut.Parameters.AddWithValue("@id", islemId);

                baglanti.Open();
                komut.ExecuteNonQuery();
            }
        }
        public List<islemlerListeDOMAIN> OduncListele()
        {
            List<islemlerListeDOMAIN> liste = new List<islemlerListeDOMAIN>();

            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sorgu = @"
        SELECT 
            k.Ad AS UyeAdi,
            kt.kitap_ad  AS KitapAdi,
            i.islem_tarihi,
            i.iade_tarihi
        FROM Islemler i
        JOIN Kullanicilar k ON i.kullanici_id = k.Id
        JOIN Kitaplar kt ON i.kitap_id = kt.Id
        WHERE i.islem_turu = 'Odunc'";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                baglanti.Open();

                using (MySqlDataReader oku = komut.ExecuteReader())
                {
                    while (oku.Read())
                    {
                        liste.Add(new islemlerListeDOMAIN
                        {
                            UyeAdi = oku["UyeAdi"].ToString(),
                            KitapAdi = oku["KitapAdi"].ToString(),
                            AlisTarihi = Convert.ToDateTime(oku["islem_tarihi"]),
                            TeslimTarihi = oku["iade_tarihi"] == DBNull.Value
                                ? (DateTime?)null
                                : Convert.ToDateTime(oku["iade_tarihi"])
                        });
                    }
                }
            }
            return liste;
        }
        public void IadeAlByUyeKitap(int kullaniciId, int kitapId, DateTime iadeTarihi)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sorgu = @"
        UPDATE Islemler
        SET iade_tarihi = @iadeTarihi,
            durum = 'Tamamlandı'
        WHERE kullanici_id = @kullaniciId
          AND kitap_id = @kitapId
          AND durum = 'Devam'";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@iadeTarihi", iadeTarihi);
                komut.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                komut.Parameters.AddWithValue("@kitapId", kitapId);

                baglanti.Open();
                komut.ExecuteNonQuery();
            }
        }
        public int ToplamKitapSayisi()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sorgu = "SELECT COUNT(*) FROM Kitaplar";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                baglanti.Open();
                return Convert.ToInt32(komut.ExecuteScalar());
            }
        }
        public int ToplamUyeSayisi()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sorgu = "SELECT COUNT(*) FROM Kullanicilar";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                baglanti.Open();
                return Convert.ToInt32(komut.ExecuteScalar());
            }
        }
        public int EmanettekiKitapSayisi()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sorgu = "SELECT COUNT(*) FROM Islemler WHERE durum = 'Devam'";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                baglanti.Open();
                return Convert.ToInt32(komut.ExecuteScalar());
            }
        }
        public int GecikenKitapSayisi()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sorgu = @"
            SELECT COUNT(*) 
            FROM Islemler 
            WHERE durum = 'Devam'
            AND iade_tarihi < CURDATE()";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                baglanti.Open();
                return Convert.ToInt32(komut.ExecuteScalar());
            }
        }

    }
}

