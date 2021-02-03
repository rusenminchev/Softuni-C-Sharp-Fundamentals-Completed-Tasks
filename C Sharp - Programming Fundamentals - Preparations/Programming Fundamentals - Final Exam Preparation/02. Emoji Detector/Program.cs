using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([:]{2}|[*]{2})([A-Z][a-z]{2,})(\1)";
            string digitsPattern = @"\d";
            string input = Console.ReadLine();

            MatchCollection validEmojis = Regex.Matches(input, pattern);
            MatchCollection digits = Regex.Matches(input, digitsPattern);

            List<string> coolestEmojis = new List<string>();
            List<string> coolestEmojisForPrint = new List<string>();

            foreach (Match emoji in validEmojis)
            {

                coolestEmojis.Add(emoji.Groups[2].Value);
                coolestEmojisForPrint.Add(emoji.ToString());
            }

            var digitsProd = digits.Select(x => int.Parse(x.Value)).ToList();
            int tresholdNum = 1;

            for (int i = 0; i < digitsProd.Count; i++)
            {
                tresholdNum *= digitsProd[i];
            }

            foreach (var emo in coolestEmojis)
            {
                int emojiCoolness = 0;

                for (int i = 0; i < emo.Length; i++)
                {
                    emojiCoolness += (char)(emo[i]);
                }
                    
                if (emojiCoolness < tresholdNum)
                {
                    int index = coolestEmojis.IndexOf(emo);
                    coolestEmojisForPrint.RemoveAt(index);
                }
            }

            Console.WriteLine($"Cool threshold: {tresholdNum}");
            Console.WriteLine($"{coolestEmojis.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(String.Join(Environment.NewLine, coolestEmojisForPrint));
        }
    }
}
