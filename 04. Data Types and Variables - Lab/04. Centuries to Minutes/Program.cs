using Microsoft.VisualBasic;
using System;
using System.Numerics;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.2422);
            ulong hours = days * 24;
            int mins = (int)(hours * 60);

            Console.WriteLine($"{centuries} centuries = {years:f0} years = {days:f0} days = {hours:f0} hours = {mins:f0} minutes");

        }
    }
}
