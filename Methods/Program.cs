using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine();
            else
                Console.WriteLine("Conversion failed");

        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1,2));
            Console.WriteLine();
            Console.WriteLine(calculator.Add(1,4,3,123,2));
        }

        static void UsePoints()
        {
            try
            {
            var point = new Point();
            point.Move(new Point(40, 20));
            Console.WriteLine("Point is at {0} and {1}", point.X, point.Y);

            point.Move(100, 200);
            Console.WriteLine("Point is at {0} and {1}", point.X, point.Y);

            point.Move(null);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");
            }
        }
    }
}
