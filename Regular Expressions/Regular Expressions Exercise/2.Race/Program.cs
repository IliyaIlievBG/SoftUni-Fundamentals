using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string info = Console.ReadLine();
            string namePattern = @"[A-Za-z]";
            string distancePattern = @"\d";

            Dictionary<string, int> racers = new Dictionary<string, int>();

            while (info != "end of race")
            { 
                MatchCollection matchedName = Regex.Matches(info, namePattern);
                MatchCollection matchedDistance = Regex.Matches(info, distancePattern);
              
                StringBuilder currentName = new StringBuilder();
                StringBuilder currentDistanceString = new StringBuilder();
                
                foreach (Match match in matchedName)
                {
                    currentName.Append(match.Value);
                }

                foreach (Match match in matchedDistance)
                {
                    currentDistanceString.Append(match.Value);
                }

                int currentDistance = CurrentDistance(currentDistanceString);

                AddParticipantsToRacersList(participants, currentName, racers, currentDistance);

                info = Console.ReadLine();
            }

            List<KeyValuePair<string, int>> orderedRacers = racers.OrderByDescending(x => x.Value).ToList();
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine($"{i + 1}st place: {orderedRacers[i].Key}");
                        break;
                    case 1:
                        Console.WriteLine($"{i + 1}nd place: {orderedRacers[i].Key}");
                        break;
                    case 2:
                        Console.WriteLine($"{i + 1}rd place: {orderedRacers[i].Key}");
                        break;
                }
            }

        }

        private static void AddParticipantsToRacersList(List<string> participants, StringBuilder currentName, Dictionary<string, int> racers,
            int currentDistance)
        {
            if (participants.Contains(currentName.ToString()))
            {
                if (!racers.ContainsKey(currentName.ToString()))
                {
                    racers[currentName.ToString()] = currentDistance;
                }
                else
                {
                    racers[currentName.ToString()] += currentDistance;
                }
            }
        }

        private static int CurrentDistance(StringBuilder currentDistanceString)
        {
            int currentDistance = 0;
            foreach (char symbol in currentDistanceString.ToString())
            {
                currentDistance += int.Parse(symbol.ToString());
            }

            return currentDistance;
        }
    }
}
