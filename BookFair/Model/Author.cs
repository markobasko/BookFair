using System;
using BookFair.Serialization;

namespace BookFair.Model
{
	public class Author : Person
	{
		public int Id { get; set; }
		public string IdCardNumber { get; set; }
		public List<Book> WrittenBooks { get; set; }
		public int YearsOfExperience { get; set; }

		public Author() : base()
		{
			Id = 0;
			IdCardNumber = string.Empty;
			YearsOfExperience = 0;
			WrittenBooks = new List<Book>();
		}
		public override string ToString()
		{
			return $"Author[Id:{Id},FirstName:{FirstName},LastName:{LastName},BirthDate:{BirthDate},Address:{Address},PhoneNumber:{PhoneNumber},Email:{Email},YearsExperience:{YearsExperience},IDLK:{IdCardNumber}]";
		}

	}
}