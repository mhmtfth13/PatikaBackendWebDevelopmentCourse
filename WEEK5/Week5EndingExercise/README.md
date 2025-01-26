# Araba Uretim Programi

Bu proje, konsol üzerinden araba üretim işlemlerinin yapılabildiği basit bir C# uygulamasıdır.

## Özellikler

- Araba üretimi ve özellik girişi
- Üretim zamanı otomatik kayıt
- Kapı sayısı validasyonu (2 veya 4 kapı)
- Üretilen arabaların listelenmesi

## Sınıf Yapısı

### Araba Sınıfı Özellikleri
- Üretim Tarihi (ProductionTime)
- Seri Numarası (SerialNumber)  
- Marka (Marka)
- Model (Model)
- Renk (Renk)
- Kapı Sayısı (DoorNumber)

## Kullanım

1. Program başlatıldığında üretim yapmak isteyip istemediğiniz sorulur
2. "e" ile üretim başlatılır, "h" ile program sonlandırılır
3. Sırasıyla araba özellikleri girilir
4. Kapı sayısı 2 veya 4 olmalıdır, farklı değerler için otomatik 4 atanır
5. İşlem sonunda üretilen tüm arabaların özellikleri listelenir

## Gereksinimler

- .NET Core 6.0 veya üzeri
