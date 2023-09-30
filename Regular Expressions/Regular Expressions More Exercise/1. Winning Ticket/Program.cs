using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1._Winning_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] collectionOfTickets = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            foreach (var ticket in collectionOfTickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string[] currentTicket = SplitTicket(ticket);
                    CheckTicket(currentTicket);
                }
            }
        }

        private static void CheckTicket(string[] currentTicket)
        {
            string patternToMatch = @"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}";
            Regex winner = new Regex(patternToMatch);

            string leftHalf = currentTicket[0];
            string rightHalf = currentTicket[1];

            Match leftHalfMatch = winner.Match(leftHalf);
            Match rightHalfMatch = winner.Match(rightHalf);

            if (leftHalfMatch.Success && rightHalfMatch.Success)
            {
                DisplayResult(leftHalfMatch, rightHalfMatch, currentTicket);
            }
            else
            {
                Console.WriteLine($"ticket \"{leftHalf}{rightHalf}\" - no match");
            }
        }

        private static void DisplayResult(Match leftHalfMatch, Match rightHalfMatch, string[] currentTicket)
        {
            string winningPattern = leftHalfMatch.Value;
            int countOfSymbol = winningPattern.Length;
            char winningSymbol = winningPattern[0];

            if (leftHalfMatch.Length == 10 && rightHalfMatch.Length == 10)
            {
                Console.WriteLine($"ticket \"{currentTicket[0]}{currentTicket[1]}\" - {countOfSymbol}{winningSymbol} Jackpot!");
            }
            else
            {
                if (leftHalfMatch.Length <= rightHalfMatch.Length)
                {
                    Console.WriteLine(
                        $"ticket \"{currentTicket[0]}{currentTicket[1]}\" - {leftHalfMatch.Length}{winningSymbol}");
                }
                else
                {
                    Console.WriteLine(
                        $"ticket \"{currentTicket[0]}{currentTicket[1]}\" - {rightHalfMatch.Length}{winningSymbol}");
                }
            }
        }

        private static string[] SplitTicket(string ticket)
        {
            string leftHalf = ticket.Substring(0, 10);
            string rightHalf = ticket.Substring(10, 10);

            string[] currentTicket = { leftHalf, rightHalf };
            return currentTicket;
        }
    }
}
