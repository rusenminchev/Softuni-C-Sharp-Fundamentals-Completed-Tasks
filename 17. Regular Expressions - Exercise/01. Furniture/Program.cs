using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @">>(?<product>[A-Za-z]+)<<(?<price>\d+\.?\d*)[!](?<quantity>\d+)";

            string input = Console.ReadLine();

            Dictionary<string, double> productInfo = new Dictionary<string, double>();

            while (input != "Purchase")
            {
                MatchCollection validMatches = Regex.Matches(input, regex);

                foreach (Match matches in validMatches)
                {
                    var productCost = double.Parse(matches.Groups["price"].Value) * int.Parse(matches.Groups["quantity"].Value);

                    productInfo.Add(matches.Groups["product"].Value, productCost);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            Console.WriteLine(String.Join(Environment.NewLine, productInfo.Keys));
            Console.WriteLine($"Total money spend: {productInfo.Values.Sum()}");

        }
    }
}
