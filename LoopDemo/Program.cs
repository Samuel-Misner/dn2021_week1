using System;

namespace LoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before the loop");
            Console.WriteLine("Getting ready!");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Let's count down starting with 10 and ending with 1 (inclusive for both).");

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Let's count up by 2's!");

            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            int j = 0;

            while (j < 20)
            {
                Console.WriteLine(j);
                if (j < 10)
                {
                    j++;
                }
                else
                {
                    j += 2;
                }
            }

            Console.WriteLine("We're done with the while loop!");
            Console.WriteLine($"The j variable is now {j}");

            j = 0;

            do
            {
                Console.WriteLine(j);
                j++;
            } while (j <= 10);

            int m = 0;

            while (m < 10)
            {
                m++;
                Console.WriteLine(m);
                if (m == 5)
                {
                    Console.WriteLine("Quitting early");
                    break;
                }
            }

            Console.WriteLine("All done!");

            Console.WriteLine("Maybe this is better?");

            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("We're goign again!");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("Would you like to go again?");
                string entry = Console.ReadLine();
                if (!(entry == "yes"))
                {
                    keepGoing = false;
                }
            }

            Console.WriteLine("Now we can ask the user whether to quit. But let's try another way.");

            string entry = "";
            do
            {
                Console.WriteLine("We're going again!");
                Console.WriteLine(DateTime.Now);

                Console.WriteLine("Would you like to go again?");
                entry = Console.ReadLine();
            } while (entry != "N");
        }
    }
}
