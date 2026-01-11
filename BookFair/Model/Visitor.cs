using System;
using System.Runtime.Serialization;

public class Visitor : Person, ISerializable
{

	public int Id { get; set; }
	public int MembershipNumber{ get; set; }
	public List<Purchase> Purchase { get; set; }

	public Visitor()
	{
		Id = -1;
		MembershipNumber = 0;
		Purchase = new List<Purchase>();
	}

    public override string ToString()
    {
		return $"Visitor[Id:{Id},FirstName{FirstName},LastName{LastName},DateOfBirth{DateOfBirth},Address{Address},PhoneNumber{PhoneNumber},Email{Email}]";
    }
}
