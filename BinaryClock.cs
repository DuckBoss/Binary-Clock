using System;
using System.Timers;

namespace BinaryClock
{
	class MainClass
	{
		static int _curSecond;
		public static int CurrentSecond
		{
			get { return _curSecond; }
			set { _curSecond = value; }
		}

		static int _curMinute;
		public static int CurrentMinute
		{
			get { return _curMinute; }
			set { _curMinute = value; }
		}

		static int _curHour;
		public static int CurrentHour
		{
			get { return _curHour; }
			set { _curHour = value; }
		}

		static int _curDay;
		public static int CurrentDay
		{
			get { return _curDay; }
			set { _curDay = value; }
		}

		public static void Main(string[] args)
		{
			CurrentDay = DateTime.Now.Day;
			CurrentHour = DateTime.Now.Hour;
			CurrentMinute = DateTime.Now.Minute;
				
			var clockTimer = new Timer();
			clockTimer.Elapsed += new ElapsedEventHandler(RunClock);
			clockTimer.Interval = 1000;
			clockTimer.Enabled = true;
			clockTimer.Start();

			Console.ReadLine();
		}

		public static void RunClock(object src, ElapsedEventArgs arg)
		{
			
			CurrentSecond = DateTime.Now.Second;
			CurrentMinute = DateTime.Now.Minute;
			CurrentHour = DateTime.Now.Hour;
			CurrentDay = DateTime.Now.Day;


			string curSec = Convert.ToString(CurrentSecond, 2);
			string curMin = Convert.ToString(CurrentMinute, 2);
			string curHour = Convert.ToString(CurrentHour, 2);


			Console.WriteLine($"{curHour} - {curMin} - {curSec}\n");
		}
	}
}

