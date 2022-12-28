using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myStops = Console.ReadLine();
            string commands = Console.ReadLine();

            while (commands!="Travel")
            {
                string[] currentCommand = commands.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string action = currentCommand[0];
                if (action == "Add Stop")
                {
                    myStops = AddStop(myStops, currentCommand);
                }
                else if (action == "Remove Stop")
                {
                    myStops = RemoveStop(myStops, currentCommand);
                }
                else //action == switch
                {
                    myStops = SwitchStops(myStops, currentCommand);
                }
                Console.WriteLine(myStops);
                commands = Console.ReadLine();

            }
            Console.WriteLine($"Ready for world tour! Planned stops: {myStops}");

        }

        private static string SwitchStops(string myStops, string[] currentCommand)
        {
            //replace the old stop with the new one
            string oldStop = currentCommand[1];
            string newStop = currentCommand[2];
            if (myStops.Contains(oldStop))
            {
                myStops = myStops.Replace(oldStop, newStop);
            }
            return myStops;
        }

        private static string RemoveStop(string myStops, string[] currentCommand)
        {
            int startIndex = int.Parse(currentCommand[1]);
            int endIndex = int.Parse(currentCommand[2]);
            bool validIndexes = (startIndex>=0 && startIndex<= myStops.Length-1) 
                && (endIndex>=0 && endIndex<= myStops.Length-1);
            if (validIndexes)
            {
                myStops = myStops.Remove(startIndex, endIndex-startIndex+1); //add 1 beacause indexes start fronm 0
            }                                                                //when removing substracting index from index   
                                                                             //count is not correct and should add 1
            return myStops;
        }

        private static string AddStop(string myStops, string[] currentCommand)
        {
            int index = int.Parse(currentCommand[1]);
            string stopToAdd = currentCommand[2];
            //insert the given stop at that index
            bool indexIsValid = index >= 0 && index <= myStops.Length-1; //maybe length-1 is not correct
            if (indexIsValid)
            {
                myStops = myStops.Insert(index, stopToAdd);
            }
            return myStops;
        }

    }
}
