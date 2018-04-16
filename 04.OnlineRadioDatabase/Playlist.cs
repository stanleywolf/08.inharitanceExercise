using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Playlist
{
    List<Song> songs = new List<Song>();

    public string AddSong(Song song)
    {
        songs.Add(song);
        return "Song added.";
    }

    public override string ToString()
    {
        var totalLenght = songs.Select(s => s.GetLenghtSeconds()).Sum();
        var sb = new StringBuilder();
        sb.AppendLine($"Songs added: {songs.Count}")
            .Append($"Playlist length: {totalLenght / 3600}h {totalLenght /60 % 60}m {totalLenght % 60}s");
        return sb.ToString().TrimEnd();
    }
}