using BookFair.Serialization;
using System;

public class Address : ISerializable
{
	public int Id { get; set; }
	public string Street { get; set; }
	public int StNumber { get; set; }
	public string City { get; set; }
	public string Country { get; set; }

	public Address()
	{
		Id = -1;
		Street = string.Empty;
		StNumber = 0;
		City = string.Empty;
		Country = string.Empty;
	}

	public Address(string street, int stNumber, string city, string country)
	{
		Street = street;
		StNumber = stNumber;
		City = city;
		Country = country;
	}

	public string toString()
	{
		return $"Address[Id:{Id},Street:{Street},StNumber:{StNumber},City:{City},Country{Country}]";

	}

    public string[] ToCSV()
    {
        string[] csvValues =
        {
                Id.ToString(),
                Street,
                StNumber.ToString(),
                City,
                Country
            };
        return csvValues;
    }
    public void FromCSV(string[] values)
    {
        Id = int.Parse(values[0]);
        Street = values[1];
        StNumber = int.Parse(values[2]);
        City = values[3];
        Country = values[4];
    }
}