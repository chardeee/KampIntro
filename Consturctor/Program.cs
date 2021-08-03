using System;

namespace Consturctor
{
    class Program
    {
        static void Main(string[] args)
        {
            // ilk ve ikinci sıradaki (customer 1 ve 3) kullanım birbirine eşit
            Customer customer1 = new Customer() { Id = 1, FirstName = "İsmail", LastName = "Serin", City = "Konya" };
            
            Customer customer3 = new Customer();
            customer3.Id = 1;
            
            Customer customer2 = new Customer (2 , "Ali" , "Serin" , "Konya");
            Console.WriteLine(customer1.FirstName);
        }
    }

    class Customer
    {
        public Customer()
        {

        }
        //default constructor
        public Customer(int id ,string firstname , string lastname , string city)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
            
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
