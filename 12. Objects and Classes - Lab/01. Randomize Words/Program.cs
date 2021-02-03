using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Randomize_Words
{
    class Program
    {
        public static void Main(string[] args)
        {
            Randomizer words = new Randomizer();
            words.words = Console.ReadLine().Split();
            words.Randomiser();
            words.PrintWords();
        }

        public class Randomizer
        {
            public string[] words;
            public void Randomiser()
            {
                Random rand = new Random();
                for (int i = 0; i < words.Length; i++)
                {
                    int randomPisition = rand.Next(0, words.Length);
                    string temp = words[i];
                    words[i] = words[randomPisition];
                    words[randomPisition] = temp;
                }
            }

            public void PrintWords()
            {
                Console.WriteLine(string.Join(Environment.NewLine, words));
            }
        }
    }
}
