using System;

namespace Number_Analyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            int userInt = 0;

            bool isOdd;

            Console.Write("Hi! Please enter your name: ");

            string name = Console.ReadLine();

            Console.Write(name + ", Please enter an integer between 1 and 100: ");

            bool validInput = false;
            while(!validInput)
            {
                if (int.TryParse(Console.ReadLine(), out userInt) && userInt >= 1 && userInt <= 100)
                {
                    validInput = true;
                } else
                {
                    Console.Write(name + ", Please enter a valid integer between 1 and 100: ");
                }
            }
            if (userInt%2 == 1)
            {
                isOdd = true;
            }else
            {
                isOdd = false;
            }
            if (isOdd)
            {
                if (userInt < 60)
                {
                    Console.WriteLine(name + ", your number is Odd and less than 60.");
                } else
                {
                    Console.WriteLine(name + ", your number is Odd and greater than 60.");
                }
            } else
            {
                if (userInt <= 24)
                {
                    Console.WriteLine(name + ", your number is Even and less than 25.");
                } else if (userInt <= 60)
                {
                    Console.WriteLine(name + ", your number is Even and between 26 and 60 inclusive.");
                } else
                {
                    Console.WriteLine(name + ", your number is Even and greater than 60.");
                }
            }

            Console.WriteLine(name + ", thanks for using my program!");

        }
    }
}
