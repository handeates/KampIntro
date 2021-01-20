using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        //normal parantez gördüğümüzde burada bir metot çalıştığını anlıyoruz. (parantezin içi parametre oluyor)
        public void Ekle(Urun urun) //ilk Urun (tipi), 2. urun aşagıda cağıracağımız isimlendirme
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi :" + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdeti)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi :" + urunAdi);
        }
    }
}
