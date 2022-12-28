using System;
using System.Linq;
using System.Collections.Generic;


namespace _5._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = bomb[0];
            int power = bomb[1];
            int index = -1;

            while (numbers.Contains(bombNumber))
            {
                index = numbers.IndexOf(bombNumber);
                int lefDetonation = power;
                int rightDetonation = power;
                if (index - lefDetonation < 0)
                {
                    lefDetonation = index;
                }
                if (rightDetonation+index>= numbers.Count)
                {
                    rightDetonation = numbers.Count - index - 1;
                }
                numbers.RemoveRange(index - lefDetonation, lefDetonation + rightDetonation + 1);
            }
            Console.WriteLine(numbers.Sum());
           
        }
    }
}


