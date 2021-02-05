using System;

namespace Associate
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Height = 200;

            text.Copy();
        }
    }
}
