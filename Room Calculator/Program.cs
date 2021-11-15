using System;

namespace VarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = 0;
            double length = 0;
            double height = 0;

            Console.Write("Please enter the width of your room: ");

            bool validInput = false;
            while (!validInput)
            {
                if (double.TryParse(Console.ReadLine(), out width))
                {
                    validInput = true;
                }
                else
                {
                    Console.Write("Please enter a valid width: ");
                }
            }

            Console.Write("Please enter the length of your room: ");

            validInput = false;
            while (!validInput)
            {
                if (double.TryParse(Console.ReadLine(), out length))
                {
                    validInput = true;
                }
                else
                {
                    Console.Write("Please enter a valid length");
                }
            }

            Console.Write("Please enter the height of your room: ");

            validInput = false;
            while (!validInput)
            {
                if (double.TryParse(Console.ReadLine(), out height))
                {
                    validInput = true;
                }
                else
                {
                    Console.Write("Please enter a valid height: ");
                }
            }

            double perimeter = (width + length) * 2;
            double area = (width * length);
            double surfaceArea = ((width * length) * 2) + ((width * height) * 2) + ((length * height) * 2);
            double volume = (width * length * height);

            string size;

            if (area <= 250)
            {
                size = "small";
            }
            else if (area <= 650)
            {
                size = "medium";
            }
            else
            {
                size = "large";
            }

            Console.WriteLine("The perimeter of your room is " + perimeter);
            Console.WriteLine("The area of your room is " + area);
            Console.WriteLine("The surface area of your room is " + surfaceArea);
            Console.WriteLine("The volume of your room is " + volume);
            Console.WriteLine("The size of your room is " + size);

        }
    }
}
