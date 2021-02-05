using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new Persons(new DateTime(1993, 12, 10));
            //persons.BirthDate = new DateTime(1993, 12, 10);
            Console.WriteLine(persons.Age);
        }
    }
}
