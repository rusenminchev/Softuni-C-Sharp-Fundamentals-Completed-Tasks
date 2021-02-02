using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPokePower = int.Parse(Console.ReadLine());
            int mDistanceToTarget = int.Parse(Console.ReadLine());
            byte yExhaustionFactor = byte.Parse(Console.ReadLine());

            int currentN = nPokePower;

            int targetCount = 0;

            while (currentN >= mDistanceToTarget)
            {
                currentN -= mDistanceToTarget;
                targetCount++;
                if (currentN == nPokePower / 2)
                {
                    if (yExhaustionFactor > 0)
                    {
                        currentN /= yExhaustionFactor;
                    }
                }
            }
            Console.WriteLine(currentN);
            Console.WriteLine(targetCount);
        }
    }
}
