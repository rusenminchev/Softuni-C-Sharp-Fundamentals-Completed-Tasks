using System;

namespace _10_Top_Int_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n1; i++)
            {
                if (IsDevidesBy8(i) && (IsItContainsOddNum(i)))
                {
                    Console.WriteLine(i);
                }
            }


        }

        static bool IsDevidesBy8(int n1)
        {
            bool IsItValid = false;
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
                        IsItValid = true;
                    }

                }
                digitsSum = 0;
            }
            return IsItValid;
        }

        static bool IsItContainsOddNum(int n1)
        {
            bool IsItValid = false;
            for (int i = 0; i < n1; i++)
            {
                string numberToString = i.ToString();
                for (int j = 0; j < numberToString.Length; j++)
                {
                    int currentDigit = int.Parse(numberToString[j].ToString());
                    if (currentDigit % 2 == 1)
                    {
                        IsItValid = true;
                    }
                }
            }

            return IsItValid;
        }
    }
}
