# Teknoloji Mağazası Ürün Yönetim Sistemi

## Proje Hakkında
Bu proje, bir teknoloji mağazasında telefon ve bilgisayar kayıtlarının tutulmasını ve yönetilmesini sağlayan bir konsol uygulamasıdır. Uygulama, Object Oriented Programming (OOP) prensiplerini kullanarak geliştirilmiştir.

## Özellikler

### Temel Özellikler
- Telefon ve Bilgisayar ürünlerinin kaydı
- Ürün bilgilerinin görüntülenmesi
- Ürün detaylarının validasyonu
- Kullanıcı dostu arayüz

### Ürün Özellikleri

#### Ortak Özellikler (BaseMakine)
- Üretim Tarihi
- Seri Numarası
- Ad
- Açıklama
- İşletim Sistemi

#### Telefon Özellikleri
- TR Lisanslı olup olmama durumu

#### Bilgisayar Özellikleri
- USB Giriş Sayısı (2 veya 4)
- Bluetooth olup olmama durumu

## OOP Prensipleri

### Inheritance (Kalıtım)
- `BaseMakine` abstract sınıfından Telefon ve Bilgisayar sınıfları türetilmiştir.

### Encapsulation (Kapsülleme)
- Bilgisayar için USB giriş sayısı kontrolü
- Property'ler üzerinde getter ve setter metodları

### Polymorphism (Çok Biçimlilik)
- `BilgileriYazdir()` metodunun override edilmesi
- Her sınıfın kendi özelliklerine göre bilgi yazdırması

### Abstraction (Soyutlama)
- `UrunAdiGetir()` abstract metodu ile soyutlama
- Her ürün tipi için özel mesaj formatı

## Kullanım

Program başlatıldığında kullanıcıya seçenekler sunulur:
1. Telefon üretimi
2. Bilgisayar üretimi

Seçilen ürün tipine göre aşağıdaki bilgiler istenir:
- Temel bilgiler (Seri No, Ad, vb.)
- Ürüne özel bilgiler (Lisans durumu veya USB giriş sayısı)

Bilgiler kaydedildikten sonra:
- Ürün özellikleri ekranda gösterilir
- Yeni ürün ekleme seçeneği sunulur

Program, "İyi günler" mesajı ile sonlandırılabilir.

## Validasyonlar

### Bilgisayar
- USB giriş sayısı sadece 2 veya 4 olabilir
- Geçersiz girişte kullanıcıdan tekrar giriş istenir

### Telefon
- TR Lisans durumu için sadece Evet/Hayır (E/H) girişi kabul edilir

## Notlar
- Üretim tarihi otomatik olarak atanır.
- Tüm bilgiler Türkçe karakter desteği ile gösterilir.
- Boolean değerler "Var/Yok" formatında gösterilir.

## Geliştirici Notları
Örnek kullanım:

```csharp
BaseMakine bilgisayar = new Bilgisayar();
bilgisayar.UrunAdiGetir("Test Bilgisayar");
bilgisayar.BilgileriYazdir();
```

