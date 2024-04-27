using System;

namespace q2AuroraView
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = { "song1", "song2", "song3", "song4", "song5", "song6", "song7"};
            Console.WriteLine("your first list");
            foreach (string song in songs)
            {
                Console.Write(song + " ");
            }
            Console.WriteLine("");
            effectiveShuffledSongs(songs);
            Console.WriteLine("your shuffled  list more effective");
            foreach (string song in songs)
            {
                Console.Write(song + " ");
            }
        }
        static void effectiveShuffledSongs(string[] songs)
        {
            Random rand = new Random();
            string songTemp;
            int j;
            for (int i=0; i <=songs.Length-1 ;i++ ) 
            {
                j = rand.Next(i, songs.Length - 1);
                songTemp = songs[i];
                songs[i] = songs[j];
                songs[j] = songTemp;
            }

        }
    }
}
