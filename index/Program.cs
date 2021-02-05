using System;

namespace index
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new Cookie();
            cookie["name"] = "Tim";
            Console.WriteLine(cookie["name"]);

        }
    }
}
