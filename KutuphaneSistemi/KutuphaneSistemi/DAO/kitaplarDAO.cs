using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneSistemi.DOMAIN;

namespace KutuphaneSistemi.DAO
{
    public class kitaplarDAO
    {
        string baglantiCumlesi = "Server=172.21.54.253; Database=26_132430039; User=26_132430039; Password=İnif123.";

        public List<kitaplarDOMAIN> TumKitaplariGetir()
        {
            List<kitaplarDOMAIN> kitaplar = new List<kitaplarDOMAIN>();
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sorgu = "SELECT * FROM Kitaplar";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                baglanti.Open();
                using (MySqlDataReader oku = komut.ExecuteReader())
                {
                    while (oku.Read())
                    {
                        kitaplar.Add(new kitaplarDOMAIN
                        {
                            Id = (int)oku["id"],
                            KitapAd = oku["kitap_ad"].ToString(),
                            Yazar = oku["yazar"].ToString(),
                            Tur = oku["tur"].ToString(),
                            SayfaSayisi = (int)oku["sayfa_sayisi"],
                            StokAdedi = (int)oku["stok_adeti"]
                        });
                    }
                }
            }
            return kitaplar;
        }

            public void KitapEkle(kitaplarDOMAIN kitap)
            { 
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sorgu = @"INSERT INTO Kitaplar 
                (kitap_ad, yazar, tur, sayfa_sayisi, stok_adeti)
                VALUES (@adi, @yazar, @tur, @sayfa, @stok)";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@adi", kitap.KitapAd);
                komut.Parameters.AddWithValue("@yazar", kitap.Yazar);
                komut.Parameters.AddWithValue("@tur", kitap.Tur);
                komut.Parameters.AddWithValue("@sayfa", kitap.SayfaSayisi);
                komut.Parameters.AddWithValue("@stok", kitap.StokAdedi);

                baglanti.Open();
                komut.ExecuteNonQuery();
            }
        }
        public void KitapSil(int id)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                
                string sorgu = "DELETE FROM Kitaplar WHERE id = @id";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@id", id);

                baglanti.Open();
                int etkilenenSatir = komut.ExecuteNonQuery(); 

                if (etkilenenSatir == 0)
                {
                    throw new Exception("Veritabanında bu ID'ye sahip bir kitap bulunamadı.");
                }
            }
        }
        public List<kitaplarDOMAIN> KitaplariGetir()
        {
            List<kitaplarDOMAIN> kitaplar = new List<kitaplarDOMAIN>();

            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sorgu = "SELECT * FROM Kitaplar";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                baglanti.Open();

                using (MySqlDataReader oku = komut.ExecuteReader())
                {
                    while (oku.Read())
                    {
                        kitaplar.Add(new kitaplarDOMAIN
                        {
                            Id = Convert.ToInt32(oku["id"]),
                            KitapAd = oku["kitap_ad"].ToString(),
                            Yazar = oku["yazar"].ToString(),
                            Tur = oku["tur"].ToString(),
                            SayfaSayisi = Convert.ToInt32(oku["sayfa_sayisi"]),
                            StokAdedi = Convert.ToInt32(oku["stok_adedi"])
                        });
                    }
                }
            }
            return kitaplar;
        }

        
        public void kitapSil(int kitapId)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sorgu = "DELETE FROM Kitaplar WHERE id=@id";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@id", kitapId);

                baglanti.Open();
                komut.ExecuteNonQuery();
            }
        }
    }
}

    

