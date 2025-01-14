# Polymorphism Example

Bu proje, C# dilinde **Polymorphism** (Çok Biçimlilik) kavramını kullanarak geometrik şekillerin alan hesaplamalarını gerçekleştiren bir uygulama örneği sunmaktadır.

## Proje Açıklaması

Bu projede, üç farklı geometrik şekil sınıfı (`Kare`, `Dikdörtgen`, `DikÜçgen`) oluşturulmuştur. Her şekil, alan hesaplamak için `AlanHesapla` metodunu kullanır. `GeometrikSekil` sınıfı, temel sınıf olup alan hesaplamasını genel bir şekilde tanımlar. Ancak `DikÜçgen` sınıfı, alan hesaplama metodunu özelleştirir (override eder).

### Kullanılan Kavramlar:
- **Polymorphism** (Çok Biçimlilik): Aynı metodun farklı sınıflar tarafından farklı şekillerde uygulanması sağlanır. Bu örnekte `AlanHesapla` metodu temel sınıf olan `GeometrikSekil` sınıfında tanımlandıktan sonra, `DikÜçgen` sınıfında özelleştirilmiştir.

## Kullanıcı Kılavuzu

### Projeyi Çalıştırma Adımları:
1. Projeyi bilgisayarınıza indirin veya bir C# geliştirme ortamında açın.
2. `Program.cs` dosyasındaki `Main` metodunu çalıştırarak şekillerin alan hesaplamalarını görebilirsiniz.
3. Her şekil için farklı parametrelerle `AlanHesapla` metodunu çağırabilirsiniz.

### Çıktılar:
- **Kare**: Alan, yükseklik ve genişlik aynı olduğunda hesaplanır.
- **Dikdörtgen**: Alan, yükseklik ve genişlik farklı olduğunda hesaplanır.
- **DikÜçgen**: Alan, `(yükseklik * genişlik) / 2` formülü ile hesaplanır.

### Kod Örneği:
```csharp
using Polymorphism;
using System;

namespace PatikaWeek4.Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Kare kare1 = new Kare();
            kare1.AlanHesapla(10, 10); // Kare için alan hesaplama
            Dikdortgen dikdortgen1 = new Dikdortgen();
            dikdortgen1.AlanHesapla(20, 10); // Dikdörtgen için alan hesaplama
            DikUcgen dikucgen1 = new DikUcgen();
            dikucgen1.AlanHesapla(10, 30); // Dik Üçgen için alan hesaplama
        }
    }
}
```
### Sınıflar
1. GeometrikSekil Sınıfı
   * Temel sınıf olup geometrik şekiller için alan hesaplamasını sağlar.
   * AlanHesapla(double yukseklik, double genislik): Alan hesaplama metodudur.
   * Yukseklik: Şeklin yüksekliğini temsil eder.
   * Genislik: Şeklin genişliğini temsil eder.
2. Kare Sınıfı
   * GeometrikSekil sınıfından türetilmiştir. AlanHesapla metodu temel sınıfın metodunu kullanır.
3. Dikdortgen Sınıfı
   * GeometrikSekil sınıfından türetilmiştir. AlanHesapla metodu temel sınıfın metodunu kullanır.
4. DikUcgen Sınıfı
   * GeometrikSekil sınıfından türetilmiştir. AlanHesapla metodu override edilerek üçgenin alan hesaplama formülü kullanılır.
### Proje Yapısı
* Program.cs: Uygulamanın ana çalışma dosyasıdır.
* GeometrikSekil.cs: Temel sınıf olan GeometrikSekil sınıfını içerir.
* Kare.cs: Kare sınıfını içerir.
* Dikdortgen.cs: Dikdörtgen sınıfını içerir.
* DikUcgen.cs: Dik üçgen sınıfını içerir.
### Gereksinimler
* .NET 5.0 veya daha yeni bir sürüm gerekmektedir.
### Katkida Bulunmak Isterseniz
* Bu projeye katkıda bulunmak isterseniz, pull request göndererek değişikliklerinizi paylaşabilirsiniz. Yardımcı olabileceğiniz bir şey varsa, çekinmeden iletişime geçebilirsiniz.
