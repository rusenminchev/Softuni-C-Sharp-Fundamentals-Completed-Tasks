using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            List<string> evenWords = new List<string>();

            foreach (var word in words)
            {
                if (word.Length % 2 == 0)
                {
                    evenWords.Add(word);
                }
            }

            Console.WriteLine(String.Join("\n", evenWords ));

        }
    }
}
