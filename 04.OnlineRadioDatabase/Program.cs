using System;


class Program
{
    static void Main(string[] args)
    {
        var nums = int.Parse(Console.ReadLine());
        var playlist = new Playlist();

        for (int i = 0; i < nums; i++)
        {
            string[] input = Console.ReadLine().Split(';');
            try
            {
                Song song = new Song(input);
                Console.WriteLine(playlist.AddSong(song));
            }
            catch (InvalidSongException e)
            {
                Console.WriteLine(e.Message);               
            }           
        }
        Console.WriteLine(playlist);
    }
}