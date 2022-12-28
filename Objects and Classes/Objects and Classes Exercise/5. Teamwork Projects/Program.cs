using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamsToRegister = int.Parse(Console.ReadLine());
            List<Team> teamsList = new List<Team>();

            for (int i = 0; i < teamsToRegister; i++)
            {
                string[] teamInfo = Console.ReadLine().Split('-');
                string creator = teamInfo[0];
                string name = teamInfo[1];
                if (teamsList.Any(team => team.Name == name))
                {
                    Console.WriteLine($"Team {name} was already created!");
                }
                else if (teamsList.Any(team => team.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team(creator, name, new List<string>());
                    teamsList.Add(team);
                    Console.WriteLine($"Team {name} has been created by {creator}!");
                }
            }
            while (true)
            {
                string currentCommand = Console.ReadLine();
                if (currentCommand == "end of assignment")
                {
                    break;
                }
                string[] userToJoing = currentCommand.Split("->");
                string user = userToJoing[0];
                string teamName = userToJoing[1];
                if (teamsList.Any(team => team.Members.Contains(user)) || teamsList.Any(team => team.Creator == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else if (teamsList.All(team=> team.Name != teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
               
                else
                {
                    var currentTeam = teamsList.Find(team => team.Name == teamName);
                    currentTeam.Members.Add(user);
                }
               

            }
            var validTeams = teamsList.Where(team => team.Members.Count > 0).ToList();
            var invalidTeams = teamsList.Where(team => team.Members.Count == 0).ToList();

            foreach (Team team1 in validTeams.OrderByDescending(x => x.Members.Count).ThenBy(y => y.Name))
            {
                Console.WriteLine($"{team1.Name}");
                Console.WriteLine($"- {team1.Creator}");
                foreach (string member in team1.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband: ");
            if (invalidTeams != null)
            {
                foreach (Team team2 in invalidTeams.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"{team2.Name}");
                }
            }
         
        }
    }
    public class Team
    {
        public Team(string creator, string name, List<string> members)
        {
            this.Creator = creator;
            this.Name = name;
            this.Members = members;
        }
        public string Name { get; set; }
        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }
    
}
