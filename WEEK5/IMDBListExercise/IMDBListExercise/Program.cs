using IMDBListExercise;
using System;
using System.Collections.Generic;

namespace PatikaWeek5.IMDBListExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Movies> movies = new List<Movies>();
            bool IsGoing = true;

            while (IsGoing)
            {
                try
                {

                    string movieNames = string.Empty;
                    while (string.IsNullOrWhiteSpace(movieNames))
                    {
                        // Film adini aliyoruz....
                        Console.WriteLine("Lutfen film adini giriniz: ");
                        movieNames = Console.ReadLine()?.Trim() ?? string.Empty; // Console.ReadLine()? --> ifadesi Eger ReadLine null donerse devamindaki metodu calistirma...
                        // ?? --> Eğer soldaki ifade null ise, string.Empty değerini kullan 

                        if (string.IsNullOrWhiteSpace(movieNames)) // Bos veyahut null kontrolu saglanmasi....
                        {
                            Console.WriteLine("Film adi bos gecilemez. Tekrar Giriniz...");
                            continue; // Tekrardan film adini alinmasi icin donguye gidis....
                        }
                        // Film adı kontrolü: Sadece harf ve boşluk içermeli
                        if (!movieNames.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c == 'ç' || c == 'ğ' || c == 'ı' || c == 'ö' || c == 'ş' || c == 'ü' ||
                                                c == 'Ç' || c == 'Ğ' || c == 'İ' || c == 'Ö' || c == 'Ş' || c == 'Ü'))
                        {
                            Console.WriteLine("Film adi sadece harf icermelidir! Tekrar Giriniz...");
                            movieNames = string.Empty;
                            continue;
                        }
                    }
                    double movieRating; // movieRating tanimlanmasi..
                puanGirisi: // goto icin bir referans olusturulmasi....
                    do
                    {

                        try
                        {
                            Console.WriteLine("Lutfen film puaninizi giriniz: (1-10 arasi )");

                            string puanGirisi = Console.ReadLine() ?? string.Empty; // Eger sol taraf null gelirse string.Empty yap demek...

                            if (string.IsNullOrWhiteSpace(puanGirisi))
                            {
                                Console.WriteLine("Puan bos gecilemez...");
                                goto puanGirisi; // puanGirisine gidis....
                            }
                            movieRating = Convert.ToDouble(puanGirisi); // burada stringi doublea donusturme islemi gerceklestiriliyor....

                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Gecersiz bir deger girdiniz...");
                            goto puanGirisi;
                        }


                        if (movieRating < 0 || movieRating > 10)
                        {
                            Console.WriteLine("Gecersiz Puan! 1-10 arasinda bir deger giriniz...");
                            goto puanGirisi; // burada puan girisine gonderiyorum tekrardan kullaniciyi....
                        }
                    }
                    while (false);
                    Movies film1 = new Movies(movieRating, movieNames);
                    movies.Add(film1);

                    Console.WriteLine("Baska film eklemek ister misiniz? (E/H): ");
                    string cevap = Console.ReadLine()?.ToUpper().Trim() ?? "H"; // Readline()? --> eger burada deger null gelirse sonraki methodlari calistirma taki bunda kadar "??"... ?? Eğer soldaki ifadenin tamamı (ReadLine + ToUpper + Trim) null ise 'H' değerini kullan

                    if (cevap == "H") // E disinda herhangi bir deger girilirse 
                    {
                        
                        IsGoing = false; // donguyu sonlandiriz


                        // Tüm filmlerin listesini göster
                        Console.WriteLine("\n=== TÜM FİLMLER ===");
                        foreach (var film in movies)
                        {
                            Console.WriteLine($"Film: {film.Name} - IMDB Puanı: {film.MovieRating}");
                        }

                        // 4-9 arası IMDB puanına sahip filmleri listele
                        Console.WriteLine("\n=== IMDB PUANI 4-9 ARASI OLAN FİLMLER ===");
                        foreach (var film in movies)
                        {
                            if (film.MovieRating >= 4 && film.MovieRating <= 9)
                            {
                                Console.WriteLine($"Film: {film.Name} - IMDB Puanı: {film.MovieRating}");
                            }
                        }
                        // A ile başlayan filmleri listele
                        Console.WriteLine("\n=== 'A' İLE BAŞLAYAN FİLMLER ===");
                        foreach (var film in movies)
                        {
                            if (film.Name.Length > 0 && (film.Name[0] == 'A' || film.Name[0] == 'a'))
                            {
                                Console.WriteLine($"Film: {film.Name} - IMDB Puanı: {film.MovieRating}");
                            }
                        }
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Beklenmeyen bir hata ile karsilasildi....");
                }
            }
        }
    }
}