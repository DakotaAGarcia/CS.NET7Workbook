using System.Text.RegularExpressions;

partial class Program
{
	[GeneratedRegex(digitsOnlyText, RegexOptions.IgnoreCase)]
	private static partial Regex DigitsOnly();

	[GeneratedRegex(commmaSeparatorText, RegexOptions.IgnoreCase)]
	private static partial Regex CommaSeparator();
}