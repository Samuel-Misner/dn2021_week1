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
                Console.Write("Hello user! Please enter an integer: ");
                bool validInput = false;
                while (!validInput)
                {
                    if (int.TryParse(Console.ReadLine(), out userInt) && userInt > 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.Write("Please enter a valid integer: ");
                    }
                }

                Console.WriteLine("Number\t\tSquared\t\tCubed");
                Console.WriteLine("");

                for (int i = 1; i <= userInt; i++)
                {
                    Console.WriteLine((i) + "\t\t" + (i * i) + "\t\t" + (i * i * i));
                }

                Console.WriteLine("");
                Console.Write("Would you like to input another integer? (y/n) ");

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

            Console.WriteLine("")
            Console.WriteLine("Thanks for using my program!");
        }
    }
}
