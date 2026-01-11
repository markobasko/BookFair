using System;

public class Author
{
	public int Id { get; set; }
	public string IdCardNumber { get; set; }
	public List<Book> WrittenBooks { get; set; }
	public int YearsOfExperience { get; set; }

	public Author()
	{
		Id = 0;
		IdCardNumber = string.Empty;
		YearsOfExperience = 0;
		WrittenBooks = new List<Book>();
	}
}
