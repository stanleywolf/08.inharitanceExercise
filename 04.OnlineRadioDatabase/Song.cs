using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Song
{
    private string name;
    private string artist;
    private int minutes;
    private int seconds;

    public Song(string[] tokens)
    {
        ValidateArgs(tokens);
        this.Artist = tokens[0];
        this.Name = tokens[1];
        int[] lenghtArgs = ValidateLenght(tokens[2]);
        this.Minutes = lenghtArgs[0];
        this.Seconds = lenghtArgs[1];
    }
    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new InvalidSongNameException();
            }
            name = value;
        }
    }
    public string Artist
    {
        get { return artist; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new InvalidArtistNameException();
            }
            artist = value;
        }
    }
    public int Minutes
    {
        get { return minutes; }
        set
        {
            if (value < 0 || value > 14)
            {
                throw new InvalidSongMinutesException();
            }
            minutes = value;
        }
    }
    public int Seconds
    {
        get { return seconds; }
        set
        {
            if (value < 0 || value > 59)
            {
                throw new InvalidSongSecondsException();
            }
            seconds = value;
        }
    }

    private void ValidateArgs(string[] tokens)
    {
        if (tokens.Length != 3)
        {
            throw new InvalidSongLengthException();
        }
    }
    private int[] ValidateLenght(string lenght)
    {
        var tokens = lenght.Split(':');
        if (tokens.Length != 2 || tokens.Any(t => !t.All(c => char.IsDigit(c))))
        {
            throw new InvalidSongLengthException();
        }
        return tokens.Select(int.Parse).ToArray();
    }

    public int GetLenghtSeconds()
    {
        return this.minutes * 60 + this.seconds;
    }
}