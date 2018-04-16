using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Human
{
    public const int MIN_LENGHT_FIRST = 3;
    public const int MIN_LENGHT_SECOND = 2;

    private string firstName;
    private string lastName;

    public virtual string FirstName
    {
        get { return firstName; }
        set
        {
            if (!char.IsUpper(value.First()))
            {
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            }
            if (value.Length <= MIN_LENGHT_FIRST)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }
            firstName = value;
        }
    }   

    public virtual string  LastName
    {
        get { return lastName; }
        set
        {
            if (!char.IsUpper(value.First()))
            {
                throw new ArgumentException("Expected upper case letter! Argument: lastName");
            }
            if (value.Length <= MIN_LENGHT_SECOND)
            {
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            }
            lastName = value;
        }
    }

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"First Name: {this.FirstName}");
        builder.AppendLine($"Last Name: {this.LastName}");
        return builder.ToString();
    }
}
