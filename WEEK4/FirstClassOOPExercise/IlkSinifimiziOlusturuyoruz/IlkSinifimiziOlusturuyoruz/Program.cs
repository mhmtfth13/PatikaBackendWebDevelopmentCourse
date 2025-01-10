using IlkSinifimiziOlusturuyoruz;
using System;

namespace PatikaWeek4.IlkSinifOlusturuyoruzExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Ogretmen1 = new Person(); // Person classindan Ogretmen1 adinda bir nesne olusturuyoruz.
            Person Ogrenci1 = new Person // Person classindan Ogrenci1 adinda bir nesne olusturuyoruz.
            {
                Ad = "Mehmet", // Ogrenci1.Ad degerine atama yapiyoruz set islemini kullanmis oluyoruz.
                Soyad ="Aydin", // Ogrenci1.Soyad degerine atama yapiyoruz set islemini kullanmis oluyoruz.
                DogumTarihi = new DateTime(2000,02,20) // Ogrenci1.DogumTarihi degerine atama yapiyoruz set islemini kullanmis oluyoruz.
            };
            Person Ogrenci2 = new Person // Person classindan Ogrenci1 adinda bir nesne olusturuyoruz.
            {
                Ad= "Salih",
                Soyad= "Aydin",
                DogumTarihi = new DateTime(2010,01,18)
            };

            Ogretmen1.Ad = "Ahmet"; // Ogretmen1.Ad degerine atama yapiyoruz set islemini kullanmis oluyoruz.

            Ogretmen1.Soyad = "Sonuc";
            Ogretmen1.DogumTarihi = new DateTime(2000,1,1); // Ogretmen1.DogumTarihi degerine atama yapiyoruz set islemini kullanmis oluyoruz.

            Ogretmen1.BilgiGetir(); // Person classinda yer alan BilgiGetir methodunu Ogretmen1 icin cagiriyoruz...
            Ogrenci1.BilgiGetir();
            Ogrenci2.BilgiGetir();
            Console.ReadKey();
            
        }
    }
}
