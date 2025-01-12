using Inheritance_Exercise;
using System;

namespace PatikaWeek4.InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Info("Mehmet Fatih", "Aydin","1446");
            Ogretmen ogretmen1 = new Ogretmen();
            ogretmen1.Info("Sertan", "Bozkus", 1_000_000);
        }
    }
}
