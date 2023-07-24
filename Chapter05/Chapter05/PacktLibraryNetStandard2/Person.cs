using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared;

public partial class Person : System.Object
{
	//fields
	public string? Name;
	public DateTime DateOfBirth;
	public WondersOfTheAncientWorld FavoriteAncientWonder;
	public WondersOfTheAncientWorld BucketList;
	public List<Person> Children = new();

	//constants
	public const string Species = "Homo Sapiens";

	//read-only fields
	public readonly string HomePlanet = "Earth";
	public readonly DateTime Instantiated;

	//Constructors
	public Person()
	{
		Name = "Unknown";
		Instantiated = DateTime.Now;
	}

	public Person(string initialName, string homePlanet)
	{
		Name = initialName;
		HomePlanet = homePlanet;
		Instantiated= DateTime.Now;
	}

	public void WriteToConsole()
	{
		WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
	}

	public string GetOrigin()
	{
		return $"{Name} was born on {HomePlanet}.";
	}
	public (string, int) GetFruit()
	{
		return ("apples", 5); 
	}
	public(string Name, int Number) GetNamedFruit()
	{
		return (Name: "Apples", Number: 5);
	}
	//deconstructors
	public void Deconstruct(out string? name, out DateTime dob)
	{
		name = Name;
		dob = DateOfBirth;
	}

	public void Deconstruct(out string? name,
		out DateTime dob,out WondersOfTheAncientWorld fav)
	{
		name = Name;
		dob = DateOfBirth;
		fav = FavoriteAncientWonder;
	}

	public string SayHello()
	{
		return $"{Name} says 'Hello!'";
	}
	public string SayHello(string name)
	{
		return $"{Name} says 'hello, {name}!'";
	}
	public string OptionalParameters(string command = "Run!",
		double number = 0.0, bool active = true)
	{
		return string.Format(
			format: "command is {0}, number is {1}, active is {2}",
			arg0: command,
			arg1: number,
			arg2: active);
	}

	public void PassingParameters(int x, ref int y, out int z)
	{
		z = 99;
		x++;
		y++;
		z++;
	}



}
