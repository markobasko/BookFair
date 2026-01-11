using System;

public class Visitor
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
}
