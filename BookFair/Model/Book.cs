using BookFair.Serialization;
using System;


namespace BookFair.Model
{
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

    public class Book : ISerializable 
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
        public string[] ToCSV()
        {
            string[] csvValues =
            {
        Id.ToString(),
        ISBN,
        Name,
        Genre.ToString(),
        Price.ToString(),
        NumberOfPages.ToString(),
        };
            return csvValues;
        }
        public void FromCSV(string[] values)
        {
            Id = int.Parse(values[0]);
            ISBN = values[1];
            Name = values[2];
            Genre = Enum.Parse<Genre>(values[3]);
            Price = int.Parse(values[4]);
            NumberOfPages = int.Parse(values[5]);
        }
    }
}