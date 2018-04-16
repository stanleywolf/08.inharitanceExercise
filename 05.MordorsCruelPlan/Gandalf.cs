using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Gandalf
{
    private List<Food> food;
    private Mood mood;

    public Gandalf()
    {
        this.food = new List<Food>();
    }

    private void CalculateMood()
    {
        this.mood = MoodFactory.GenereteMood(this.food.Sum(f => f.Happiness));
    }

    public void TakeFood(string[] food)
    {
        foreach (var foo in food)
        {
            Food current = FoodFactory.GenereteFood(foo);
            this.food.Add(current);
        }
        this.CalculateMood();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.food.Sum(f => f.Happiness)}")
            .Append(this.mood.MoodName);
        return sb.ToString().TrimEnd();
    }
}