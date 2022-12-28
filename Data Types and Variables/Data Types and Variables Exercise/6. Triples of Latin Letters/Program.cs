using System;

namespace _6._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lettersUpperLimit = int.Parse(Console.ReadLine());

            char firstLetter = 'a';
            char secondLetter = 'a';
            char thirdLetter = 'a';

            for (int firstLetterCount = 0; firstLetterCount < lettersUpperLimit; firstLetterCount++)
            {
                
                secondLetter = 'a';
                for (int secondLetterCount = 0; secondLetterCount < lettersUpperLimit; secondLetterCount++)
                {
                    
                    thirdLetter = 'a';
                    
                    

                    for (int thirdLetterCount = 0; thirdLetterCount < lettersUpperLimit; thirdLetterCount++)
                    {
                        
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                        thirdLetter++;
                       
                    }
                    secondLetter++;
                }
                firstLetter++;
            }
                
        }
    }
}
