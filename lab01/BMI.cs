using System.Windows.Forms;

namespace lab01
{
	public static class BMI
	{
		public static float Calculate(float weight, float height, DialogResult isMetric)
		{	
			return weight / (height * height) * (isMetric == DialogResult.Yes ? 1 : 703);
		}
		
		public static string Categorize(float bmi, char gender)
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
