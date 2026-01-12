using System;

namespace BookFair.Model
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Person()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.MinValue;
            Address = new();
            PhoneNumber = string.Empty;
            Email = string.Empty;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth, Address address, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public abstract string ToString();
    }
}