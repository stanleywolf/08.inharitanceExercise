using System;
using System.Collections.Generic;
using System.Text;

public class Mood
{
    public string MoodName { get; private set; }
    public Mood(string mood)
    {
        this.MoodName = mood;
    }
}
