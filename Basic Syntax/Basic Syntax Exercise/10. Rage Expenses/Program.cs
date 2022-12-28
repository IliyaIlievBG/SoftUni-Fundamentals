using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Every second lost game, Petar trashes his headset.
            //Every third lost game, Petar trashes his mouse.
            //When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
            //Every second time, when he trashes his keyboard, he also trashes his display.
            int lostGamesCount = int.Parse(Console.ReadLine());

            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int brokenKeyboard = 0;
            double rageExpenses = 0;
            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    rageExpenses += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    rageExpenses += mousePrice;

                }
                if (i % 6 == 0)
                {
                    rageExpenses += keyboardPrice;
                    brokenKeyboard++;
                }
                if (brokenKeyboard != 0 && brokenKeyboard % 2 == 0)
                {
                    rageExpenses += displayPrice;
                    brokenKeyboard = 0;
                }
            }
            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
