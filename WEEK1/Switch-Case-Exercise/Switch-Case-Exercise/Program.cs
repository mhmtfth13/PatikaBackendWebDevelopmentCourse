using System;
using System.ComponentModel.Design;

namespace FourthExercise
{
    class Program
    {

        static void Main(string[] args)
        {
            string secim;
            int elma = 2;
            int armut = 3;
            int cilek = 2;
            int muz = 3;
            int diger = 4;

            Console.Write("Ruya Manavina Hos Geldiniz!\nElma = 2 TL\nArmut = 3 TL\nCilek = 2 TL\nMuz = 3 TL\nDiger butun meyveler = 4 TL");

            Console.Write("Hangi meyveyi satin almak istersiniz ? (Elma/Armut/Cilek/Muz/Diger): ");
            secim = Console.ReadLine().ToLower();
            // Switch-Case Kullanimi
            switch (secim)
            {
                case "elma":
                    Console.WriteLine($"Sectiginiz meyvenin fiyati: {elma} TL");
                    break;
                case "armut":
                    Console.WriteLine($"Sectiginiz meyvenin fiyati: {armut} TL");
                    break;
                case "cilek":
                    Console.WriteLine($"Sectiginiz meyvenin fiyati: {cilek} TL");
                    break;
                case "muz":
                    Console.WriteLine($"Sectiginiz meyvenin fiyati: {muz} TL");
                    break;
                case "diger":
                    Console.WriteLine($"Sectiginiz meyvenin fiyati: {diger} TL");
                    break;
                default:
                    Console.WriteLine("Gecersiz bir meyve secimi yaptiniz!");
                    break;
            }
            /* //IF-ELSE Kullanimi
            if (secim == "elma")
            {
                Console.WriteLine($"Sectiginiz meyvenin fiyati: {elma} TL");
            }
            else if (secim == "armut")
            {
                Console.WriteLine($"Sectiginiz meyvenin fiyati: {armut} TL");
            }
            else if (secim == "cilek")
            {
                Console.WriteLine($"Sectiginiz meyvenin fiyati: {armut} TL");
            }
            else if (secim == "muz")
            {
                Console.WriteLine($"Sectiginiz meyvenin fiyati: {muz} TL");
            }
            else if (secim == "diger")
            {
                Console.WriteLine($"Sectiginiz meyvenin fiyati: {diger} TL");
            }
            else
            {
                Console.WriteLine("Console.WriteLine(\"Gecersiz bir meyve secimi yaptiniz!\");");
            }
            */
            Console.ReadKey();

        }
    }
}