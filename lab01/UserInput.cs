using System;

namespace lab01
{
	public static class UserInput
	{
		public static float ReadMeasurement(string type)
		{ 
			Console.Write(type + ": ");
			return Single.Parse(Console.ReadLine());
		}

		public static char ReadGender()
		{
			Console.Write("Gender (M/F): ");
			return Char.Parse(Console.ReadLine());
		}
	}
}
