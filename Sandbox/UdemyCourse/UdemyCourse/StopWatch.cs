using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse
{
	public class StopWatch
	{
		private DateTime Start;
		private DateTime Stop;
		private bool IsRunning;

		public void StartTimer()
		{
			if (IsRunning)
				throw new InvalidOperationException("Stopwatch is already running");

			Start = DateTime.Now;
			IsRunning = true;
		}
		public void StopTimer()
		{
			if (!IsRunning) 
				throw new InvalidOperationException("Stopwatch is not running");
			Stop = DateTime.Now;
			IsRunning = false;
		}
		public TimeSpan GetInterval()
		{
			return Stop - Start;
		}


	}


}
