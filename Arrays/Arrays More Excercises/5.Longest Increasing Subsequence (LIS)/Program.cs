using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace _5.Longest_Increasing_Subsequence__LIS_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] sequence = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

            int[] lis;
            int[] len = new int[sequence.Length];
            int[] prev = new int[sequence.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int index = 0; index < sequence.Length; index++)
            {
                len[index] = 1;
                prev[index] = -1;
                for (int i = 0; i < index; i++)
                {
                    if (sequence[i] < sequence[index] && len[i] >= len[index])
                    {//1 2 5 3 5 2 4 1
                        len[index] = 1 + len[i];
                        prev[index] = i; 
                    }
                }
                if (len[index] > maxLength)
                {
                    maxLength = len[index];
                    lastIndex = index;
                }
            }
            lis = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                lis[i] = sequence[lastIndex];
                lastIndex = prev[lastIndex];
            }
            Array.Reverse(lis);
            Console.WriteLine(string.Join(' ', lis));

        }
    }
}
