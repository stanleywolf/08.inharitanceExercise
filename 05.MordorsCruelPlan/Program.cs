using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();

        var gandalf = new Gandalf();
        gandalf.TakeFood(input);
        Console.WriteLine(gandalf);
    }
}