using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
        }
    }
    class MyList<T> //Generic Class //T Ttip demek string,int... gibi
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array; //dizinin ilk halindeki elemanlar temp e aktarılıyor
            _array = new T[_array.Length + 1]; //dizinin boyutu bir artırılıyor.
            for (int i =0; i< _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i]; //yeni bos arrayi temp e kaydedilen eski arrayin elemanları ile dolduruyoruz.
            }
            _array[_array.Length - 1] = item; //arrayın son elemanı bizim gönderdiğimiz item a eşit olmus oluyor.
        }
       

        public int Count
        {
            get { return _array.Length; }
            
        }

    }
}
