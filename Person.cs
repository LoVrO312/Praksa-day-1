using System;

public abstract class Person
{
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public int Oib { get; set; }
    public Person(string? firstName, string? lastName, int oib)
    {
        FirstName = firstName;
        LastName = lastName;
        Oib = oib;
    }
}