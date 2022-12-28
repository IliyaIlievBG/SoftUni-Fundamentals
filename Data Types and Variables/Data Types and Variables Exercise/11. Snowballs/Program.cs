using System;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte ballsCount = byte.Parse(Console.ReadLine());
            
            System.Numerics.BigInteger bestBallValue = int.MinValue;
            System.Numerics.BigInteger bestballSnow = 0;
            System.Numerics.BigInteger bestballTime = 0;
            int bestballQuality = 0;
            
            for (int i = 0; i < ballsCount; i++) //get the parameters of each ball and calculate it's value
            {
                System.Numerics.BigInteger snowballSnow = System.Numerics.BigInteger.Parse(Console.ReadLine());
                System.Numerics.BigInteger snowballTime = System.Numerics.BigInteger.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                //get the value. Formula -> snow/time^quality
                System.Numerics.BigInteger snowballValue = System.Numerics.BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue>=bestBallValue)
                {
                    bestBallValue = snowballValue;
                    bestballSnow = snowballSnow;
                    bestballTime = snowballTime;
                    bestballQuality = snowballQuality;

                }
                
            }
            Console.WriteLine($"{bestballSnow} : {bestballTime} = {bestBallValue} ({bestballQuality})");
        }
    }
}
