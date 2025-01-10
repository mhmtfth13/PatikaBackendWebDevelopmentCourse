using CTOR_Exercise;
using System;

namespace PatikaWeek4.CTOR_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebek bebek1 = new Bebek();// Default CTOR kullandik.
            Console.WriteLine($"Bebek1: Dogum Tarihi:{bebek1._birthDate}");
            Bebek bebek2 = new Bebek("Ali","Veli"); // Burada method overloading oldu 2. yaptigimiz CTOR kullandik.
            Console.WriteLine($"Bebek2: Bebek2 Adi:{bebek2._name}, Bebek2 Soyadi:{bebek2._lastname}, Bebek2 Dogum Tarihi:{bebek2._birthDate}");
            Console.ReadKey();
        }
    }
}