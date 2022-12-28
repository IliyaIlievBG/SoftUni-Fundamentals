using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _4._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int messagesCount = int.Parse(Console.ReadLine());
            List<Planet> attackedPlanets = new List<Planet>();
            List<Planet> destroyedPlanets = new List<Planet>();

            string decryptorPattern = @"[S|T|A|R|s|t|a|r]";
            string planetPattern = @"@{1}(?<planet>[A-Za-z]+)[^|&%.]*?:(?<population>\d+)[^|&%.]*?!{1}(?<type>[A|D])!{1}[^|&%.]*?(->){1}(?<soldiers>\d+)";
            for (int i = 0; i < messagesCount; i++)
            {
                string currentEncryptedMessage = Console.ReadLine();
                MatchCollection matchedDecryptor = Regex.Matches(currentEncryptedMessage, decryptorPattern);
                int decryptor = matchedDecryptor.Count;
                StringBuilder decryptedMessage = new StringBuilder();
                foreach (char symbol in currentEncryptedMessage)
                {
                    char currentDecryptedSymbol = symbol;
                    currentDecryptedSymbol -= (char)decryptor;
                    decryptedMessage.Append(currentDecryptedSymbol);
                }

                Match planetInfo = Regex.Match(decryptedMessage.ToString(), planetPattern);
                if (planetInfo.Success)
                {
                    Planet planet = new Planet();
                    planet.Name = planetInfo.Groups["planet"].Value;
                    if (planetInfo.Groups["type"].Value == "A")
                    {
                        attackedPlanets.Add(planet);
                    }
                    else
                    {
                        destroyedPlanets.Add(planet);
                    }

                }
            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            attackedPlanets = attackedPlanets.OrderBy(x => x.Name).ToList();
            foreach (Planet planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet.Name}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            destroyedPlanets = destroyedPlanets.OrderBy(x => x.Name).ToList();
            foreach (Planet planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet.Name}");
            }

        }
    }

    public class Planet
    {
        public string Name { get; set; }
        //public int Population { get; set; }
        //public int SoldierCount { get; set; }
    }
}
