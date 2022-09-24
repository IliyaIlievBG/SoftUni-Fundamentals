using System;

namespace _3._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guestsNum = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            //•	For Students – if the group is 30 or more people, you should reduce the total price by 15 %.
            //•	For Business – if the group is 100 or more people, 10 of the people stay for free.
            //•	For Regular – if the group is between 10 and 20  people(both inclusively), reduce the total price by 5 %.
            double price = 0;
            switch (groupType)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = guestsNum * 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        price = guestsNum * 9.8;
                    }
                    else
                    {
                        price = guestsNum * 10.46;
                    }
                    if (guestsNum >= 30)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Business":
                    if (guestsNum >= 100)
                    {
                        guestsNum -= 10;
                    }
                    if (day == "Friday")
                    {
                        price = guestsNum * 10.9;
                    }
                    else if (day == "Saturday")
                    {
                        price = guestsNum * 15.6;
                    }
                    else
                    {
                        price = guestsNum * 16;
                    }

                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price = guestsNum * 15;
                    }
                    else if (day == "Saturday")
                    {
                        price = guestsNum * 20;
                    }
                    else
                    {
                        price = guestsNum * 22.5;
                    }
                    if (guestsNum >= 10 && guestsNum <= 20)
                    {
                        price -= price * 0.05;
                    }
                    break;

            }

            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
