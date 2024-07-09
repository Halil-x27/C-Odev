using System;
using System.Runtime.Serialization;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
              // adım 1 ödevi
            // Console.WriteLine("n adet pozitif sayi giriniz");
            // int n = int.Parse(Console.ReadLine());
            // int [] sayiDizisi = new int[n];

            // for (int i = 0; i < n; i++)
            // {
            //     Console.WriteLine("dizinin {0}. elemanını giriniz", i+1);
            //     sayiDizisi[i] = int.Parse(Console.ReadLine());

            // }
            // Console.WriteLine("Çift olan sayılar:");
            // foreach (int number in sayiDizisi)
            // {
            //     if (number % 2 == 0)
            //     {
            //     Console.WriteLine(number);
            //     }
            // }


            // adım 2 Ödevi

            // Console.WriteLine("n adet pozitif sayi giriniz");
            // int x = int.Parse(Console.ReadLine());
            // Console.WriteLine("m adet pozitif sayi giriniz");
            // int y = int.Parse(Console.ReadLine());

            //  int [] sayiDizisi1 = new int[x];
            //  int [] sayiDizisi2 = new int[y];

            //  for (int i = 0; i < x; i++)
            // {
            //     Console.WriteLine("n dizinin {0}. elemanını giriniz", i+1);
            //     sayiDizisi1[i] = int.Parse(Console.ReadLine());

                

            // }
            // for (int j = 0; j < y; j++)
            // {
            //         Console.WriteLine("m dizinin {0}. elemanını giriniz", j+1);
            //         sayiDizisi2[j] = int.Parse(Console.ReadLine());
            // }
            
            // Console.WriteLine("eşit ya da tam bölünebilen sayilar:");
            // foreach (int number in sayiDizisi1)
            // {
            //     foreach (var item in sayiDizisi2)
            //     {
            //         if (number == item || number % item ==0)
            //         {
            //             Console.WriteLine(number);
            //         }
            //     }
            // }


            // adım 3 ödevi 

           
            //  Console.WriteLine("Pozitif bir sayı giriniz:");
            // int n = int.Parse(Console.ReadLine());

        
            // if (n <= 0)
            // {
            //     Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
            //     return;
            // }

       
            // string[] Kelime = new string[n];
            // for (int i = 0; i < n; i++)
            // {
            //     Console.WriteLine($"{i + 1}. kelimeyi giriniz:");
            //     Kelime[i] = Console.ReadLine();
            // }

       
            // Console.WriteLine("Kelimeler sondan başa doğru:");
            // for (int i = n - 1; i >= 0; i--)
            // {
            //     Console.WriteLine(Kelime[i]);
            // }


            // 4. adım Ödevi

            
            Console.WriteLine("Bir cümle yazınız:");
            string sentence = Console.ReadLine();

           
            string[] words = sentence.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            
            int letterCount = 0;
            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                {
                    letterCount++;
                }
            }

            
            Console.WriteLine($"Toplam kelime sayısı: {wordCount}");
            Console.WriteLine($"Toplam harf sayısı: {letterCount}");


        }
    }
}