using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());

            GetTopInts(n1);
        }

        static void GetTopInts(int n1)
        {
            int digitsSum = 0;
            for (int i = 0; i < n1; i++)
            {
                string numberToString = i.ToString();
                for (int j = 0; j < numberToString.Length; j++)
                {
                    int currentDigit = int.Parse(numberToString[j].ToString());

                    digitsSum += currentDigit;
                    if (digitsSum % 8 == 0)
                    {
                        if (currentDigit % 2 == 1)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                digitsSum = 0;
            }
        }
    }
}
