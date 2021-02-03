using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            // Докато не получим команда ще получаваме ДНК поредици сплитнати с !
            // Трябва да намерим най-дългата поредица от 1 , ако са повече с една и съша дължина да принтираме тази с най-ляв начален индекс.
            // Ако иматакива с една и съща дължина и един и същ стартов индекс принтираме тази поредица с най-голяма сума на елементите в нея.
            // След получаване на командата принтираме събрана информация в посочения формат.

            int lenthOfTheSeq = int.Parse(Console.ReadLine());

           

            int bestLegth = 0;
            int bestStartIndex = 0;
            int biggestSeqSum = 0;
            int seqCounter = 0;
            int bestSeqIndex = 0;

            string command = Console.ReadLine();

            int[] bestSeq = new int[lenthOfTheSeq];

            while (command != "Clone them!")
            {

                int[] currentSequence = command.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                seqCounter++;

                int lenght = 1;
                int bestCurrentLength = 1;
                int startIndex = 0;
                int currentSum = 0;
                

                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    
                    if (currentSequence[i] == currentSequence[i + 1])
                    {
                        lenght++;
                    }
                    else
                    {
                        lenght = 1;
                    }
                    if (lenght > bestCurrentLength)
                    {
                        bestCurrentLength = lenght;
                        startIndex = i;

                    }

                    currentSum += currentSequence[i];
                }

                currentSum += currentSequence[lenthOfTheSeq - 1];

                if (bestCurrentLength > bestLegth)
                {
                    bestLegth = bestCurrentLength;
                    bestStartIndex = startIndex;
                    biggestSeqSum = currentSum;
                    bestSeqIndex = seqCounter;
                    bestSeq = currentSequence.ToArray();
                }

                else if (bestCurrentLength == bestLegth)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLegth = bestCurrentLength;
                        bestStartIndex = startIndex;
                        biggestSeqSum = currentSum;
                        bestSeqIndex = seqCounter;
                        bestSeq = currentSequence.ToArray();
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (currentSum > biggestSeqSum)
                        {
                            bestLegth = bestCurrentLength;
                            bestStartIndex = startIndex;
                            biggestSeqSum = currentSum;
                            bestSeqIndex = seqCounter;
                            bestSeq = currentSequence.ToArray();
                        }
                    
                    }
                }

                


                command = Console.ReadLine();
            }


            Console.WriteLine($"Best DNA sample {bestSeqIndex} with sum: {biggestSeqSum}.");
            Console.WriteLine(String.Join(' ', bestSeq));

        }
    }
}
