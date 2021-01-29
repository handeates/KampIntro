 using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation:yani Product sınıfındaki özellikleri product için kullanıyoruz. 
        //tek tek parantez içindeki parametre kısmına int.. string... gibi bir sey tanımlamıyoruz
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
    
    }
}
