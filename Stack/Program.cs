using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push("meme");
            stack.Push(true);
            stack.Push(Math.Pow(2,0.5));

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Clear();

            //stack.Push(null);
            stack.Pop();

        }
    }
}
