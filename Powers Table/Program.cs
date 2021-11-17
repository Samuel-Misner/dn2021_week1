using System;

namespace Powers_Table
{
    class Program
    {
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
                    int square = (int)Math.Pow(i, 2);
                    int cube = (int)Math.Pow(i, 3);

                    Console.WriteLine($"{num}\t\t{square}\t\t{cube}");
                }
                
                Console.Write("\nWould you like to input another integer? (y/n) ");

                validInput = false;
                while (!validInput)
                {
                    string userInput = Console.ReadLine();

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
