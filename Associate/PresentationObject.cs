using System;
namespace Associate
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }


        public void Copy()
        {
            Console.WriteLine("Object has been copied");
            Console.WriteLine("Object is {0} by {1}", Width, Height);
        }

        public void Paste()
        {
            Console.WriteLine("Object has been inserted");
        }
    }

}
