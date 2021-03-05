using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Coorporate
    //Miras yani Inheritanca(tüzel müsteri bir müsteridir demiş oluyoruz) 
    //Bu artık müsteride olan özellikler tuzel müsteridede var demektir.
    //tüzelde ve gercekte ortak olan özellikleri müsterinin içine yazıyoruz.
    ////base sınıf yani müsteri sınıfı bizim referans tutucumuzdur.(referans olan kısım sağ taraftaki new den sonraki kısımdır.)
    class TuzelMusteri :Musteri
    {
        public string SirketAdi { get; set; } 
        public string VergiNo { get; set; }
    }
}
