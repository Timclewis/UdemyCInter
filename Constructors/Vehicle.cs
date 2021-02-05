using System;
namespace Constructors
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        public Vehicle()
        {
            Console.WriteLine("hello is being initalised. {0}", registrationNumber);
        }

        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
        }
    }
}
