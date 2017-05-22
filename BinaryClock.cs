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

			int zeroCountSec = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(curSec.Length) / 8)) * 8;
			int zeroCountMin = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(curMin.Length) / 8)) * 8;
			int zeroCountHour = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(curHour.Length) / 8)) * 8;

			string outputSec = curSec.PadLeft(zeroCountSec, '0');
			string outputMin = curMin.PadLeft(zeroCountMin, '0');
			string outputHour = curHour.PadLeft(zeroCountHour, '0');

			Console.WriteLine($"\r{outputHour} - {outputMin} - {outputSec}");


		}

	}
}

