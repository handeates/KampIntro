using System;

namespace Dongular
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazilim geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java";
            string kurs4 = "python";
            string kurs5 = "c#";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            //aray-dizi
            string[] kurslar = new string[] {"yazilim geliştirici yetiştirme kampı",
                "programlamaya başlangıç için temel kurs",
                "java",
                "python",
                "c#"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar) //buraya kurs yerine baskabiside yazabilirsin(takma ad olmus oluyor) ama buraya ne yazıyorsan asagıda o sekilde cağıracaksın.
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
