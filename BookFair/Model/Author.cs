using System;
using BookFair.Serialization;
public class Author : Person, ISerializable
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
    public override string ToString()
	{
        return $"Author[Id:{Id},FirstName:{FirstName},LastName:{LastName},DateOfBirth:{DateOfBirth},Address:{Address},PhoneNumber:{PhoneNumber},Email:{Email},YearsOfExperience:{YearsOfExperience},IDLK:{IdCardNumber}]";
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
                YearsOfExperience.ToString(),
                IdCardNumber
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
