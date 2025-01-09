using IlkSinifimiziOlusturuyoruz;
using System;

namespace PatikaWeek4.IlkSinifOlusturuyoruzExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Ogretmen1 = new Person();
            Person Ogrenci1 = new Person
            {
                Ad = "Mehmet",
                Soyad ="Aydin",
                DogumTarihi = new DateTime(2000,02,20)
            };
            Person Ogrenci2 = new Person
            {
                Ad= "Salih",
                Soyad= "Aydin",
                DogumTarihi = new DateTime(2010,01,18)
            };

            Ogretmen1.Ad = "Ahmet";

            Ogretmen1.Soyad = "Sonuc";
            Ogretmen1.DogumTarihi = new DateTime(2000,1,1);

            Ogretmen1.BilgiGetir();
            Ogrenci1.BilgiGetir();
            Ogrenci2.BilgiGetir();
            Console.ReadKey();
            
        }
    }
}