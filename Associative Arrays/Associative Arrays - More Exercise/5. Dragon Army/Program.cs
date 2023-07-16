using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dragonsCount = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, Dragon>> dragons = new Dictionary<string, Dictionary<string, Dragon>>();

            for (int i = 0; i < dragonsCount; i++)
            {
                string[] currentDragonInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string currentDragonType, currentDragonName, damage, health, armor;

                currentDragonType = currentDragonInfo[0];
                currentDragonName = currentDragonInfo[1];

                damage = currentDragonInfo[2];
                health = currentDragonInfo[3];
                armor = currentDragonInfo[4];

                int currentDamage = damage == "null" ? 45 : GetDragonStats(damage);
                int currentHealth = health == "null" ? 250 : GetDragonStats(health);
                int currentArmor = armor == "null" ? 10 : GetDragonStats(armor);

                Dragon currentDragon = new Dragon(currentDamage, currentHealth, currentArmor);

                if (!dragons.ContainsKey(currentDragonType))
                {
                    dragons.Add(currentDragonType, new Dictionary<string, Dragon>());
                    dragons[currentDragonType].Add(currentDragonName, currentDragon);
                }
                else
                {
                    if (dragons[currentDragonType].ContainsKey(currentDragonName))
                    {
                        dragons[currentDragonType][currentDragonName].Damage = currentDamage;
                        dragons[currentDragonType][currentDragonName].Health = currentHealth;
                        dragons[currentDragonType][currentDragonName].Armor = currentArmor;
                    }
                    else
                    {
                        dragons[currentDragonType].Add(currentDragonName, currentDragon);
                    }
                }
            }

            foreach (var type in dragons)
            {
                double averageDamage, averageHealth, averageArmor;

                averageDamage = type.Value.Sum(x => (double)x.Value.Damage) / type.Value.Count;
                averageHealth = type.Value.Sum(x => (double)x.Value.Health) / type.Value.Count;
                averageArmor = type.Value.Sum(x => (double)x.Value.Armor) / type.Value.Count;

                Console.WriteLine($"{type.Key}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");
                foreach (var dragon in type.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value.Damage}, health: {dragon.Value.Health}, armor: {dragon.Value.Armor}");
                }
            }
        }

        private static int GetDragonStats(string statsValue)
        {
            return int.Parse(statsValue);
        }
    }
    class Dragon
    {
        public Dragon(int damage, int health, int armor)
        {
            this.Damage = damage;
            this.Health = health;
            this.Armor = armor;
        }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }
}
