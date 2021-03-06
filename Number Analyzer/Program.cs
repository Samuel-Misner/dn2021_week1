using System;

namespace Number_Analyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            int userInt = 0;

            Console.Write("Hi! Please enter your name: ");

            string name = Console.ReadLine();

            Console.Write(name + ", please enter an integer between 1 and 100: ");

            bool validInput = false;
            while (!validInput)
            {
                if (int.TryParse(Console.ReadLine(), out userInt) && userInt >= 1 && userInt <= 100)
                {
                    validInput = true;
                }
                else
                {
                    Console.Write(name + ", please enter a valid integer between 1 and 100: ");
                }
            }

            if (userInt % 2 == 1)
            {
                if (userInt < 60)
                {
                    Console.WriteLine("Good news " + name + "! Your number is Odd and less than 60.");
                }
                else
                {
                    Console.WriteLine("Good news " + name + "! Your number is Odd and greater than 60.");
                }
            }
            else
            {
                if (userInt <= 24)
                {
                    Console.WriteLine("Good news " + name + "! Your number is Even and less than 25.");
                }
                else if (userInt <= 60)
                {
                    Console.WriteLine("Good news " + name + "! Your number is Even and between 26 and 60 inclusive.");
                }
                else
                {
                    Console.WriteLine("Good news " + name + "! Your number is Even and greater than 60.");
                }
            }

            Console.WriteLine("Thanks for using my program " + name + "!");
        }
    }
}
