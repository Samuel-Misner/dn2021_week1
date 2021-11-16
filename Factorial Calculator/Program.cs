using System;

namespace Factorial_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            bool run = true;

            Console.WriteLine("Welcome to my program!");

            while (run)
            {

                int userInt = 0;

                Console.Write("Please enter an integer between 1 and 20 inclusive: ");

                bool validInput = false;
                while (!validInput)
                {
                    if (int.TryParse(Console.ReadLine(), out userInt) && userInt >= 1 && userInt <= 20)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.Write("I'm sorry, please enter a valid integer between 1 and 20 inclusive: ");
                    }
                }

                long factorial = 1;

                for (int i = 1; i <= userInt; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine("The factorial of your number is " + factorial + ".");
                Console.Write("Would you like to find the factorial of another number? (y/n) ");

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
                        Console.Write("I'm sorry, please enter (y/n) ");
                    }
                }
            }

            Console.WriteLine("Thanks for using my program!");
        }
    }
}
