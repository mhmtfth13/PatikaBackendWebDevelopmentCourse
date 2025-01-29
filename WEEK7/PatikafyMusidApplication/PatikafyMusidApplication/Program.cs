using PatikafyMusidApplication;
using System;
using System.Net.Http.Headers;

namespace PatikaWeek7.LINQExercise_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Liste tanimlamasi yapildi ve Listeye sarkicilar eklendi.....
            List<Singer> Singers = new List<Singer>
            {
                new Singer { Name = "Ajda Pekkan", Genre = "Pop", ReleaseDate =new DateTime(1968,1,1) , Sales =20_000_000  },
                new Singer { Name = "Sezen Aksu", Genre = "Turk Halk Muzigi / Pop", ReleaseDate = new DateTime(1971,1,1) , Sales = 10_000_000 },
                new Singer { Name = "Funda Arar", Genre = "Pop", ReleaseDate = new DateTime(1999,1,1) , Sales =3_000_000  },
                new Singer { Name = "Sertab Erener", Genre = "Pop", ReleaseDate = new DateTime(1994,1,1), Sales = 10_000_000 },
                new Singer { Name = "Sila", Genre = "Pop", ReleaseDate = new DateTime(2009,1,1), Sales =3_000_000  },
                new Singer { Name = "Serdar Ortac", Genre = "Pop", ReleaseDate = new DateTime(1994,1,1), Sales =10_000_000  },
                new Singer { Name = "Tarkan", Genre = "Pop", ReleaseDate = new DateTime(1992,1,1), Sales = 40_000_000 },
                new Singer { Name = "Hande Yener", Genre = "Pop", ReleaseDate = new DateTime(1999,1,1), Sales = 7_000_000  },
                new Singer { Name = "Hadise", Genre = "Pop", ReleaseDate = new DateTime(2005,1,1), Sales =5_000_000  },
                new Singer { Name = "Gulben Ergen", Genre = "Pop/ Turk Halk Muzigi", ReleaseDate = new DateTime(1997,1,1) , Sales = 10_000_000 },
                new Singer { Name = "Neset Ertas", Genre = "Turk Halk Muzigi/ Turk Sanat Muzigi", ReleaseDate = new DateTime(1960,1,1), Sales =2_000_000  },
            };

            // Adı 'S' ile başlayan şarkıcılar
            var firstNameStartWithS = Singers.Where(x => x.Name.StartsWith("S"));
            foreach (var x in firstNameStartWithS)
            {
                Console.WriteLine( "Adi s ile baslayan sarkicilar: " + x.Name);
            }
            Console.WriteLine("================================================");

            //Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
            var salesOver10M = Singers.Where(x => x.Sales > 10_000_000);
            foreach (var x in salesOver10M)
            {
                Console.WriteLine("Albun satislari 10M uzerinde olan sarkicilar " + x.Name);
            }
            Console.WriteLine("=================================================");


            //2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. (Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.
            var before2000PopSingers = Singers.Where(x => x.ReleaseDate.Year < 2000 && x.Genre.Contains("Pop"))
                                              .GroupBy(x => x.ReleaseDate.Year)
                                              .OrderBy(g => g.Key);
            foreach (var Group in before2000PopSingers)
            {
                Console.WriteLine($"\n{Group.Key} yılında çıkış yapanlar:");
                foreach (var x in Group.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"- {x.Name}");
                }
            }

            //En çok albüm satan şarkıcı
            var mostSales = Singers.OrderByDescending(x => x.Sales).First();
            Console.WriteLine("En cok satan album "+mostSales.Name);

            //En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
            var newestSinger = Singers.OrderByDescending(x => x.ReleaseDate).First();
            var oldestSinger = Singers.OrderBy(x => x.ReleaseDate).First();
            Console.WriteLine("En yeni cikis yapan sarkici " +newestSinger.Name);
            Console.WriteLine("En eski cikis yapan sarkici " +oldestSinger.Name);
        }
    }
}