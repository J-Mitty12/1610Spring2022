using System;

namespace MyApplication;
{
	class Program
	{
		static void Main(String[] args)
		{
			int day = 2;
			switch (day)
			{
				case 1:
					Console.WriteLine("Monday");
					break;
				case 2:
					Console.WriteLine("Tuesday");
					break;
				case 3:
					Console.WriteLine("Wednesday");
					break;
				case 4:
					Console.WriteLine("Thursday");
					break;
			}
		}
	}
}