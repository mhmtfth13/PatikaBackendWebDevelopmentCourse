using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    public  abstract class BaseGeometrikSekil // Abstract kullanarak BaseGeometrikSekil'den newlemyi engelledik....
    {
        private double _genislik;
        private double _yukseklik;

        public double Genislik
        {
            get { return _genislik; }
            set { _genislik = value; }
        }
        public double Yukseklik
        {
            get { return _yukseklik; }
            set
            {
                _yukseklik = value;
            }
        }

        public    virtual double AlanHesapla(double genislik,double yukseklik)
        {
            _genislik = genislik;
            _yukseklik=yukseklik;
            double sonuc = _genislik * _yukseklik;
            Console.WriteLine($"Seklin Alani = {sonuc}");
            return sonuc;
            
        }
    }
    public class Kare : BaseGeometrikSekil
    {
        public override double AlanHesapla(double genislik, double yukseklik)
        {
            Console.WriteLine($"Kare seklin alani = {genislik* yukseklik}");
            return genislik * yukseklik;
        }
    }
    public class Dikdortgen : BaseGeometrikSekil
    {
        public override double AlanHesapla(double genislik, double yukseklik) // BaseGeometrikSekil'e ait olan AlanHesapla metodunu dikdortgen sinifi icin icin ozel bir AlanHesapla'ya evrimlestirdik...
        {
            Console.WriteLine($"Dikdortgen seklin alani = {genislik * yukseklik}");
            return genislik * yukseklik;
        }
    }
    public class DikUcgen : BaseGeometrikSekil
    {
        public override double AlanHesapla(double genislik, double yukseklik)
        {
            double s1 = yukseklik * genislik;
            Console.WriteLine($"Ucgen seklin alani = {s1/2}");
            return s1/2;
        }

    }
}
