using System;

namespace VarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello \"World!");
            //Console.WriteLine("Text");

            //string message = "Hello World!";
            //Console.WriteLine(message);

            int AppleCount = 25;
            Console.WriteLine(AppleCount);
            Console.WriteLine(AppleCount + 1);
            Console.WriteLine(AppleCount);

            AppleCount += 10;
            Console.WriteLine(AppleCount);

            AppleCount *= 2;
            Console.WriteLine(AppleCount);

            double x = 3.14;
            Console.WriteLine(x);

            //float y = 6.28f; We don't use floats often in this course

            double z = 20.0 / 3.0;
            Console.WriteLine(z);

            // We don't use floating point or double for money and financial programs
            // Instead we use decimal type
            decimal balance = 100.25512346214m;
            Console.WriteLine(balance);

            bool atLunch = false;
            Console.WriteLine("Are we at lunch right now? " + atLunch);

            // "null" - as in no shopping list at all, so we can't write on it.
            string text = null;
            Console.WriteLine(text);
        }
    }
}
