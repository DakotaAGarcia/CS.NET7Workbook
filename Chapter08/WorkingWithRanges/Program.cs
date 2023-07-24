string name = "Samantha Jones";

int lengthOfFirst = name.IndexOf(' ');
int lengthOfLast = name.Length - lengthOfFirst - 1;

string firstNAme = name.Substring(
	startIndex: 0,
	length: lengthOfFirst);

string lastName = name.Substring(
	startIndex: name.Length - lengthOfLast,
	length: lengthOfLast);

WriteLine($"First name: {firstNAme}, Last name: {lastName}");

ReadOnlySpan<char> nameAsSpan = name.AsSpan();
ReadOnlySpan<char> firstNameSpan = nameAsSpan[0..lengthOfFirst];
ReadOnlySpan<char> lastNameSpan = nameAsSpan[^lengthOfLast..^0];

WriteLine("First name: {0}, Last name: {1}",
	arg0: firstNameSpan.ToString(),
	arg1: lastNameSpan.ToString());