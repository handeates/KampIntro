using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Individual
    //Miras yani Inheritanca(gercek müsteri bir müsteridir demiş oluyoruz) 
    //Bu artık müsteride olan özellikler gercek müsteridede var demektir.
    //tüzelde ve gercekte ortak olan özellikleri müsterinin içine yazıyoruz
    //base sınıf yani müsteri sınıfı bizim referans tutucumuzdur.(referans olan kısım sağ taraftaki new den sonraki kısımdır.)
    class GercekMusteri :Musteri
    {
       
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
