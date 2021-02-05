using System;
namespace Upcast
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {
            Console.WriteLine("{0} X {1}", Width, Height);
        }
    }
}
