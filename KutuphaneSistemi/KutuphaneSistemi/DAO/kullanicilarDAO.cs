using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneSistemi.DOMAIN;

namespace KutuphaneSistemi.DAO
{
    public class kullanicilarDAO
    {
        string baglantiCumlesi = "Server=172.21.54.253;Database=26_132430039;User=26_132430039;Password=İnif123.;Pooling=False";

        public List<kullanicilarDOMAIN> TumKullanicilariGetir()
        {
            List<kullanicilarDOMAIN> kullanicilar = new List<kullanicilarDOMAIN>();

            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))

            {
                string sorgu = "SELECT * FROM Kullanicilar";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                baglanti.Open();

                using (MySqlDataReader oku = komut.ExecuteReader())
                {
                    while (oku.Read())
                    {
                        kullanicilar.Add(new kullanicilarDOMAIN
                        {
                            Id = Convert.ToInt32(oku["id"]),
                            Ad = oku["ad"].ToString(),
                            Soyad = oku["soyad"].ToString(),
                            Eposta = oku["eposta"].ToString(),
                            KullaniciAdi = oku["kullanici_adi"].ToString(),
                            Sifre = oku["sifre"].ToString(),
                            Rol = oku["rol"].ToString()
                        });
                        Console.WriteLine(
    oku["kullanici_adi"].ToString() + " - " + oku["sifre"].ToString()
);

                    }
                }
            }
            return kullanicilar;
        }
        public void KullaniciEkle(kullanicilarDOMAIN kullanici)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sorgu = @"INSERT INTO Kullanicilar 
        (ad, soyad, eposta, kullanici_adi, sifre)
        VALUES (@ad, @soyad, @eposta, @kadi, @sifre)";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@ad", kullanici.Ad);
                komut.Parameters.AddWithValue("@soyad", kullanici.Soyad);
                komut.Parameters.AddWithValue("@eposta", kullanici.Eposta);
                komut.Parameters.AddWithValue("@kadi", kullanici.KullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", kullanici.Sifre);
 
                baglanti.Open();
                komut.ExecuteNonQuery();
            }
        }
        
        public kullanicilarDOMAIN GirisYap(string kadi, string sifre)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sql = @"SELECT * FROM Kullanicilar 
                       WHERE kullanici_adi = @kadi 
                       AND sifre = @sifre";

                MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("@kadi", kadi);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                baglanti.Open();
                MySqlDataReader oku = cmd.ExecuteReader();

                if (oku.Read())
                {
                    return new kullanicilarDOMAIN
                    {
                        Id = Convert.ToInt32(oku["id"]),
                        Ad = oku["ad"].ToString(),
                        KullaniciAdi = oku["kullanici_adi"].ToString(),
                        Sifre = oku["sifre"].ToString(),
                        Rol = oku["rol"].ToString()
                    };
                }
            }
            return null;
        }

        public void uyeEkle(kullanicilarDOMAIN kullanici)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                
                string sorgu = "INSERT INTO Kullanicilar (ad, soyad, kullanici_adi, sifre, eposta) " +
                               "VALUES (@ad, @soyad, @kAdi, @sifre, @eposta)";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ad", kullanici.Ad);
                komut.Parameters.AddWithValue("@soyad", kullanici.Soyad);
                komut.Parameters.AddWithValue("@kAdi", kullanici.KullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", kullanici.Sifre);
                komut.Parameters.AddWithValue("@eposta", kullanici.Eposta);

                baglanti.Open();
                komut.ExecuteNonQuery();
            }
        }
        public void KullaniciSil(int kullaniciId)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sorgu = "DELETE FROM Kullanicilar WHERE id=@id";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@id", kullaniciId);

                baglanti.Open();
                komut.ExecuteNonQuery();

            }
        }


    }

}


