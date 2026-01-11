using System;

public class Address
{
	public int Id { get; set; }
	public string Street { get; set; }
	public int stNumber { get; set; }
	public string City { get; set; }
	public string Country { get; set; }

	public Address()
	{
		Id = -1;
		Street = string.Empty;
        stNumber = 0;
        City = string.Empty;
		Country = string.Empty;

	}
}
