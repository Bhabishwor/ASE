using System;
using System.Windows.Forms;

namespace lab01
{
	class Program
	{
		static void Main(string[] args)
		{
			Program app = new Program();
		}

		public Program()
		{
			float weight = ReadMeasurement("Weight(kg)");
			float height = ReadMeasurement("Height(m)");
			char gender = ReadGender();
			
			string message = 
				"Weight(kg): " + weight.ToString() + 
				"\nHeight(m): " + height.ToString() +
				"\nGender: " + gender;

			MessageBox.Show(
				message,
				"lab01",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}

		private float ReadMeasurement(string type)
		{ 
			Console.Write(type + ": ");
			return Single.Parse(Console.ReadLine());
		}

		private char ReadGender()
		{
			Console.Write("Gender (M/F): ");
			return Char.Parse(Console.ReadLine());
		}
	}
}
