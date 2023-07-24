namespace UdemyCourse;


class Program
{
	static void Main(string[] args)
	{
		var sw = new StopWatch();
		for (var i = 0; i < 2; i++)
		{
			sw.StartTimer();
			System.Threading.Thread.Sleep(1000);
			sw.StopTimer();
			Console.WriteLine($"Duration: {sw.GetInterval()}");
			Console.WriteLine("Press enter to run the stopwatch again");
			Console.ReadLine();
		}
	}

}