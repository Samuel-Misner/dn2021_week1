using System;

namespace Pig_Latin
{
    class Program
    {
        static bool StartsWithVowel(string word)
        {
            char c = word.ToLower()[0];
            return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
        }
        static string PigLatinTranslator(string word)
        {
            if (word.Length > 0)
            {
                string lower = word.ToLower();
                if (StartsWithVowel(word))
                {
                    return $"{word}way";
                }
                else
                {
                    return $"{word.Substring(1, word.Length - 1)}{word[0]}ay";
                }
            }
            else
            {
                return "";
            }
        }
        static void Main(string[] args)
        {
            bool run = true;

            Console.WriteLine("Welcome to the Pig Latin translator!");

            while (run)
            {
                Console.Write("Please enter a word or phrase to be translated: ");

                string userInput = Console.ReadLine();
                string[] words = userInput.Split(" ");

                Console.WriteLine("");

                for (int i = 0; i < words.Length; i++)
                {
                    if (i != words.Length - 1)
                    {
                        Console.Write($"{PigLatinTranslator(words[i])} ");
                    }
                    else
                    {
                        Console.WriteLine($"{PigLatinTranslator(words[i])}");
                    }
                }

                Console.Write($"\nWould you like to translate another word? (y/n) ");

                bool validInput = false;
                while (!validInput)
                {
                    userInput = Console.ReadLine().ToLower();
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
                        Console.Write("I'm sorry, pleaes enter (y/n) ");
                    }
                }
            }
            Console.WriteLine("\nThank you for using my Pig Latin Translator!");
        }
    }
}
