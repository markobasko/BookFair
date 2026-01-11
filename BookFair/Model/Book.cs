using System;
public enum Genre
{
    Drama,
    Comedy,
    Horror,
    Thriller,
    Romance,
    SciFi,
    Fantasy,
    NonFiction,
    Mystery,
    Biography
}

public class Book
{
    public int Id { get; set; } 
    public string ISBN { get; set; }
    public string Name { get; set; }
    public Genre Genre { get; set; }
    public int Price { get; set; }
    public int NumberOfPages { get; set; }


	public Book()
	{
        Id = -1;
        ISBN = string.Empty;
        Name = string.Empty;
        Genre = Genre.Drama;
        Price = 0;
        NumberOfPages = 0;

	}
}
