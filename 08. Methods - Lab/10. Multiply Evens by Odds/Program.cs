using System;
using System.Linq;
using System.Reflection;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            number = Math.Abs(number);

            
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }


        static int GetSumOfEvenDigits(int number)
        {
            string holder = number.ToString();
            int evenSum = 0;
            for (int i = 0; i < holder.Length; i++)
            {

                int currentDigit = int.Parse(holder[i].ToString());
                if (currentDigit % 2 == 0)
                {
                    evenSum += currentDigit;
                }
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            string holder = number.ToString();
            int oddSum = 0;
            for (int i = 0; i < holder.Length; i++)
            {

                int currentDigit = int.Parse(holder[i].ToString());
                if (currentDigit % 2 == 1)
                {
                    oddSum += currentDigit;
                }
            }

            return oddSum;

        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
           return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }
    }
}
