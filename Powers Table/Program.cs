using System;

namespace Powers_Table
{
    class Program
    {

        static double pow(int n, int e)
        {
            double product = 1;
            for (int i = 0; i < e; i++)
            {
                product *= n;
            }
            return product;
        }
        static void Main(string[] args)
        {
            int userInt = 0;

            bool run = true;

            while (run)
            {
                Console.Write("Hello user! Please enter an integer between 1 and 1290 inclusive: ");

                bool validInput = false;
                while (!validInput)
                {
                    if (int.TryParse(Console.ReadLine(), out userInt) && userInt > 0 && userInt <= 1290)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.Write("Please enter a valid integer: ");
                    }
                }

                Console.WriteLine("\nNumber\t\tSquared\t\tCubed\n");

                for (int i = 1; i <= userInt; i++)
                {
                    int num = i;
                    int square = (int)pow(i, 2);
                    int cube = (int)pow(i, 3);

                    Console.WriteLine($"{num}\t\t{square}\t\t{cube}");
                }
                
                Console.Write("\nWould you like to input another integer? (y/n) ");

                validInput = false;
                while (!validInput)
                {
                    string userInput = Console.ReadLine().ToLower();

                    if (userInput == "y")
                    {
                        validInput = true;
                    }
                    else if (userInput == "n")
                    {
                        validInput = true;
                        run = false;
                    }
                    else
                    {
                        Console.Write("I'm sorry, please enter (y/n): ");
                    }
                }
            }

            Console.WriteLine("\nThanks for using my program!");
        }
    }
}
