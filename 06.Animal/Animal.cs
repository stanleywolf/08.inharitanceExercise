using System;
using System.Collections.Generic;
using System.Text;

public class Animal:ISoundPreducable
{
    private const string ERORR_MESSAGE = "Invalid input!";

    private string name;
    private int age;
    private string gender;

    public string Name
    {
        get { return name; }
        set
        {
            ValidationString(value);
            name = value;
        }
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException(ERORR_MESSAGE);
            }
            age = value;
        }
    }
    public string Gender
    {
        get { return gender; }
        set
        {
            ValidationString(value);           
            gender = value;
        }
    }

    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }
    public virtual string ProduceSound()
    {
        return "NOISE";
    }

    private static void ValidationString(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException(ERORR_MESSAGE);
        }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"{this.GetType().Name}")
            .AppendLine($"{this.Name} {this.Age} {this.Gender}")
            .AppendLine($"{this.ProduceSound()}");
        return builder.ToString().TrimEnd();
    }
}