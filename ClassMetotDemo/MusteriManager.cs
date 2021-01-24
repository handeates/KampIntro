using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +" "+ "ID'li Musteri Eklendi :");
            Console.WriteLine(" Müşteri Ad: " + musteri.Ad);
            Console.WriteLine(" Müşteri Soyad: " + musteri.Soyad);
            Console.WriteLine(" Müşteri Telefon: " + musteri.Telefon);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +" "+ "ID'li Musteri Silindi :");
            Console.WriteLine(" Müşteri Ad: " + musteri.Ad);
            Console.WriteLine(" Müşteri Soyad: " + musteri.Soyad);
            Console.WriteLine(" Müşteri Telefon: " + musteri.Telefon);
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)//en soldaki Musteri(yani veritipi)Musteri classını temsil ediyor
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Telefon);
                Console.WriteLine("---------------");
            }
        }
    }
}
