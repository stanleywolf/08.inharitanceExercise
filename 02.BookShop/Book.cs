using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Book
{
    private string title;
    private string author;
    private decimal price;

    public virtual string Title
    {
        get { return title; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            title = value;
        }
    }
    public virtual string Author
    {
        get { return author; }
        set
        {
            if (value.Split().Length > 1 && char.IsDigit(value.Split().Skip(1).First().First()))
            {
                throw new ArgumentException("Author is not valid!");
            }
        author = value;
        }
    }
    public virtual decimal Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            price = value;
        }
    }

    public Book(string author, string title, decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"Type: {GetType().Name}");
        builder.AppendLine($"Title: {this.Title}");
        builder.AppendLine($"Author: {this.Author}");
        builder.AppendLine($"Price: {this.Price:f2}");

        return builder.ToString().TrimEnd();
    }
}
