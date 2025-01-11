//Ayşe Kulin'in 398 sayfalık, Remzi Kitabevi yayınevinden çıkan Adı Aylin kitabını oluşturunuz.

//2 Adet constructor alternatifi olsun.

//Bir tanesi default constructor tarzında parmetre almadan çalışan bir metot.

//Diğeri Kitap adı, Yazar Adı, Sayfa Sayısı, Yayınevi  bilgilerini alıp bu değerleri nesne üretim aşamasında atayan bir metot.

//KayıtTarihi nesne oluşturulunca otomatik olarak o an olarak atansın. (Her iki constructor için de geçerli)

//Kodlarınızın altına birer yorum satırıyla örnek üzerinden Class , Property, New, Constructor kavramlarını açıklayınız.

using PatikaOOPLibraryExercise;
using System;

namespace PatikaWeek4.OOP.FirstLibrary_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap1 = new Kitap(); // Burada kitap1 adinda nesne olusturmaktayiz..
            kitap1.Name = "Adi Aylin";
            kitap1.WriterName = "Ayse";
            kitap1.WriterSurname = "Kulin";
            kitap1.PageNumber = 398;
            kitap1.PublisherName = "Remzi Kitabevi";

            Kitap kitap2 = new Kitap("Henuz 17 Yasinda", "Ahmet Mithat Efendi", 236, "Turkiye Is Bankasi Kultur Sanat" );
            Console.WriteLine($"Kitap Adi:{kitap1.Name}\n" +
                $"Kitap Yazari Adi:{kitap1.WriterName}\n" +
                $"Kitabin Yazarinin Soyadi:{kitap1.WriterSurname}\n" +
                $"Kitabin Sayfa Sayisi: {kitap1.PageNumber}\n" +
                $"Kitap Yayincisinin Adi:{kitap1.PublisherName}\n" +
                $"Kitabin Yayinlanma Tarihi:{kitap1.SignTime}\n");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Kitabin Adi:{kitap2.Name}\n" +
                $"Kitabin Yazarinin Adi:{kitap2.WriterName}\n" +
                $"Kitabin Sayfa sayisi:{kitap2.PageNumber}\n" +
                $"Kitabin Yayinevi:{kitap2.PublisherName}\n" +
                $"Kitabin Yayinlanma Tarihi:{kitap2.SignTime}\n");
        }
    }
}
