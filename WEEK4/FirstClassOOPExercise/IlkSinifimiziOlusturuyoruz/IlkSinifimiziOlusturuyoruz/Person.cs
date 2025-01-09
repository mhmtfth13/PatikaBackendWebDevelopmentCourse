using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkSinifimiziOlusturuyoruz
{
    public class Person
    {
        public string Ad { get; set; } // Ad adinda bir Person sinifina bir property ozellik olusturuyoruz.
        public string Soyad { get; set; } // Soyad adinda bir Person sinifina bir property ozellik olusturuyoruz.
        public DateTime DogumTarihi { get; set; } // DogumTarihi adinda bir Person sinifina bir property ozellik olusturuyoruz.


        public void BilgiGetir () // Person classina ait bir BilgiGetir methodu olusturuyoruz. Burada olusturulan nesnenin adini, soyadini ve dogum tarihini ekrana yaziyoruz.
        {
            Console.WriteLine($"Isminiz : {Ad}\nSoyisminiz:{Soyad}\nDogum Tarihniz:{DogumTarihi}");
        }
    }
}
