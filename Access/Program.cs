﻿using System;

namespace Access
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.SetBirthdate(new DateTime(1990, 1, 1));
            Console.WriteLine(person.GetBirthdate());

            
        }
    }
}
