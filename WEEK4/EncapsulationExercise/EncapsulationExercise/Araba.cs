using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExercise
{
    internal class Araba
    {
        // marka, model, renk, kapi sayisi properties.

        private string _marka; 
        private string _model;
        private string _renk;
        private int _kapiSayisi;



        public Araba(string marka , string model, string renk, int kapiSayisi)
        {
            _marka = marka;
            _model = model;
            _renk = renk;
            KapiSayisi = kapiSayisi ;


            Console.WriteLine($"Arabanin Markasi {marka}\n" +
                $"Arabanin modeli {model}\n" +
                $"Arabanin rengi {renk}\n" +
                $"Arabinin kapi sayisi {KapiSayisi}");
        }
        public string Marka
        {
            get { return _marka; }
            set { _marka = value; }

        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Renk
        {
            get { return _renk; }
            set { _renk = value; }
        }
        public int KapiSayisi
        {
            get { return _kapiSayisi; }
            set
            {
                if (value != 2 && value != 4)
                {
                    Console.WriteLine("Uyarı: Kapı sayısı yalnızca 2 veya 4 olabilir. Kapı sayısı -1 olarak atanıyor.");
                    _kapiSayisi = -1;
                }
                else 
                {
                    _kapiSayisi = value;
                }

            }
        }
    }
}
