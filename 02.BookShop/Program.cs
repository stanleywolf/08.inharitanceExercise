using System;


class Program
{
    static void Main(string[] args)
    {
        var author = Console.ReadLine();
        var title = Console.ReadLine();
        decimal price = decimal.Parse(Console.ReadLine());

        try
        {
            var book = new Book(author,title,price);
            var goldenBook = new GoldenEditionBook(author,title,price);

            Console.WriteLine(book + Environment.NewLine);
            Console.WriteLine(goldenBook);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
 