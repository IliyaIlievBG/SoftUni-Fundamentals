using System;

namespace _1._Encrypt__Sort__and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char myChar = 't';
            //int myCharInt = myChar;
            //Console.WriteLine(myCharInt);

           int sequencesCount = int.Parse(Console.ReadLine()); //sequences count
            int[] finalSequencesOrder = new int[sequencesCount];

            for (int i = 0; i < sequencesCount; i++) //read sequences
            {
                char[] nextCharArray = Console.ReadLine().ToCharArray();
                int encryptedArraySum = 0;

                for (int index = 0; index < nextCharArray.Length; index++) //go through each element of next array and calculate its num
                {
                    int indexNum = 0;

                    if (nextCharArray[index] == 'a' || nextCharArray[index] == 'e' || nextCharArray[index] == 'o'
                        || nextCharArray[index] == 'u'  || nextCharArray[index] == 'i' || (nextCharArray[index] == 'A'
                        || (nextCharArray[index] == 'E' || (nextCharArray[index] == 'O' || (nextCharArray[index] == 'U'
                        || (nextCharArray[index] == 'I'))))))
                    {
                        indexNum = nextCharArray[index] * nextCharArray.Length;

                    }
                    else
                    {
                        indexNum = nextCharArray[index] / nextCharArray.Length;
                    }
                    encryptedArraySum += indexNum;
                }
                finalSequencesOrder[i] = encryptedArraySum;

            }
            Array.Sort(finalSequencesOrder);

            foreach (int EncryptedNum in finalSequencesOrder)
            {
                Console.WriteLine(EncryptedNum);
            }


        }
    }
}
