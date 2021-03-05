using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demirog", City = "Ankara" };
           
            Customer customer3 = new Customer();//üstteki kullanımın aynısı sadece farklı yazım
            customer3.Id = 3;
           
            Customer customer2 = new Customer(2,"Derin","Demirog","Ankara");
            Console.WriteLine(customer2.FirstName); // bu çıktıyı alabilmek için constructorda  FirstNme=firsName yapmak gerek.
        }
    }
    class Customer
    { //default constructor parametresi olmayan constructura denir
        public Customer() //customer1 için calısan yer
        {

        }

        public Customer(int id,string firstname,string lastName,string city)//metot parametreler camelCase yani küçük harfle yazılır
            //customer2 için calısan yer
        {
            Id = id;
            FirstName = firstname;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
