using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared;
public class ImmutablePerson
{
	public string? FirstName { get; init; }
	public string? LastName { get; init; }
}
public record ImmutableVehichle
{
	public int Wheels { get; init; }
	public string? Color { get; init; }
	public string? Brand { get; init; }
}

public record ImmutableAnimal(string name, string Species);