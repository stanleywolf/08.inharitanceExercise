using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
   private const int MIN_AGE = 0;
   private const int MAX_AGE = 15;
   private const int MIN_SYMBOL_NAME = 3;

    private string name;
    private int age;

    public virtual string Name
    {
        get { return this.name; }
        set
        {
            if (value.Length < MIN_SYMBOL_NAME)
            {
                throw new ArgumentException($"Name's length should not be less than {MIN_SYMBOL_NAME} symbols!");
            }
            name = value;
        }
    }
    public virtual int Age
    {
        get { return age; }
        set
        {
            if (value < MIN_AGE)
            {
                throw new ArgumentException("Age must be positive!");
            }
            if (value > MAX_AGE)
            {
                throw new ArgumentException($"Child's age must be less than {MAX_AGE}!");
            }
            age = value;
        }
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append(String.Format($"Name: {this.Name}, Age: {this.Age}"));
        return builder.ToString();
    }
}