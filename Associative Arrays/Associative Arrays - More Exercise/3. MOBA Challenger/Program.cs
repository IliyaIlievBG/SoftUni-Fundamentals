using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> playerPool = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Season end")
            {
                string[] currentSubmission = input.Split(new string[] { " vs ", " -> " }, StringSplitOptions.RemoveEmptyEntries);

                if (currentSubmission.Count() == 3)
                {
                    string playerName = GetPlayerName(currentSubmission, 0);
                    string position = currentSubmission[1];
                    int skill = int.Parse(currentSubmission[2]);

                    AddPlayerToPool(playerPool, playerName, position, skill);
                }
                else
                {
                    string firstPlayer = GetPlayerName(currentSubmission, 0);
                    string secondPlayer = GetPlayerName(currentSubmission, 1);

                    if (playerPool.ContainsKey(firstPlayer) && playerPool.ContainsKey(secondPlayer))
                    {
                        string playerToDemote = string.Empty;
                        foreach (var firstPlayerPosition in playerPool[firstPlayer])
                        {
                            foreach (var secondPlayerPosition in playerPool[secondPlayer])
                            {
                                if (firstPlayerPosition.Key == secondPlayerPosition.Key)
                                {
                                    if (playerPool[firstPlayer].Values.Sum() > playerPool[secondPlayer].Values.Sum())
                                    {
                                        playerToDemote = secondPlayer;
                                    }
                                    else if (playerPool[firstPlayer].Values.Sum() < playerPool[secondPlayer].Values.Sum())
                                    {
                                        playerToDemote = firstPlayer;
                                    }
                                }
                            }
                        }
                        playerPool.Remove(playerToDemote);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var player in playerPool.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var position in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }

        }

        private static void AddPlayerToPool(Dictionary<string, Dictionary<string, int>> playerPool, string playerName, string position, int skill)
        {
            if (!playerPool.ContainsKey(playerName)) //if player is not present in the pool
            {
                playerPool.Add(playerName, new Dictionary<string, int>());
                playerPool[playerName].Add(position, skill);
            }
            else //if player is present in the pool
                 //add their position and skill or update their skill,
                 //only if the current position skill is lower than the new value.
            {
                if (!playerPool[playerName].ContainsKey(position)) //if current player is doesn't have the position
                {
                    playerPool[playerName].Add(position, skill);
                }
                else //if player has the position, but current position skill is lower than the new value
                {
                    if (playerPool[playerName][position] <= skill)
                    {
                        playerPool[playerName][position] = skill;
                    }
                }
            }
        }

        private static string GetPlayerName(string[] currentSubmission, int index)
        {
            return currentSubmission[index];
        }
    }
}
