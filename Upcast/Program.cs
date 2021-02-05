using System;
using System.Collections;
using System.IO;

namespace Upcast
{ // conversion from derived to a base class
    class Program
    {
        static void Main(string[] args)
        {
            var shape = new Text();
            Text text = (Text)shape;
           


            // StreamReader reader = new StreamReader(new MemoryStream());
            /*var list = new ArrayList();
            list.Add(1);
            list.Add("Tim");
            list.Add(new Text());

            var anotherList = new List<Shape>(); */



            /*Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            shape.Draw(); */
        }
    }
}
