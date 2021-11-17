using System;

namespace MethodDemo
{
    class Program
    {
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static long Product(long a)
        {
            return a * 2;
        }
        static void Main(string[] args)
        {
            double x = 64.0;
            double y = Math.Sqrt(x);
            Console.WriteLine(y);

            double z = Sum(5, 3);
            Console.WriteLine($"The sum is {z}");

            long f = 1;
            for (int g = 0; g <= 100; g++)
            {
                f = Product(f);
                Console.WriteLine(f);
            }
        }
    }
}
