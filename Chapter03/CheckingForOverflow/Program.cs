try
{
	checked
	{
		int x = int.MaxValue - 1;
		WriteLine($"Initial value: {x}");
		x++;
		WriteLine($"After increment: {x}");
		x++;
		WriteLine($"After increment: {x}");
		x++;
		WriteLine($"After increment: {x}");
	}
}
catch (OverflowException)
{
	WriteLine("THE CODE OVERFLOWED BUT I CAUGHT THE EXCEPTION");
}
unchecked
{
	int y = int.MaxValue + 1;
	WriteLine($"Initial value: {y}");
	y--;
	WriteLine($"After decrementing: {y}");
	y--;
	WriteLine($"After decrementing: {y}");
}

