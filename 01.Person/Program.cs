using System;


class Program
{
    static void Main(string[] args)
    {
        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());

        try
        {
            Child child = new Child(name,age);
            Console.WriteLine(child);
        }
        catch (ArgumentException  e)
        {
            Console.WriteLine(e.Message);           
        }
    }
}