using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";

            string input = Console.ReadLine();

            MatchCollection matchedPhonenNumbers = Regex.Matches(input, pattern);

            List<string> matchedNumbers = new List<string>();

            foreach (Match phoneNum in matchedPhonenNumbers)
            {
                matchedNumbers.Add(phoneNum.Value);
            }
            Console.WriteLine(String.Join(", ", matchedNumbers));
        }
    }
}
