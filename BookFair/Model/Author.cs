using BookFair.Serialization;
using System;

namespace BookFair.Model
{
	public class Author : Person, ISerializable
	{
		public int Id { get; set; }
		public string IdCardNumber { get; set; }
		public int YearsOfExperience { get; set; }

		public Author()
		{
			Id = 0;
			IdCardNumber = string.Empty;
			YearsOfExperience = 0;
		}

        public Author(string firstName, string lastName, DateTime dateOfBirth,Address address,string phoneNumber, string email,string idCardNumber, int yearsOfExperience) : base(firstName,lastName,dateOfBirth,address,phoneNumber,email)
        {
            IdCardNumber = idCardNumber;
            YearsOfExperience = yearsOfExperience;
        }
		public override string ToString()
		{
			return $"Author[Id:{Id},FirstName:{FirstName},LastName:{LastName},BirthDate:{DateOfBirth},Address:{Address},PhoneNumber:{PhoneNumber},Email:{Email},YearsExperience:{YearsOfExperience},IDLK:{IdCardNumber}]";
		}

        public string[] ToCSV()
        {
            string[] csvValues =
            {
                Id.ToString(),
                FirstName,
                LastName,
                DateOfBirth.ToString("yyyy-MM-dd"),
                Address.Id.ToString(),
                PhoneNumber,
                Email,
                IdCardNumber,
                YearsOfExperience.ToString()
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
            IdCardNumber = values[7];
            YearsOfExperience = int.Parse(values[8]);
        }
    }
}