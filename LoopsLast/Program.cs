using System;

namespace LoopsLast
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Pyhton";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

           


            //array = dizi

            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Yetiştirme Kampı","Programlamaya başlangıç için temel kurs","Java","Pyhton","C++"
            };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Sayfa Sonu");
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            for (int i = 1; i <= 10; i=i+2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
