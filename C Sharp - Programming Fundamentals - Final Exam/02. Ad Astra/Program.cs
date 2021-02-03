using System;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalCalories = 0;


            Regex regex = new Regex(@"([#|])([A-Za-z\s]+)\1(\d{2}\/\d{2}\/\d{2})\1(\d+)\1");

            MatchCollection validFood = regex.Matches(input);

            foreach (Match food in validFood)
            {
                totalCalories += int.Parse(food.Groups[4].Value);
            }

            int daysYouCanLast = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {daysYouCanLast} days!");

            foreach (Match food in validFood)
            {
                string item = food.Groups[2].Value;
                string expDate = food.Groups[3].Value;
                int calories = int.Parse(food.Groups[4].Value);

                Console.WriteLine($"Item: {item}, Best before: {expDate}, Nutrition: {calories}");
            }
        }
    }
}
