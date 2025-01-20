using System;
using System.Collections.Generic;
namespace PatikaWeek5.ListExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> davetliler = new List<string>();
            string[] isimler = new string[] {
                "Bülent Ersoy",
                "Ajda Pekkan",
                "Ebru Gündeş",
                "BOS INSAN",
                "Hande Yener",
                "Tarkan",
                "Funda Arar",
                "Demet Akalın" };
            Console.WriteLine("** Davetliler **");
            for (int i = 0; i < isimler.Length; i++)
            {
                davetliler.Add(isimler[i]);
                Console.ForegroundColor = ConsoleColor.Magenta; // Renk degisimi
                Console.Write($"{i + 1} - ");
                Console.ResetColor(); // Renk sifirlama normal yazi icin
                Console.WriteLine(isimler[i]);
            }
        }
    }
}