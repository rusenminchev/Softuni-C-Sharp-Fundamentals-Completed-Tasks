using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordsToLower = word.ToLower();

                if (count.ContainsKey(wordsToLower))
                {
                    count[wordsToLower]++;
                }
                else
                {
                    count.Add(wordsToLower, 1);
                }
            }

            foreach (var word in count)
            {
                if (word.Value % 2 == 1)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}
