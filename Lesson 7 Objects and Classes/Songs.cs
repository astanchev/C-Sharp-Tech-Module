using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Songs
{
    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberSongs; i++)
            {
                string[] inputSong = Console.ReadLine()
                                            .Split('_', StringSplitOptions.RemoveEmptyEntries)
                                            .ToArray();
                string typeList = inputSong[0];
                string name = inputSong[1];
                string time = inputSong[2];

                Song newSong = new Song
                {
                    TypeList = typeList,
                    Name = name,
                    Time = time
                };

                songs.Add(newSong);
            }
            string displayType = Console.ReadLine();

            //List<Song> filteredList = songs
            //                        .Where(song => song.TypeList == displayType)
            //                        .ToList();
            //foreach (var song in filteredList)
            //{
            //    Console.WriteLine(song.Name);
            //}

            if (displayType == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == displayType)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

        }
    }
}
