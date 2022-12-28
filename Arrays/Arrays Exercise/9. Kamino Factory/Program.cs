using System;
using System.Linq;

namespace _9._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthDNA = int.Parse(Console.ReadLine());

            string input = Console.ReadLine(); //while input != "Clone them!" - receive DNA samples, divided by !

            int[] bestDNA = new int[lengthDNA];
            int bestSequenceOfOnes = 0;
            int maxSum = 0;
            int mostLeftIndex = 0;
            int samplesCount = 0;
            int bestSample = 0;

            while (input != "Clone them!")
            {
                samplesCount++;
                int[] currentDNAsample = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentStartingIndex = -1;
                int currentSequenceOfOnes = 0;
                int currentSum = currentDNAsample.Sum();

                for (int index = 0; index < currentDNAsample.Length-1; index++)
                {
                    if (currentDNAsample[index] ==1 && currentDNAsample[index+1]==1)
                    {
                       
                       
                        currentSequenceOfOnes++;
                        if (currentSequenceOfOnes>bestSequenceOfOnes)
                        {
                            bestSequenceOfOnes = currentSequenceOfOnes;
                            bestDNA = currentDNAsample;
                            bestSample = samplesCount;
                            currentStartingIndex = currentDNAsample[index];
                        }
                        else if (currentSequenceOfOnes == bestSequenceOfOnes && currentStartingIndex < mostLeftIndex)
                        {
                            mostLeftIndex = currentStartingIndex;
                            bestDNA = currentDNAsample;
                            bestSample = samplesCount;
                        }
                        else if (currentSequenceOfOnes == bestSequenceOfOnes && currentStartingIndex == mostLeftIndex && currentSum>maxSum)
                        {
                            maxSum = currentSum;
                            bestDNA = currentDNAsample;
                            bestSample = samplesCount;
                        }
                    }
                    else
                    {
                        currentStartingIndex = -1;
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestDNA.Sum()}.");
            Console.WriteLine(String.Join(" ", bestDNA));
        }
    }
}
