using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();
            bool listIschanged = false;
            while (command != "end")
            {
                string[] currentCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (currentCommand[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(currentCommand[1]));
                        listIschanged = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(currentCommand[1]));
                        listIschanged = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(currentCommand[1]));
                        listIschanged = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(currentCommand[1]);
                        int indexToInsertAt = int.Parse(currentCommand[2]);
                        numbers.Insert(indexToInsertAt, numberToInsert);
                        listIschanged = true;
                        break;
                    case "Contains":
                        CheckContains(int.Parse(currentCommand[1]), numbers);

                        break;
                    case "PrintEven":
                        List<int> evenNumbers = EvenOddNumbers(currentCommand[0], numbers);
                        Console.WriteLine(String.Join(" ", evenNumbers));
                        break;
                    case "PrintOdd":
                        List<int> oddNumbers = EvenOddNumbers(currentCommand[0], numbers);
                        Console.WriteLine(String.Join(" ", oddNumbers));

                        break;
                    case "GetSum":
                        int sum = numbers.Sum();
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = currentCommand[1];
                        int number = int.Parse(currentCommand[2]);
                        List<int> filteredNumbers = GetFiltered(condition, number, numbers);
                        Console.WriteLine(String.Join(" ", filteredNumbers));
                        break;

                }
                command = Console.ReadLine();
            }
            if (listIschanged)
            {
                Console.WriteLine(String.Join(" ", numbers));

            }
        }

        private static List<int> GetFiltered(string condition, int number, List<int> numbers)
        {
            List<int> filteredList = new List<int>();
            switch (condition)
            {
                case "<":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < number)
                        {
                            filteredList.Add(numbers[i]);
                        }
                    }
                    break;
                case ">":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > number)
                        {
                            filteredList.Add(numbers[i]);
                        }
                    }
                    break;
                case ">=":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] >= number)
                        {
                            filteredList.Add(numbers[i]);
                        }
                    }
                    break;
                case "<=":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= number)
                        {
                            filteredList.Add(numbers[i]);
                        }
                    }
                    break;


            }
            return filteredList;
        }

        private static List<int> EvenOddNumbers(string command, List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
                else
                {
                    oddNumbers.Add(numbers[i]);
                }
            }
            if (command == "PrintEven")
            {
                return evenNumbers;
            }
            else
            {
                return oddNumbers;
            }
        }

        private static void CheckContains(int currentNum, List<int> numbers)
        {
            if (numbers.Contains(currentNum))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
    }
}
