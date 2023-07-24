partial class Program
{
	static void TimesTable(byte number, byte size = 12)
	{
		WriteLine($"This is the {number} times table with {size} rows:");
		for (int row = 1; row <= size; row++)
		{
			WriteLine($"{row} X {number} = {row * number}");
		}
		WriteLine();
	}
	/// <summary>
	/// Pass in a decimal integer and a two letter region code and it will return the amount owed with tax included.
	/// </summary>
	/// <param name="amount">Deciaml amount of currency 1.00 2.00 and so on.</param>
	/// <param name="twoLetterRegionCode">Two letter region code both capitalized e.g. FR, CH, DK and so on.</param>
	/// <returns>The tax owed on the decimal amount given for that specific region  </returns>
	static decimal CalculateTax(
		decimal amount, string twoLetterRegionCode)
	{
		decimal rate = 0.0M;

		switch (twoLetterRegionCode)
		{
			case "CH":
				rate = 0.8M;
				break;
			case "DK":
			case "NO":
				rate = 0.25M;
				break;
			case "GB":
			case "FR":
				rate = 0.2M;
				break;
			case "HU":
				rate = 0.27M;
				break;
			case "OR":
			case "AK":
			case "MT":
				break;
			case "ND":
			case "WI":
			case "ME":
			case "VA":
				rate = 0.05M;
				break;
			case "CA":
				rate = 0.0825M;
				break;
			default:
				rate = 0.06M;
				break;
		}
		return amount * rate;
	}
	/// <summary>
	/// Pass a 32-bit integer and it will be converted into its ordinal equivalent
	/// </summary>
	/// <param name="number">Number as a cardinal value e.g. 1,2,3, and so on.</param>
	/// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
	static string CardinalToOrdinal(int number)
	{
		int lastTwoDigits = number % 100;

		switch (lastTwoDigits)
		{
			case 11:
			case 12:
			case 13:
				return $"{number:N0}th";
			default:
				int lastDigit = number % 10;
				string suffix = lastDigit switch
				{
					1 => "st",
					2 => "nd",
					3 => "rd",
					_ => "th"
				};
				return $"{number:N0}{suffix}";
		}
	}

	static void RunCardinalToOrdinal()
	{
		for (int number = 1; number <= 1500; number++)
		{
			WriteLine($"{CardinalToOrdinal(number)}");
		}
		WriteLine();
	}
	static int Factorial(int number)
	{
		{
			if (number < 0)
			{
				throw new ArgumentException(message:
					$"The factorial function is defined for non negative integers only. Input: {number}", nameof(number));
			}
			else if (number == 0)
			{
				return 1;
			}
			else
			{
				return number * Factorial(number - 1);
			}
		}
	}
	static void RunFactorial()
	{
		for (int i = 1; i <= 15; i++)
		{
			WriteLine($"{i}! = {Factorial(i):N0}");
		}
	}

	static int FibImperative(int term)
	{
		if (term == 1)
		{
			return 0;
		}
		else if (term ==2)
		{
			return 1;
		}
		else
		{
			return FibImperative(term - 1) +FibImperative(term - 2);
		}
	}

	static void RunFibImperative()
	{
		for(int i = 1; i <= 30; i++)
		{
			WriteLine("The {0} term of Fibonacci sequence is {1:N0}.",
				arg0: CardinalToOrdinal(i),
				arg1: FibImperative(term: i));
		}
	}
	static int FibFunctional(int term) =>
		term switch
		{
			1 => 0,
			2 => 1,
			_ => FibFunctional(term - 1) + FibFunctional(term - 2)
		};

	static void RunFibFunctional()
	{
		for(int i = 1; i <= 30; i++)
		{
			WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
				arg0: CardinalToOrdinal(i),
				arg1: FibFunctional(term: i));
		}
	}

}