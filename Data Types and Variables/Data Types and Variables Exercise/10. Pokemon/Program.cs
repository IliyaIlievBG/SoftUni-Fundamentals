using System;

namespace _10._Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokemonPower = int.Parse(Console.ReadLine());
            int currentPokemonPower = pokemonPower;
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int successfullPokes = 0;
            while (currentPokemonPower >= distanceBetweenTargets)
            {
                currentPokemonPower = currentPokemonPower - distanceBetweenTargets;
                successfullPokes++;
                if (currentPokemonPower * 2 == pokemonPower && exhaustionFactor != 0)
                {
                    currentPokemonPower /= exhaustionFactor;
                }


            }
            Console.WriteLine(currentPokemonPower);
            Console.WriteLine(successfullPokes);
        }
    }
}
