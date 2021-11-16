using System;

namespace ExpressionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z = x + y;
            Console.WriteLine(z);

            x = 100;
            y = 3;
            z = x / y;
            Console.WriteLine(z);

            bool atLunch = false;
            Console.WriteLine(atLunch);

            bool comp = x > y;
            Console.WriteLine("The statement x > y is either true or false.");
            Console.WriteLine(comp);

            Console.WriteLine("Lets do some direct numbers");
            Console.WriteLine(100 > 3);
        }
    }
}
