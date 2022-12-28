using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] currentCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = currentCommand[0];



                if (action == "exchange")
                {
                    int index = int.Parse(currentCommand[1]);
                    if (index < 0 || index > initialArray.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        ExchangeArray(initialArray, index);
                        //Console.WriteLine(String.Join(' ', initialArray));
                    }
                }
                else if (action == "max")
                {
                    string evenOrOdd = currentCommand[1];
                    if (evenOrOdd == "even")
                    {
                        int maxEven = GetMaxEvenIndex(initialArray);
                        if (maxEven == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(maxEven);
                        }


                    }
                    else // == "odd"
                    {
                        int maxOdd = GetMaxOddIndex(initialArray);
                        if (maxOdd == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(maxOdd);

                        }
                    }
                }
                else if (action == "min")
                {
                    string evenOrOdd = currentCommand[1];
                    if (evenOrOdd == "even")
                    {
                        int minEven = GetMinEvenIndex(initialArray);
                        if (minEven == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(minEven);

                        }
                    }
                    else //odd
                    {
                        int minOdd = GetMinOddIndex(initialArray);
                        if (minOdd == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(minOdd);

                        }
                    }

                }
                else if (action == "first")
                {
                    int count = int.Parse(currentCommand[1]);
                    if (count > initialArray.Length || count < 0)
                    {
                        Console.WriteLine("Invalid count");
                        
                    }
                    else
                    {
                        if (currentCommand[2] == "even")
                        {
                            int evenElementsCont = ElementsCount(initialArray, currentCommand[2]);
                            //if (evenElementsCont == 0)
                            //{
                            //    Console.WriteLine("[]");
                            //}
                            int outputArrLength = OutPutArrayLength(count, evenElementsCont);
                            int[] outputArray = GetOutputArray(outputArrLength, initialArray, currentCommand[0], currentCommand[2]);
                            Console.WriteLine($"[{String.Join(", ", outputArray)}]");


                        }
                        else //odd
                        {
                            int oddElementsCount = ElementsCount(initialArray, currentCommand[2]);
                            //if (oddElementsCount == 0)
                            //{
                            //    Console.WriteLine("[]");
                            //}
                            int outputArrLength = OutPutArrayLength(count, oddElementsCount);
                            int[] outputArray = GetOutputArray(outputArrLength, initialArray, currentCommand[0], currentCommand[2]);
                            Console.WriteLine($"[{String.Join(", ", outputArray)}]");


                        }
                    }

                    

                }
                else if (action == "last")
                {
                    int count = int.Parse(currentCommand[1]);
                    if (count > initialArray.Length || count < 0)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (currentCommand[2] == "even")
                        {
                            int evenElementsCont = ElementsCount(initialArray, currentCommand[2]);
                            //if (evenElementsCont == 0)
                            //{
                            //   Console.WriteLine("[]");
                            //}
                            int outputArrLength = OutPutArrayLength(count, evenElementsCont);
                            int[] outputArray = GetOutputArray(outputArrLength, initialArray, currentCommand[0], currentCommand[2]);
                            Console.WriteLine($"[{String.Join(", ", outputArray)}]");




                        }
                        else //odd
                        {
                            int oddElementsCount = ElementsCount(initialArray, currentCommand[2]);
                            //if (oddElementsCount == 0)
                            //{
                            //    Console.WriteLine("[]");
                            //}
                            int outputArrLength = OutPutArrayLength(count, oddElementsCount);
                            int[] outputArray = GetOutputArray(outputArrLength, initialArray, currentCommand[0], currentCommand[2]);
                            Console.WriteLine($"[{String.Join(", ", outputArray)}]");

                        }
                    }
                   


                }


                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", initialArray)}]");
        }

        private static int[] GetOutputArray(int outputArrLength, int[] initialArray, string firstOrLast, string evenOrOdd)
        {
            int[] outputArray = new int[outputArrLength];
            if (firstOrLast == "first" && evenOrOdd == "even")
            {
                int count = 0;
                for (int index = 0; index < initialArray.Length; index++)
                {
                    if (initialArray[index] % 2 == 0)
                    {
                        outputArray[count] = initialArray[index];
                        count++;
                        if (count == outputArrLength)
                        {
                            break;
                        }
                    }
                }
            }
            if (firstOrLast == "first" && evenOrOdd == "odd")
            {
                int count = 0;
                for (int index = 0; index < initialArray.Length; index++)
                {
                    if (initialArray[index] % 2 != 0)
                    {
                        outputArray[count] = initialArray[index];
                        count++;
                        if (count == outputArrLength)
                        {
                            break;
                        }
                    }
                }
            }
            if (firstOrLast=="last" && evenOrOdd == "even")
            {
                int count = outputArrLength-1;
                for (int index = initialArray.Length-1; index >= 0; index--)
                {
                    if (initialArray[index] % 2 == 0)
                    {
                        outputArray[count] = initialArray[index];
                        count--;
                        if (count== -1)
                        {
                            break;
                        }
                    }
                }
            
            }
            if (firstOrLast == "last" && evenOrOdd == "odd")
            {
                int count = outputArrLength - 1;
                for (int index = initialArray.Length - 1; index >= 0; index--)
                {
                    if (initialArray[index] % 2 != 0)
                    {
                        outputArray[count] = initialArray[index];
                        count--;
                        if (count == -1)
                        {
                            break;
                        }
                    }
                }

            }
            return outputArray;
        }

        static int OutPutArrayLength(int count, int evenElementsCont)
        {
            int length = 0;
            if (count > evenElementsCont)
            {
                length = evenElementsCont;
            }
            else
            {
                length = count;
            }
            return length;
        }

        private static int ElementsCount(int[] initialArray, string evenOrOdd)
        {
            int evenCount = 0;
            int oddCount = 0;
            for (int index = 0; index < initialArray.Length; index++)
            {
                if (initialArray[index] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            int result = evenOrOdd == "even" ? evenCount : oddCount;
            return result;

        }

        static int GetMinOddIndex(int[] initialArray)
        {
            int minOddIndex = -1;
            int minOddNumber = int.MaxValue;

            for (int index = 0; index < initialArray.Length; index++)
            {
                if (initialArray[index] % 2 != 0)
                {
                    if (initialArray[index] <= minOddNumber)
                    {
                        minOddNumber = initialArray[index];
                        minOddIndex = index;
                    }
                }
            }
            return minOddIndex;
        }



        static int GetMinEvenIndex(int[] initialArray)
        {
            int minEvenIndex = -1;
            int minEvenNumber = int.MaxValue;
            for (int index = 0; index < initialArray.Length; index++)
            {
                if (initialArray[index] % 2 == 0)
                {
                    if (initialArray[index] <= minEvenNumber)
                    {
                        minEvenNumber = initialArray[index];
                        minEvenIndex = index;
                    }
                }
            }
            return minEvenIndex;
        }

        static int GetMaxOddIndex(int[] initialArray)
        {
            int maxOddIndex = -1;
            int maxOddNumber = 0;
            for (int index = 0; index < initialArray.Length; index++)
            {
                if (initialArray[index] % 2 != 0)
                {
                    if (initialArray[index] >= maxOddNumber)
                    {
                        maxOddNumber = initialArray[index];
                        maxOddIndex = index;
                    }
                }
            }

            return maxOddIndex;
        }

        static int GetMaxEvenIndex(int[] initialArray)
        {
            int maxEvenIndex = -1;
            int maxEvenNumber = 0;
            for (int index = 0; index < initialArray.Length; index++)
            {
                if (initialArray[index] % 2 == 0)
                {
                    if (initialArray[index] >= maxEvenNumber)
                    {
                        maxEvenNumber = initialArray[index];
                        maxEvenIndex = index;
                    }
                }
            }
            return maxEvenIndex;
        }

        static void ExchangeArray(int[] initialArray, int index)
        {   //1 2 3   4 5  => 2  // 1 3    5 7 9 => 1
            //4 5   1 2 3        // 5 7 9    1 3 
            int[] leftArray = new int[initialArray.Length - 1 - index];
            for (int i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = initialArray[index + 1 + i];
            }
            int[] rightArray = new int[initialArray.Length - leftArray.Length];
            for (int k = 0; k < rightArray.Length; k++)
            {
                rightArray[k] = initialArray[k];
            }
            int[] manipulatedArray = leftArray.Concat(rightArray).ToArray();

            Array.Copy(manipulatedArray, initialArray, manipulatedArray.Length);

            //Console.WriteLine(String.Join(',', manipulatedArray));

        }
    }
}
