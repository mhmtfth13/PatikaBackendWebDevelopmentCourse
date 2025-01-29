# 🎵 Patikfy Müzik Uygulaması

## 📋 Proje Açıklaması
LINQ sorguları kullanarak Türk müzik sanatçılarının verilerini yöneten konsol uygulaması. Sanatçı bilgilerini filtreleme, gruplama ve analiz etme özelliklerine sahiptir.

## 🔧 Teknolojiler
- .NET Core
- C# 
- LINQ

## 📁 Proje Yapısı
PatikafyMusicApplication/
├── Program.cs
├── Models/
│   └── Singer.cs
└── README.md

## 📝 Sınıf Yapısı
Singer sınıfı aşağıdaki özelliklere sahiptir:
- Name (string): Sanatçı adı
- Genre (string): Müzik türü  
- ReleaseDate (DateTime): Çıkış tarihi
- Sales (ulong): Satış rakamı

## 🔍 Temel Özellikler
1. Veri Filtreleme:
   - 'S' harfi ile başlayan sanatçıları listeleme
   - 10M üzeri albüm satışı olan sanatçıları filtreleme
   - 2000 öncesi Pop müzik yapan sanatçıları yıla göre gruplama

2. Veri Analizi:
   - En çok satış yapan sanatçıyı bulma
   - En yeni/eski çıkış yapan sanatçıyı tespit etme

## 💡 LINQ Sorgu Örnekleri
```csharp
// S ile başlayan isimler
var sNameSingers = Singers.Where(x => x.Name.StartsWith("S"));

// Yüksek satışlar
var highSales = Singers.Where(x => x.Sales > 10_000_000);

// Yıla göre gruplama
var groupedSingers = Singers
    .Where(x => x.ReleaseDate.Year < 2000 && x.Genre.Contains("Pop"))
    .GroupBy(x => x.ReleaseDate.Year);
```
