using System;
using System.Reflection.Emit;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());   

            float biggestModel = float.MinValue;
            string biggestModelName = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                float volume = (float)(Math.PI * Math.Pow(radius, 2) * height);

                if (volume > biggestModel)
                {
                    biggestModel = volume;
                    biggestModelName = model;
                }
            }

            Console.WriteLine(biggestModelName);
        }
    }
}
