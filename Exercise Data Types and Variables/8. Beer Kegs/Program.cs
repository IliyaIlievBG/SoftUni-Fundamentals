using System;

namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beerKegCount = int.Parse(Console.ReadLine());

            double volumeOfBiggestKeg = 0;
            string biggestKeg = "";

            for (int i = 0; i < beerKegCount; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;
                if (kegVolume>=volumeOfBiggestKeg)
                {
                    volumeOfBiggestKeg = kegVolume;
                    biggestKeg = kegModel;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
