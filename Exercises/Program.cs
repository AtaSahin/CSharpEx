using System;
namespace Inheritance
{

    public class Customer
    {
        public string Name;
        public string LastName;
        public string City;

        public void PrintFullName()
        {
            Console.WriteLine("Full Name: {0} {1}", Name, LastName);
        }

    }
    public class LocalCustomer : Customer
    {
        public string Address;
        public string Phone;
    }
    public class ForeignCustomer : Customer
    {
        public string Country;
    }

    public class Program
    {
        public static void Main(string[] args)
        {

            Console.ReadKey();

        }
    }
}
