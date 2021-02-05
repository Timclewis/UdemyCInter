using System;
namespace AccessMod
{
    public class Customer
    {
        // properties

        public int Id { get; private set; }
        public string FullName { get; set; }
        public int Score { get; set; }


        public Customer()
        {

        }
           

        public void Promote(int Age)
        {
            var rating = CalculateRating(Age);
            if (rating > 5)
                Console.WriteLine("You are promoted a Level");
            else
                Console.WriteLine("You are not promoted");                   
        }

        private int CalculateRating(int Age)
        {
            if (Age > 25)
                Score = 5;
            if (Age > 35)
                Score = 10;
            else
                Score = 0;

            return Score;
        }

    }
}
