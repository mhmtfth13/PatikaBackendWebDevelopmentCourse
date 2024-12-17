using System;
namespace VariableUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            string identity_number;    // TCKN için string kullanımı
            string name;
            string surname;
            string tel_number;         // Telefon için string kullanımı
            byte age;                  // Yaş için byte (0-255 arası değer)
            double first_item_price;   // indirim olmasindan dolayi double
            double second_item_price;  // indirim olmasindan dolayi double 
            double total_price;        // indirim olmasindan dolayi double 
            double discount_price;     // indirim olmasindan dolayi double

            Console.WriteLine("Lutfen Asagidaki Bilgileri Giriniz:");
            Console.WriteLine("*************************************");

            Console.Write("T.C. Kimlik Numarasi: ");
            identity_number = Console.ReadLine();
            if (identity_number.Length != 11)
            {
                Console.WriteLine("!!!TCKN 11 Haneli Olmalidir!!!");
                Console.Write("Lutfen T.C. kimlik numaranizi 11 Haneli Olacak Bicimde Yaziniz: ");
                identity_number = Console.ReadLine();
                if (identity_number.Length != 11)
                {
                    Console.WriteLine("Sistemi lutfen tekrardan baslatin...");
                    Environment.Exit(0); // uygulamayi kapatiyoruz.
                }
            }

            Console.Write("Adi: ");
            name = Console.ReadLine();

            Console.Write("Soyadi: ");
            surname = Console.ReadLine();

            Console.Write("Telefon Numarasini Lutfen Basinda SIFIR olmadan Giriniz: ");
            tel_number = Console.ReadLine();
            if (tel_number.Length != 10)
            {
                Console.WriteLine("!!! EKSIK VEYAHUT FAZLA TUSLAMA GERCEKLESTIRDINIZ !!!");
                Console.Write("Lutfen telefon numaranizi basinda SIFIR olmadan 10 Haneli Olacak Bicimde Yaziniz: ");
                tel_number = Console.ReadLine();
                if (tel_number.Length != 10)
                {
                    Console.WriteLine("Sistemi lutfen tekrardan baslatin...");
                    Environment.Exit(0); // uygulamayi kapatiyoruz.
                }
            }

            Console.Write("Yas: ");
            age = Convert.ToByte(Console.ReadLine());

            Console.Write("Ilk Aldiginiz Urun Fiyati: ");
            first_item_price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ikinci Aldiginiz Urun Fiyati: ");
            second_item_price = Convert.ToDouble(Console.ReadLine());

            total_price = first_item_price + second_item_price;
            discount_price = total_price * 0.10;
            Console.WriteLine("*********************************************");
            Console.WriteLine($"{identity_number} T.C. Numarali {name} {surname} isimli kisi icin kayit olusturulmustur.");
            Console.WriteLine($"{tel_number} telefon numarasina bildirim mesaji gonderilmistir.");
            Console.WriteLine($"{total_price:F2} toplam harcama karsiligi kazanilan %10 patika puan miktari -> {discount_price:F2} TL'dir."); //F2 iki hane gosterim icin
            Console.ReadKey();
            
        }
    }
}
