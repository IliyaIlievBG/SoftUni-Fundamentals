﻿using System;

namespace _2._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());

            int[] numbers = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int l = arraySize-1; l >= 0; l--)
            {
                Console.Write($"{numbers[l]} ");
            }
        }
    }
}
