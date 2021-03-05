using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Hande");

            //  List<string> liste = new List<string>();
            //  Console.WriteLine(liste.Count); //bunu çalıstırdığımızda List in 0 elemanlı olduğunu söyler
            Console.WriteLine(isimler.Length);
            isimler.Add("Kerem");
            Console.WriteLine(isimler.Length);
            foreach (var  isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
