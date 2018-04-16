using System;
using System.Collections.Generic;
using System.Text;

public class Child:Person
{
    private const int MIN_AGE = 0;
    private const int MAX_AGE = 15;
    private const int MIN_SYMBOL_NAME = 3;

    public Child(string name, int age):base(name, age) { }

    public override string Name
    {
        get { return base.Name; }
        set
        {
            if (value.Length < MIN_SYMBOL_NAME)
            {
                throw new ArgumentException($"Name's length should not be less than {MIN_SYMBOL_NAME} symbols!");
            }
            base.Name = value;
        }
    }

    public override int Age
    {
        get { return base.Age; }
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
            base.Age = value;
        }
    }
}
