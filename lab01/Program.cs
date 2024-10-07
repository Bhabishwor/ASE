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
			DialogResult result = DialogResult.Yes;
			
			while (result == DialogResult.Yes)
			{
				float weight = ReadMeasurement("Weight(kg)");
				float height = ReadMeasurement("Height(m)");
				char gender = ReadGender();

				float bmi = CalculateBMI(weight, height);
				string category = CategorizeBMI(bmi, gender);

				string message = "BMI: " + bmi +
								 "\nYou are " + category;

				MessageBox.Show(
						message,
						"lab01",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
						);

				result = MessageBox.Show(
						"Do you want to calculate another BMI?",
						"lab01",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question
						);
			}
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

		private float CalculateBMI(float weight, float height)
		{	
			return weight / (height * height);
		}

		private string CategorizeBMI(float bmi, char gender)
		{
			if (bmi < 17.5 && gender == 'F' || bmi < 18.5 && gender == 'M')
			{
				return "severely underweight";
			}
			else if (bmi < 19.1 && gender == 'F' || bmi < 20.7 && gender == 'M')
			{
				return "underweight";
			}
			else if (bmi < 25.8 && gender == 'F' || bmi < 26.4 && gender == 'M')
			{
				return "in normal range";
			}
			else if (bmi < 27.3 && gender == 'F' || bmi < 27.8 && gender == 'M')
			{
				return "marginally overweight";
			}
			else if (bmi < 32.3 && gender == 'F' || bmi < 31.1 && gender == 'M')
			{
				return "overweight";
			}
			else if (bmi < 35)
			{
				return "very overweight or obese";
			}
			else if (bmi < 40)
			{
				return "severely obese";
			}
			else if (bmi < 50)
			{
				return "morbidly obese";
			}
			else if (bmi < 60)
			{
				return "super obese";
			}
			else
			{
				return "not in any category. BMI too high to categorize.";
			}
		}
	}
}
