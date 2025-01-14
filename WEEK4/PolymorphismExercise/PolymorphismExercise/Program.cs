using PolymorphismExercise;
using System;
namespace PatikaWeek4.PolymorphismExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Kare kare1 = new Kare();
            kare1.AlanHesapla(10, 10);
            Dikdortgen dikdortgen1 = new Dikdortgen();
            dikdortgen1.AlanHesapla(20, 10);
            DikUcgen dikucgen1 = new DikUcgen();
            dikucgen1.AlanHesapla(10, 30);
        }
    }
}