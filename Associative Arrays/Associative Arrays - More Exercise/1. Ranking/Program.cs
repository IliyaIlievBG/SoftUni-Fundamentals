using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contest = Console.ReadLine();

            List<Contest> contests = new List<Contest>();

            Dictionary<string, User> users = new Dictionary<string, User>();

            while (contest != "end of contests")
            {
                string[] currentContestInfo = contest.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string contestName = currentContestInfo[0];
                string contestPassword = currentContestInfo[1];
              
                Contest currentContest = new Contest(contestName, contestPassword);
                contests.Add(currentContest);

                contest = Console.ReadLine();
            }

            string submission = Console.ReadLine();

            while (submission != "end of submissions")
            {
                string[] currentSubmission = submission.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contestName = currentSubmission[0];
                string contestPassword = currentSubmission[1];
                string username = currentSubmission[2];
                int points = int.Parse(currentSubmission[3]);

                bool validSubmission = CheckIfSubmissionIsValid(contests, contestName, contestPassword);

                if (validSubmission)
                {
                    if (!users.ContainsKey(username))
                    {
                        User currentUser = new User(username);
                        users.Add(username, currentUser);

                        if (!currentUser.Contests.ContainsKey(contestName))
                        {
                            currentUser.Contests.Add(contestName, points);
                        }

                    }
                    else //if user is present in users
                    {
                        if (!users[username].Contests.ContainsKey(contestName))
                        {
                            users[username].Contests.Add(contestName, points);
                        }
                        else
                        {
                            if (users[username].Contests[contestName] < points)
                            {
                                users[username].Contests[contestName] = points;                          
                            }
                        }
                    }

                }

                submission = Console.ReadLine();
            }
            var best = users.OrderByDescending(x => x.Value.Contests.Values.Sum()).First();
            Console.WriteLine($"Best candidate is {best.Key} with total {best.Value.Contests.Values.Sum()} points.");
            Console.WriteLine("Ranking:");
            foreach (var student in users.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Key);
                foreach (var (studentContest, points) in student.Value.Contests.OrderByDescending(x=> x.Value))
                {
                    Console.WriteLine($"#  {studentContest} -> {points}");
                }

            }
            
        }

        private static bool CheckIfSubmissionIsValid(List<Contest> contests, string contestName, string contestPassword)
        {
            bool validSubmission = false;
            if (contests.Any(x => x.ContestName == contestName))
            {
                int index = contests.FindIndex(x => x.ContestName == contestName);
                if (contests[index].ContestPassword == contestPassword)
                {
                    validSubmission = true;
                }
            }
            return validSubmission;
        }
    }
    public class User
    {
        public User(string username)
        {
            this.UserName = username;
        }
        public string UserName { get; set; }

        public Dictionary<string, int> Contests = new Dictionary<string, int>();
    }
    public class Contest
    {
        public Contest(string contestName, string contestPassword)
        {
            this.ContestName = contestName;
            this.ContestPassword = contestPassword;
        }

        public string ContestName { get; set; }
        public string ContestPassword { get; set; }
    }
}
