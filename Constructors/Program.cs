using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(){Id=2,FirstName="İsrafil",LastName="Hallaç",City="Rize" };
           
            Customer customer2 = new Customer(2,"Sezgin","Güngör","Bursa");
            Console.WriteLine(customer1.FirstName);
        }


    }
    class Customer
       
    {
        public Customer()
        {
            
        }
        public Customer(int id,string firstName,string lastName,string city )
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
