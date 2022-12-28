using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string operation = Console.ReadLine();

            while (operation!="End")
            {
                string[] currentOperation = operation.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (currentOperation[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(currentOperation[1]));
                        break;
                    case "Insert":
                        if (int.Parse(currentOperation[2])<0 || int.Parse(currentOperation[2])>numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(int.Parse(currentOperation[2]), int.Parse(currentOperation[1]));
                        }
                        break;
                    case "Remove":
                        if (int.Parse(currentOperation[1]) <0 || int.Parse(currentOperation[1]) > numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(int.Parse(currentOperation[1]));
                        }
                        break;
                    case "Shift":
                        int count = int.Parse(currentOperation[2]);
                        if (currentOperation[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                            }
                        }
                        else //right
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Insert(0, numbers[numbers.Count - 1]);
                                numbers.RemoveAt(numbers.Count-1);
                            }
                        }

                        break;
                }

                operation = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
