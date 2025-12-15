# 🏫 Okul Yönetim Sistemi (MVC)

Bu proje, **ASP.NET MVC 5** mimarisi kullanılarak geliştirilmiş kapsamlı bir okul yönetim otomasyonudur. Entity Framework altyapısı ile veritabanı işlemlerini yönetir ve Bootstrap kütüphanesi ile responsive (mobil uyumlu) bir arayüz sunar.

## 🚀 Proje Hakkında

Okul Yönetim Sistemi; öğrenci kayıtları, ders programları, kulüp faaliyetleri ve sınav notlarının tek bir merkezden yönetilmesini sağlar. Yönetici paneli üzerinden tüm CRUD (Ekleme, Okuma, Güncelleme, Silme) işlemleri kolaylıkla gerçekleştirilebilir.

## 📋 Özellikler

Proje aşağıdaki temel modülleri içerir:

* **Öğrenci Yönetimi:**
    * Öğrenci listeleme, arama ve filtreleme.
    * Yeni öğrenci kaydı oluşturma.
    * Öğrenci bilgilerini güncelleme ve silme.
* **Ders İşlemleri:**
    * Müfredat derslerini tanımlama ve listeleme.
    * Ders ekleme ve düzenleme.
* **Not Sistemi:**
    * Öğrencilerin sınav notlarını sisteme girme.
    * Not ortalamalarını görüntüleme.
* **Kulüp Yönetimi:**
    * Öğrenci kulüplerini oluşturma ve yönetme.
* **Kullanıcı Arayüzü:**
    * Bootstrap 3.3.7 ile modern ve sade tasarım.
    * Kullanışlı Sidebar (Yan Menü) navigasyonu.

## 🛠️ Kullanılan Teknolojiler

* **Platform:** .NET Framework
* **Framework:** ASP.NET MVC 5
* **Dil:** C#
* **Veri Erişimi:** Entity Framework (Database First)
* **Veritabanı:** MS SQL Server
* **Frontend:** HTML5, CSS3, JavaScript (jQuery), Bootstrap

## ⚙️ Kurulum Adımları

Projeyi yerel makinenizde çalıştırmak için şu adımları izleyebilirsiniz:

1.  **Projeyi Klonlayın:**
    ```bash
    git clone (https://github.com/kullaniciadi/MvcOkul.git)
    ```

2.  **Projeyi Açın:**
    Visual Studio programını başlatın ve indirilen klasördeki `MvcOkul.sln` dosyasını açın.

3.  **Veritabanı Yapılandırması:**
    * SQL Server üzerinde projenin ihtiyaç duyduğu veritabanını oluşturun.
    * `Web.config` dosyasını açın ve `connectionStrings` bölümündeki veritabanı bağlantı cümlesini (connection string) kendi yerel sunucu bilgilerinize göre güncelleyin.
    * Eğer veritabanı yedeği yoksa, Entity Framework modellerinden yola çıkarak `TBLOGRENCİLER`, `TBLDERSLER`, `TBLNOTLAR`, `TBLKULUP` tablolarını oluşturun.

4.  **Paketleri Yükleyin:**
    Visual Studio'da "NuGet Package Manager" kullanarak eksik paketleri (Restore NuGet Packages) yükleyin.

5.  **Çalıştırın:**
    Projeyi derleyin (`Ctrl + Shift + B`) ve tarayıcıda başlatın (`F5`).

## 📂 Proje Mimarisi

* **Controllers:** İş mantığının yönetildiği sınıflar (`OgrencilerController`, `NotlarController` vb.).
* **Models:** Veritabanı tablolarının Entity Framework nesne karşılıkları.
* **Views:** Kullanıcıya sunulan HTML arayüzleri (`.cshtml` dosyaları).

## 🤝 Katkıda Bulunma

1.  Bu depoyu Fork'layın.
2.  Yeni bir özellik dalı (branch) oluşturun (`git checkout -b feature/YeniOzellik`).
3.  Değişikliklerinizi commit edin (`git commit -m 'Yeni özellik eklendi'`).
4.  Dalınızı (branch) Push edin (`git push origin feature/YeniOzellik`).
5.  Bir Pull Request (PR) oluşturun.

---

*Bu proje eğitim amaçlı geliştirilmiştir.*
 
