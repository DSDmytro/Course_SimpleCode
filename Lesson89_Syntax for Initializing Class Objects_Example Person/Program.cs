using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson89_Syntax_for_Initializing_Class_Objects_Example_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Dmytro";
            person1.LastNane = "Dmytrov";
            Address address = new Address();
            address.Country = "Ukraine";
            address.Region = "Kyiv Region";
            address.City = "Kyiv";
            person1.Address = address;

            Console.WriteLine($"First Name: {person1.FirstName}\tLastname: {person1.LastNane}" +
                              $"\nCountry: {address.Country}\tRegion: {address.Region}\tCity: {address.City}");
            Console.WriteLine();

            Person person2 = new Person
            { 
                FirstName = "Katya",
                LastNane = "Katyeva",
                Address = new Address
                {
                    Country = "Ukraine new",
                    Region = "Kyiv Region new",
                    City = "Kyiv City new"
                }
            };
            Console.WriteLine($"First Name: {person2.FirstName}\tLastname: {person2.LastNane}" +
                  $"\nCountry: {address.Country}\tRegion: {address.Region}\tCity: {address.City}");
            Console.WriteLine();
        }
    }
}
