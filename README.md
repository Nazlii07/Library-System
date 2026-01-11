# Library-System
📚 Kütüphane Yönetim Sistemi

Kütüphane işlemlerini kolaylaştırmak amacıyla geliştirilmiş bir masaüstü otomasyon uygulamasıdır.
Bu proje sayesinde kütüphane görevlileri kitapları, üyeleri, ödünç alma–iade işlemlerini ve raporları tek bir sistem üzerinden yönetebilir.

📌 Proje Özellikleri

*Giriş Sistemi
Kullanıcı adı ve şifre ile giriş yapılır. Kullanıcı rolüne (Admin / Kullanıcı) göre yetkilendirme uygulanır.

*Kitap İşlemleri
Kitap ekleme, silme, güncelleme ve listeleme işlemleri yapılabilir.

*Üye İşlemleri
Üye ekleme, silme ve üye listesini görüntüleme.

*Ödünç Alma & İade İşlemleri
Kitapların ödünç verilmesi ve iade alınması işlemleri gerçekleştirilir.

*Ödünç Listeleme
Hangi üyenin hangi kitabı ne zaman aldığı ve teslim durumu listelenir.

*Raporlar

-Toplam kitap sayısı

-Toplam üye sayısı

-Emanetteki kitap sayısı

-Geciken kitaplar

*Yetkilendirme Sistemi
Bazı işlemler sadece admin, bazı işlemler normal kullanıcılar tarafından yapılabilir.

📂 Kullanılan Teknolojiler

*C# (.NET Framework)

*Windows Forms

*MySQL

*N Katmanlı Mimari

  -Domain

  -DAO

  -Service

  -UI (Forms)

🧱 Mimari Yapı (N Katmanlı)
🔹 Domain Katmanı

Bu katmanda veritabanındaki tabloların C# karşılıkları bulunur.
Kitap, kullanıcı ve işlem gibi nesnelerin sadece özellikleri tanımlanmıştır.
Ayrıca aktif giriş yapan kullanıcının bilgileri de burada tutulur.

🔹 DAO (Data Access Object) Katmanı

Veritabanı ile ilgili tüm SQL işlemleri bu katmanda yapılır.
Select, Insert, Update, Delete sorguları burada yazılmıştır.
Formlar veritabanına doğrudan bağlanmaz.

🔹 Service Katmanı

Formlardan gelen istekleri alır ve DAO ile UI arasında köprü görevi görür.
Formlar doğrudan DAO’ya erişmez, işlemleri Service üzerinden yapar.

🔹 UI (Forms)

Kullanıcının gördüğü ekranlardır.
Butonlar, tablolar ve formlar bu katmanda yer alır.
Formlar sadece Service katmanını kullanır.

📸 Ekran Görüntüleri
*Giriş Ekranı

<img width="743" height="511" alt="Ekran görüntüsü 2026-01-11 214535" src="https://github.com/user-attachments/assets/3efa9f47-7bfb-4ef2-8d2d-4975e74f4dec" />

Kullanıcı adı ve şifre ile sisteme giriş yapılır.
Kullanıcının rolüne göre yetkiler belirlenir.

*Ana Menü

<img width="788" height="532" alt="Ekran görüntüsü 2026-01-11 214609" src="https://github.com/user-attachments/assets/63fa14e8-3406-4f73-87c0-b934e24654e5" />

Sistemin tüm işlemlerine erişim sağlanan ana kontrol ekranıdır.

*Kitap İşlemleri

<img width="735" height="526" alt="Ekran görüntüsü 2026-01-11 214647" src="https://github.com/user-attachments/assets/47f3c2fc-c6b6-4675-802f-741d69b006b1" />
<img width="739" height="450" alt="Ekran görüntüsü 2026-01-11 214700" src="https://github.com/user-attachments/assets/edb36115-c7b4-4d7e-a8a7-ec18d2bb4358" />

Kitap ekleme, silme ve listeleme işlemleri yapılır.

*Üye İşlemleri

<img width="742" height="493" alt="Ekran görüntüsü 2026-01-11 214708" src="https://github.com/user-attachments/assets/a6e4f66f-0976-47c1-8d0d-74f12c738854" />
<img width="734" height="452" alt="Ekran görüntüsü 2026-01-11 214721" src="https://github.com/user-attachments/assets/4488d352-0456-47fe-a0a7-3e055104c312" />

Kütüphaneye kayıtlı üyeler bu ekranda yönetilir.

*Ödünç Alma & İade

<img width="736" height="493" alt="Ekran görüntüsü 2026-01-11 214731" src="https://github.com/user-attachments/assets/1b117e33-5f4c-4d78-9c37-7120d8940d9e" />
<img width="739" height="443" alt="Ekran görüntüsü 2026-01-11 214747" src="https://github.com/user-attachments/assets/55802fca-a236-4633-9b77-93a698864577" />

Kitapların ödünç verilmesi ve geri alınması işlemleri yapılır.

*Raporlar

<img width="739" height="502" alt="Ekran görüntüsü 2026-01-11 214756" src="https://github.com/user-attachments/assets/7402af1b-db5f-41fc-bdb6-d844acf4118d" />

Sisteme ait genel istatistikler görüntülenir.

🚀 Kullanım

-Projeyi indirin veya klonlayın.

-Visual Studio ile projeyi açın.

-MySQL veritabanı bağlantı bilgilerini DAO sınıflarındaki connection string üzerinden düzenleyin.

-Veritabanını oluşturup tabloları ekleyin.

-Uygulamayı çalıştırarak giriş yapın.

🎯 Proje Amaçları

-Kütüphane işlemlerini dijital ortama taşımak

-İşlemleri daha hızlı ve düzenli hale getirmek

-Yetkilendirme ile güvenli kullanım sağlamak

-N katmanlı mimariyi öğrenmek ve uygulamak

📞 İletişim

Ad Soyad: Zehra Nazlı Gökmen

E-posta: ben.zehranazli07@gmail.com

▶ YouTube Video

Proje tanıtım videosunu izlemek için:
📺 https://youtu.be/W0l1O9c1fZM
