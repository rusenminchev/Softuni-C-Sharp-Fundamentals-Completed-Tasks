using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Fance_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string regex = @"^@#+[A-Z][A-Za-z0-9]+@#+$";
            

            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                string prodGroup = string.Empty;
                Match validBarcodes = Regex.Match(barcode, regex);

                if (validBarcodes.Success)
                {
                    for (int j = 0; j < barcode.Length; j++)
                    {

                        if (char.IsDigit(barcode[j]))
                        {
                            prodGroup += barcode[j];
                        }
                        

                    }

                    if (string.IsNullOrEmpty(prodGroup))
                    {
                        prodGroup = "00";
                    }

                    Console.WriteLine($"Product group: {prodGroup}");
                   
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

        }
    }
}
