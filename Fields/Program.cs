using System;

namespace Fields
{
    class Program
    { 
        static void Main(string[] args)
        {
            var people = new People(1);
            people.Orders.Add(new People.Order());
            people.Orders.Add(new People.Order());

            //people.Promote();
            Console.WriteLine(people.Orders.Count);
        }
            
    }
}
