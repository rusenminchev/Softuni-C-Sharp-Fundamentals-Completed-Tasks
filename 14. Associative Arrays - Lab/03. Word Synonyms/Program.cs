using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> wordsAndSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string inputWord = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (wordsAndSynonyms.ContainsKey(inputWord))
                {
                    wordsAndSynonyms[inputWord].Add(synonym);
                }
                else
                {
                    wordsAndSynonyms.Add(inputWord, new List<string>());
                    wordsAndSynonyms[inputWord].Add(synonym);
                }
            }

            foreach (var word in wordsAndSynonyms)
            {
                Console.WriteLine($"{word.Key} - " + String.Join(", ", word.Value));
            }
        }
    }
}
