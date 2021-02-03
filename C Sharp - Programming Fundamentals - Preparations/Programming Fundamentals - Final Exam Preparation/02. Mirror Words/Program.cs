using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Program
    {
        public static MatchCollection MatchCollection { get; private set; }

        static void Main(string[] args)
        {
            string pattern = @"([@#])([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1";
            string input = Console.ReadLine();

            List<string> forPrint = new List<string>();
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count == 0)
            {

                Console.WriteLine("No word pairs found!");
            }
            else if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            foreach (Match words in matches)
            {

                string wordOne = words.Groups[2].Value;
                string wordTwo = words.Groups[3].Value;

                var wordOneRev = new string(wordOne.Reverse().ToArray());
                var wordTwoRev = new string(wordTwo.Reverse().ToArray());

                if (wordOneRev == wordTwo || wordTwoRev == wordOne)
                {
                    string mirrorPairs = wordOne + " <=> " + wordTwo;
                    forPrint.Add(mirrorPairs);
                }
            }


            if (forPrint.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else if (forPrint.Count > 0)
            {
                
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(String.Join(", ", forPrint));
            }
        }
    }
}
