using System;
using System.Collections.Generic;
using System.Text;

public abstract class Food
{
    public int Happiness { get; protected set; }
}

public class Cram : Food
{
    public Cram()
    {
        this.Happiness = 2;
    }
}
public class Lembas : Food
{
    public Lembas()
    {
        this.Happiness = 3;
    }
}
public class Apple : Food
{
    public Apple()
    {
        this.Happiness = 1;
    }
}
public class Melon : Food
{
    public Melon()
    {
        this.Happiness = 1;
    }
}
public class HoneyCake : Food
{
    public HoneyCake()
    {
        this.Happiness = 5;
    }
}
public class Mushrooms : Food
{
    public Mushrooms()
    {
        this.Happiness = -10;
    }
}
public class Else : Food
{
    public Else()
    {
        this.Happiness = -1;
    }
}