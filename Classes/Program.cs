using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("Tim");
            person.Name = "Tim";
            person.Introduce("Mosh");
        }
    }
}
