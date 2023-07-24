namespace Packt.Shared;

public class PersonException : Exception
{
	public PersonException() : base() { }

	public PersonException(string messgae) : base(messgae) { }
	public PersonException(string messgae, Exception innerException) : base(messgae, innerException) { }
}
