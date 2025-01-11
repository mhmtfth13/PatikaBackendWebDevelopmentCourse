# Patika Kütüphane Uygulaması

Bu proje, Patika Kütüphanesi için geliştirilmiş basit bir kitap kayıt uygulamasıdır.

## Proje Özellikleri

Uygulama aşağıdaki özelliklere sahiptir:

* Kitap bilgilerini kaydetme
* İki farklı constructor ile nesne oluşturabilme
* Otomatik kayıt tarihi atama

## Kitap Sınıfı Özellikleri

Kitap sınıfı aşağıdaki özellikleri içermektedir:

* Ad (Name)
* Yazar Adı (WriterName)
* Yazar Soyadı (WriterSurname)
* Sayfa Sayısı (PageNumber)
* Yayınevi (PublisherName)
* Kayıt Tarihi (SignTime)

## Constructor'lar

### Default Constructor
```csharp
public Kitap()
{
   _signTime = DateTime.Now;
}
```
### Parametreli Constructor
``` csharp
public Kitap(string bookName, string writerName, int pageNumber, string publisher)
{
    _bookName = bookName;
    _writerName = writerName;
    _pageNumber = pageNumber;
    _publisherName = publisher;
    _signTime = DateTime.Now;
}
```
### Kullanim Ornegi
```csharp
// Parametresiz constructor kullanımı
Kitap kitap1 = new Kitap();
kitap1.Name = "Adı Aylin";
kitap1.WriterName = "Ayşe";
kitap1.WriterSurname = "Kulin";
kitap1.PageNumber = 398;
kitap1.PublisherName = "Remzi Kitabevi";

// Parametreli constructor kullanımı
Kitap kitap2 = new Kitap("Henüz 17 Yaşında", "Ahmet Mithat Efendi", 236, "Türkiye İş Bankası Kültür Sanat");
```
### Teknik Detaylar
* Uygulama C# programlama dili ile geliştirilmiştir
* OOP prensipleri kullanılmıştır
* Encapsulation prensibi uygulanmıştır
* Property'ler için get/set metodları kullanılmıştır

### Katkıda Bulunma
* Bu repository'yi fork edin
* Yeni bir branch oluşturun (git checkout -b feature/AmazingFeature)
* Değişikliklerinizi commit edin (git commit -m 'Add some AmazingFeature')
* Branch'inize push edin (git push origin feature/AmazingFeature)
* Pull Request oluşturun
