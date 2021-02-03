using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = GivePowerToTheNumber(number, power);
            Console.WriteLine(result);
        }

        static double GivePowerToTheNumber(double num, double pow)
        {
            double originalNum = num;

            for (int i = 1; i < pow; i++)
            {
                num = num * originalNum;       
            }
            return num;
        }
    }
}
