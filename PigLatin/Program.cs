using System;

namespace Pig_Latin
{
    class Program
    {
        static bool IsAVowel(char c)
        {
            return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
        }

        static int FindFirstVowel(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (IsAVowel(word[i]))
                {
                    return i - 1;
                }
            }
            return 0;
        }
        static string PigLatinTranslator(string word)
        {
            if (word.Length > 0)
            {
                string lower = word.ToLower();
                if (IsAVowel(word[0]))
                {
                    return $"{word}way";
                }
                else
                {
                    int vowelIndex = FindFirstVowel(word);
                    return $"{word.Substring(vowelIndex + 1, word.Length - (vowelIndex + 1))}{word.Substring(0, vowelIndex + 1)}ay";
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
