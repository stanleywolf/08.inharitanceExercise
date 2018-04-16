using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class GoldenEditionBook : Book
{
    public override string Title
    {
        get { return base.Title; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            base.Title = value;
        }
    }
    public override string Author
    {
        get { return base.Author; }
        set
        {
            if (value.Split().Length > 1 && char.IsDigit(value.Split().Skip(1).First().First()))
            {
                throw new ArgumentException("Author is not valid!");
            }
            base.Author = value;
        }
    }
    public override decimal Price
    {
        get { return base.Price * 1.3m; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            base.Price = value;
        }
    }

    public GoldenEditionBook(string author, string tittle, decimal price):base(author, tittle, price)
    {
        
    }
}