using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items; //dizi tanımladık//classı newlediğimizde bu diziyi hemen olusturmamız gerekiyor
        //constructor// yani bu classı bir yerde new'lediğimizde MyList fonk. otomatik calısır 
        public MyList()
        {
            items = new T[0]; // items dizisi 0 elemanlı
        }
        public void Add(T item)
        {
            T[] tempArray = items; //geçici dizim artık itemsın elemanlarını tutuyor
            //asağıdaki 1 artırma işlemi her seferinde 0dan baslamasın diye geçici dizi kullandık
            items = new T[items.Length+1]; //dizinin eleman sayısını bir artırdık
            //new diyince length 1 arttı ama içindeki elemanlar 0landı
            for (int i=0; i< tempArray.Length;i++) //eski elemanlar doldu fazladan 1 yerimiz var
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //kalan son bir bosluga yeni ekleyeceğimiz elemanı(fonk. parametresindeki item) eklıyoruz
        
        }
        public int Length
        {
            get { return items.Length; } //eleman sayısını verir
        }
        public T[] Items //elemanları gösterir
        {
            get { return items; }
        }
    }
}
