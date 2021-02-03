using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            Song songs = new Song();
            songs.numberOfSongs = int.Parse(Console.ReadLine());
            songs.SongSeparator();
        }

        public class Song
        {
            public int numberOfSongs;
  
            public void SongSeparator()
            {
                string favourite = "";
                string listenLater = "";
                string all = "";

                for (int i = 0; i < numberOfSongs; i++)
                {
                    List<string> song = Console.ReadLine().Split("_").ToList();

                    if (song[0] == "favourite")
                    {
                        favourite += song[1] + Environment.NewLine;

                    }
                    else if (song[0] == "listenLater")
                    {
                        listenLater += song[1] + Environment.NewLine;

                    }
                    else
                    {
                        all += song[1] + Environment.NewLine;
                    }
                }

                string typeOfSongs = Console.ReadLine();
                switch (typeOfSongs)
                {
                    case "favourite":
                        Console.Write(favourite);
                        break;
                    case "listenLater":
                        Console.Write(listenLater);
                        break;
                    case "all":
                        Console.Write(all);
                        break;
                }
            }
        }
    }
}
