using System;
using System.Collections;
using System.Collections.Generic;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1); //value type, boxing happens
            list.Add("Me"); // reference no boxing
            list.Add(DateTime.Today); // struc value type boxing
            list.Add(true);

            //var number = (int)list[1];
            // use generic list
            var anotherlist = new List<int>();
            var names = new List<string>();

            names.Add();
        }
    }
}
