using System;
using System.Collections.Generic;

namespace _04_Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            //"{typeList}_{name}_{time}"
            int songsCount = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < songsCount; i++)
            {
                Song nextSong = new Song();
                ReadSong(nextSong);
                songs.Add(nextSong);
            }
            string typeToPrint = Console.ReadLine();
            if (typeToPrint!="all")
            {
                foreach (var song in songs)
                {
                    if (song.typeList==typeToPrint)
                    {
                        Console.WriteLine(song.name);
                    }
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.name);
                }
            }
        }

        static void ReadSong(Song nextSong)
        {
            
            string[] input = Console.ReadLine().Split("_");
            nextSong.typeList = input[0];
            nextSong.name = input[1];
            nextSong.time = input[2];           
        }

    }
    class Song
    {
        public string typeList {get; set;}
        public string name {get; set;}
        public string time { get; set; }

        
    }
}
