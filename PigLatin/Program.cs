using System;
using System.Collections.Generic;

namespace Pig_Latin
{
    class Program
    {
        static bool IsAVowel(char c)
        {
            c = c.ToString().ToLower()[0];
            return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
        }

        static bool IsPunctuation(char c)
        {
            return (c == '.' || c == ',' || c == '!' || c == '?');
        }

        static int FindFirstVowel(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (IsAVowel(word[i]))
                {
                    return i;
                }
            }
            return 0;
        }

        static bool WordContainsNum(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] - 0 >= '0' - 0 && word[i] - 0 <= '9' - 0)
                {
                    return true;
                }
            }
            return false;
        }

        static bool WordContainsAt(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '@')
                {
                    return true;
                }
            }
            return false;
        }

        static bool WordContainsPunctuation(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (IsPunctuation(word[i]))
                {
                    return true;
                }
            }
            return false;
        }

        static List<int> IndexesOfPunctuation(string word)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (IsPunctuation(word[i]))
                {
                    indexes.Add(i);
                }
            }
            return indexes;
        }

        static string PigLatinTranslator(string word)
        {

            if (word.Length > 0)
            {
                if (!(WordContainsNum(word)) && !(WordContainsAt(word)))
                {
                    string extraPunctuation = "";

                    if (WordContainsPunctuation(word))
                    {
                        List<int> indexes = IndexesOfPunctuation(word);

                        string returnString = "";

                        for (int i = 0; i < indexes.Count; i++)
                        {
                            if (i == 0)
                            {
                                returnString += word.Substring(0, indexes[i]);
                            }
                            else
                            {
                                returnString += word.Substring(indexes[i - 1] + 1, indexes[i] - (indexes[i - 1] + 1));
                            }
                        }
                        for (int i = 0; i < indexes.Count; i++)
                        {
                            extraPunctuation += word.Substring(indexes[i], 1);
                        }
                        word = returnString;
                    }
                    if (IsAVowel(word[0]))
                    {
                        word = $"{word}way";
                        if (extraPunctuation.Length > 0)
                        {
                            return word += extraPunctuation;
                        }
                        else
                        {
                            return word;
                        }
                    }
                    else
                    {
                        int vowelIndex = FindFirstVowel(word);
                        word = $"{word.Substring(vowelIndex, word.Length - vowelIndex)}{word.Substring(0, vowelIndex)}ay";
                        if (extraPunctuation.Length > 0)
                        {
                            return word += extraPunctuation;
                        }
                        else
                        {
                            return word;
                        }
                    }
                }
                else
                {
                    return word;
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

                Console.Write($"\nWould you like to translate another word or phrase? (y/n) ");

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
