using System;

namespace IfElseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;

            if (x > y)
            {
                Console.WriteLine("x is indeed greater than y.");
                Console.WriteLine("The expression x > y evaluates to true.");
            }

            if (y > x)
            {
                Console.WriteLine("y > x is true.");
            }
            else
            {
                Console.WriteLine("y > x is false.");
            }

            int size = 700;

            if (size > 0 && size <= 250)
            {
                Console.WriteLine("Room is small");
            }
            else if (size > 250 && size < 650)
            {
                Console.WriteLine("Room is medium");
            }
            else
            {
                Console.WriteLine("Room is large");
            }
        }
    }
}
