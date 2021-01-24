using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri(); //Musteri tipinde Musteri1 oluşturdum
            musteri1.Id = 1;
            musteri1.Ad = "Hande";
            musteri1.Soyad = "Ateş";
            musteri1.Telefon = 05548529639;
            
            Musteri musteri2 = new Musteri(); //Musteri tipinde Musteri2 oluşturdum
            musteri2.Id = 2;
            musteri2.Ad = "Musa";
            musteri2.Soyad = "Samanlı";
            musteri2.Telefon = 05439874521;

            Musteri musteri3 = new Musteri(); //Musteri tipinde Musteri3 oluşturdum
            musteri3.Id = 3;
            musteri3.Ad = "Ayşe";
            musteri3.Soyad = "Öz";
            musteri3.Telefon = 05559856124;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2,musteri3 }; //Müşteriler için dizi oluşturdum
         
            MusteriManager musteriManager= new MusteriManager();
            
            Console.WriteLine("**************müsteri ekleme*****************");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            
            Console.WriteLine("*****************müsteri silme*****************");
            musteriManager.Sil(musteri3);

            Console.WriteLine("****************müsterileri listeleme***************");
            musteriManager.Listele(musteriler);

        }
    }
}
