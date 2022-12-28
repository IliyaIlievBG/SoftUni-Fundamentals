using System;

namespace _3._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OutFall 4   $39.99
            //CS: OG  $15.99
            //Zplinter Zell	$19.99
            //Honored 2   $59.99
            //RoverWatch  $29.99
            //RoverWatch Origins Edition  $39.99


            double currentBalance = double.Parse(Console.ReadLine()); //your current ballance

            string command = Console.ReadLine(); //receive command
            double moneySpentOnGames = 0;
            while (command != "Game Time")
            {
                double gamePrice = 0;
                switch (command)
                {
                    case "OutFall 4":

                        gamePrice = 39.99; //assign the gamePrice

                        break;
                    case "CS: OG":
                        gamePrice = 15.99;

                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;

                        break;
                    case "Honored 2":
                        gamePrice = 59.99;

                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;

                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;

                        break;

                    default:
                        Console.WriteLine("Not Found");
                        command = Console.ReadLine();
                        continue;

                }
                if (gamePrice > currentBalance)
                {
                    Console.WriteLine("Too Expensive");

                }
                else
                {
                    moneySpentOnGames += gamePrice;
                    currentBalance -= gamePrice;
                    Console.WriteLine($"Bought {command}");

                }
                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                command = Console.ReadLine();

            }
            Console.WriteLine($"Total spent: ${moneySpentOnGames:F2}. Remaining: ${currentBalance:F2}");
        }
    }
}
