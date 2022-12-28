using System;
using System.Collections.Generic;

namespace _3._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songsList = new List<Song>();
            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songData = Console.ReadLine().Split('_');
                Song song = new Song(songData[0], songData[1], songData[2]);
                songsList.Add(song);

            }
            string typeList = Console.ReadLine();

            PrintSongNames(songsList, typeList);

        }

        private static void PrintSongNames(List<Song> songslist, string typeList)
        {
            if (typeList == "all")
            {
                foreach (var song in songslist)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songslist)
                {
                    if (typeList == song.TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
            
        }
    }
    class Song
    {
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }



    }
}
