using AbstractionExercise;
using System;

namespace PatikaWeek4.AbstractExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee eleman1 = new ProjectLead();
            eleman1.Gorev("Mehmet Fatih", "Aydin", "IT");
            Employee eleman2 = new SoftwareDeveloper();
            eleman2.Gorev("Mehmet Fatih", "Aydin", "Software Department");
            Employee eleman3 = new SalesRepresentative();
            eleman3.Gorev("Mehmet Fatih", "Aydin", "Sales");
        }
    }
}