# LINQ Alıştırması 1

Bu proje, C# dilinde LINQ (Language Integrated Query) kullanarak rastgele sayılardan oluşan bir liste üzerinde çeşitli işlemler yapmayı göstermektedir. Proje, .NET 8 ve C# 12.0 kullanılarak oluşturulmuştur.

## Açıklama

Program, -100 ile 100 arasında rastgele 10 tam sayıdan oluşan bir liste oluşturur. Daha sonra bu liste üzerinde çeşitli LINQ sorguları yaparak verileri filtreler ve dönüştürür. Sorguların sonuçları konsola yazdırılır.

## Özellikler

- Rastgele 10 tam sayıdan oluşan bir liste oluşturma.
- Listeyi filtreleme:
  - Çift sayılar
  - Tek sayılar
  - Negatif sayılar
  - Pozitif sayılar
  - 16 ile 22 arasında olan sayılar
- Listedeki her sayının karesini hesaplama.
- Sorgu sonuçlarını konsola yazdırma.

## Başlarken

### Gereksinimler

- .NET 8 SDK
- Visual Studio 2022 veya başka bir C# uyumlu IDE

### Programı Çalıştırma

1. Depoyu klonlayın:
``` bash
git clone https://github.com/mhmtfth13/LINQExercise-1.git
```
2. Projeyi Visual Studio 2022'de açın.
3. Çözümü derleyin.
4. Programı çalıştırın.

### Örnek Çıktı

``` csharp
Çift olan sayılar: -42, 18, 64, -88 ++++++++++++++++++++++++++++++ ++++++++++++++++++++++++++++++ ++++++++++++++++++++++++++++++ Tek olan sayılar: -35, 57, -99, 23, 11, -77 ++++++++++++++++++++++++++++++ ++++++++++++++++++++++++++++++ ++++++++++++++++++++++++++++++ Negatif olan sayılar: -42, -35, -88, -99, -77 ++++++++++++++++++++++++++++++ ++++++++++++++++++++++++++++++ ++++++++++++++++++++++++++++++ Pozitif olan sayılar: 18, 64, 57, 23, 11 ++++++++++++++++++++++++++++++ ++++++++++++++++++++++++++++++ ++++++++++++++++++++++++++++++ 15'ten büyük ve 22'den küçük olan sayılar: 18 ++++++++++++++++++++++++++++++ ++++++++++++++++++++++++++++++ ++++++++++++++++++++++++++++++ Listedeki bütün sayıların karesi: 1764, 1225, 324, 4096, 7744, 9801, 529, 5929, 121, 5929 ++++++++++++++++++++++++++++++ ++++++++++++++++++++++++++++++ ++++++++++++++++++++++++++++++
```
