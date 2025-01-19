using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Week4EndTask.Abstract;

namespace Week4EndTask.Concerete
{
    internal class Telefon:BaseMakine
    {
        private bool _trLisansliMi; // Telefona ait olan ozel fieldin tanimlanmasi
        
        public bool TrLisansliMi // Burada properties tanimlamasi ve field alanlarin kapsulleme mantigi icin atama ulasim guvenligi saglanmasi
        {
            get => _trLisansliMi;
            set => _trLisansliMi = value;
        }

        public override void BilgileriYazdir() // Bilgileri yazdirma methodum
        {
            Console.WriteLine($"""
            Telefonunuzun ozellikleri
            ---------------------------------------
            Telefonunuzun Uretim Tarihi: {UretimTarihi:dd/MM/yyyy}
            Telefonunuzun Seri Numarasi: {SeriNumarasi}
            Telefonunuzun Adi: {Name}
            Telefonunuzun Isletim Sistemi: {IsletimSistemi}
            Telefonunuzun TRLisansi Var Mi: {(TrLisansliMi ? "Var" : "Yok")}
            """);

        }
        public  override void UrunAdiGetir(string name) // Method ezilerek urun adini getirmekteyiz...
        {
            
            Console.WriteLine($"Telefonunuzun adi {name}");

        }
        public void LisansDurumuBelirle(string giris) // Lisans durumu icin yazilan method...
        {
            TrLisansliMi = giris.ToLower()
            switch
            {
                "e" => true,
                "h" => false,
                _ => throw new ArgumentException("Gecerli bir secenek giriniz (E/H)"),
            };
        }
    }
}
