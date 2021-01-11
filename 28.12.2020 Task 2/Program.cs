using System;
using System.Collections.Generic;
using System.Linq;

namespace _28._12._2020_Task_2
{
    class Program
    {
        public delegate bool FilterString(string word);
        public delegate string ReplaceString(string word);
        static void Main(string[] args)
        {
            List<string> words = new List<string>()
            {
                "salam", "kompyuter", "uca", "bulaq"
            };

            //select words that contain 'a' letters
            List<string> parsedWord = ParseWordList(words, s => s.Contains("a"));
            foreach (var item in parsedWord)
            {
                Console.WriteLine(item);
            }

            //select words that doesn't contain 'B' letters;
            List<string> parseWord2 = ParseWordList(words, s => s.Contains("b"));
            foreach (var item in parseWord2)
            {
                Console.WriteLine(item);
            }

            //select words that have more than 5 characters;
            List<string> parseWord3 = ParseWordList(words, s => s.Length > 5);
            foreach (var item in parseWord3)
            {
                Console.WriteLine(item);
            }

            //remove all words with letter 'u' and return list;
            List<string> parseWord4 = StringReturnFunction(words, s => s.Replace("u", "")).ToList();
            foreach (var item in parseWord4)
            {
                Console.WriteLine(item);
            }

            //replace all words with letter 'o' with 'NOT ACCEPTED' and return list;
            List<string> parseWord5 = StringReturnFunction(words, s => s.Replace("o", "NOT ACCEPTED")).ToList();
            foreach (var item in parseWord5)
            {
                Console.WriteLine(item);
            }


        }



        static List<string> ParseWordList(List<string> words, FilterString filter)
        {
            List<string> filteredList = new List<string>();
            foreach (string word in words)
            {
                if (filter.Invoke(word) == true)

                {
                    filteredList.Add(word);

                }
            }
            return filteredList;

        }
            static List<string> StringReturnFunction(List<string> words, ReplaceString str)
        {
            List<string> filteredList = new List<string>();
            foreach (string word in words)
            {
                string s;
                s = str.Invoke(word);
                filteredList.Add(s);

            }
            return filteredList;
        }
    }
}

