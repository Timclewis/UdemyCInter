using System;
namespace Associate
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }

        public void AddHyper(string url)
        {
            Console.WriteLine("We added a link to {0}", url);
        }
    }
}
