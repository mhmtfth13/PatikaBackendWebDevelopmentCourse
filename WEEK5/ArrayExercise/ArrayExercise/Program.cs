using System;

namespace PatikaWeek5.ArrayExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.

            int [] numbers = new int[10];

            //2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
            foreach (int i in numbers)
            {
                Console.WriteLine(numbers[i]);
            }

            //3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz(11.eleman olarak)
            Console.WriteLine("Lutfen diziye eklemek istediginiz sayiyi giriniz...");
            int eklenecekSayi = Convert.ToInt32 (Console.ReadLine());

            Array.Resize(ref numbers, numbers.Length + 1); // yapilan degisikler ramde direkt kendisini etkileyecek bu sayede. Kopya olmayacak...
            numbers[numbers.Length-1] = eklenecekSayi;
            for (int i = 0;i < numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //4 - Bu diziyi büyükten küçüğe ekrana yazdırınız.

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                // Her seferde i'nci indeksi minimum kabul ediyoruz

                int minIndex = i;
                // i'den sonraki elemanları kontrol ediyoruz

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    // Eğer daha küçük bir eleman bulunursa
                    // minIndex'i güncelliyoruz
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // En küçük elemanı i'nci pozisyona taşıyoruz
                // Bu işlem için geçici bir değişken (temp) kullanarak
                // iki değerin yerini değiştiriyoruz (swap işlemi)
                int temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }
            // foreach döngüsü ile dizinin her elemanını tek tek alıyoruz
            foreach (int i in numbers)
            {
                Console.Write(i + " "); // yan yana yazdirma....
            }
        }
    }
}