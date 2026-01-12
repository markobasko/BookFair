using System;
using BookFair.Serialization;
namespace BookFair.Model
{
	public class Visitor : Person, ISerializable
	{


		public int Id { get; set; }
		public int MembershipNumber { get; set; }
		public List<Book> PurchasedBooks { get; set; }

		public Visitor()
		{
			Id = -1;
			MembershipNumber = 0;
			PurchasedBooks = new List<Book>();
		}

		public override string ToString()
		{
			return $"Visitor[Id:{Id},FirstName{FirstName},LastName{LastName},DateOfBirth{DateOfBirth},Address{Address},PhoneNumber{PhoneNumber},Email{Email}]";
		}

		public string[] ToCSV()
		{
			string[] csvValues =
			{
				Id.ToString(),
				FirstName,
				LastName,
				DateOfBirth.ToString("yyy-MM-dd"),
				Address.Id.ToString(),
				PhoneNumber,
				Email
			};
			return csvValues;
		}

		public void FromCSV(string[] values)
		{
			Id = int.Parse(values[0]);
			FirstName = values[1];
			LastName = values[2];
			DateOfBirth = DateTime.Parse(values[3]);
			Address.Id = int.Parse(values[4]);
			PhoneNumber = values[5];
			Email = values[6];
			MembershipNumber = int.Parse(values[7]);

		}
	}
}