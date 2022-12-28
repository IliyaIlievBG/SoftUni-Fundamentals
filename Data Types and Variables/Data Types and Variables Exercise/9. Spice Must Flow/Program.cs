using System;

namespace _9._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yieldOfMine = int.Parse(Console.ReadLine());
            int miningDays = 0;
            int extractedSpice = 0;


            while (yieldOfMine>=100)
            {
                miningDays++;
                extractedSpice += yieldOfMine - 26;//26 consumed by the workers for a day;
                yieldOfMine -= 10;

            }
            extractedSpice -= 26; //consumed by the workers the last day before the mine is abandoned
            int spiceLeft = extractedSpice < 0 ?  0 : extractedSpice;
            Console.WriteLine(miningDays);
            Console.WriteLine(spiceLeft);
        }
    }
}
