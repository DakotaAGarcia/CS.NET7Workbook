//Console.WriteLine("Enter a number between 1 and 10");
//var input = Console.ReadLine();
//var number = Convert.ToInt32(input);
//if (number > 0 && number <= 10)
//{
//	Console.WriteLine("Valid");
//}
//else if (number > 10 || number < 0)
//{
//	Console.WriteLine("Invalid");
//}

//Console.WriteLine("Enter a number");
//var input1 = Console.ReadLine();
//Console.WriteLine("Enter another number");
//var number1 = Convert.ToInt32(input1);
//var input2 = Console.ReadLine();
//var number2 = Convert.ToInt32(input2);
//if(number1 > number2)
//{
//	Console.WriteLine($"{number1} is greater");
//}
//else if(number1 < number2)
//{
//	Console.WriteLine($"{number2} is greater");
//}
//else
//{
//	Console.WriteLine("Numbers are equal");
//}


//	Console.WriteLine("Enter width");
//var width = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter height");
//var height = Convert.ToInt32(Console.ReadLine());

//if(width > height)
//	{
//	Console.WriteLine("the image is Landscape");
//}
//else
//{
//	Console.WriteLine("the image is Portrait");
//}
//var count = 0;
//for (var i = 1; i <= 100; i++)
//{

//	if (i % 3 == 0)
//	{
//		Console.WriteLine($"{i}");
//		count++;
//	}
//	else
//	{
//		continue;
//	}

//}
//Console.WriteLine($"{count} numbers were divisible by 3");

//var sum = 0;
//while (true)
//{
//	Console.WriteLine("Enter a number or 'ok' to exit and compute");
//	var input = Console.ReadLine();
//	if (input == "ok")
//	{
//		Console.WriteLine($"total sum is: {sum}");
//		break;
//	}
//	else
//	{
//		var number = Convert.ToInt32(input);
//		sum += number;
//	}

//}

//var factorial = 1;
//Console.WriteLine("Enter a number");
//var input = Convert.ToInt32(Console.ReadLine());
//for (var i = 1; i <= input; i++)
//{
//	factorial *= i;
//}
//Console.WriteLine($"Factorial of {input} is {factorial}");


//var randomNumber = new Random();
//var number = randomNumber.Next(1, 10);
//Console.WriteLine(number);
//Console.WriteLine("Guess the number between 1 and 10");
//var guess = Convert.ToInt32(Console.ReadLine());
//if (guess == number)
//{
//	Console.WriteLine("You won");
//}
//else
//{
//	Console.WriteLine("You lost");
//}

//var numbers = new List<int>();
//Console.WriteLine("Enter a series of numbers separated by a comma");
//var input = Console.ReadLine();
//var inputArray = input.Split(',');
//foreach (var number in inputArray)
//{
//	numbers.Add(Convert.ToInt32(number));
//}
//var max = numbers[0];
//foreach (var number in numbers)
//{
//	if (number > max)
//	{
//		max = number;
//	}
//}
//Console.WriteLine($"The highest number is {max}");
//Console.WriteLine("Enter your name");
//var name = Console.ReadLine();
//char[] nameArray = name.ToCharArray();
//Array.Reverse(nameArray);
//var reversedName = new string(nameArray);
//Console.WriteLine($"Reversed name is {reversedName}");

