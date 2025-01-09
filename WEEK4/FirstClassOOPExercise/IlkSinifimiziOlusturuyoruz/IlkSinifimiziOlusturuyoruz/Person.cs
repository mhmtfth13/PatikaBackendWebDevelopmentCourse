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
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }


        public void BilgiGetir ()
        {
            Console.WriteLine($"Isminiz : {Ad}\nSoyisminiz:{Soyad}\nDogum Tarihniz:{DogumTarihi}");
        }
    }
}
