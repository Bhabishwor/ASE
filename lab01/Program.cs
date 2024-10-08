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
			DialogResult repeatPrompt = DialogResult.Yes;
			
			while (repeatPrompt == DialogResult.Yes)
			{
				DialogResult isMetric = MessageBox.Show(
					"Are you using the metric system?",
					"Metric or Imperial?",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question
				);
				
				Console.WriteLine(
					"Using " + 
					(isMetric == DialogResult.Yes ? "kilograms & metres" : "pounds & inches") + 
					"..."
				);

				float weight = UserInput.ReadMeasurement("Weight");
				float height = UserInput.ReadMeasurement("Height");
				char gender = UserInput.ReadGender();
				
				float bmi = BMI.Calculate(weight, height, isMetric);
				string category = BMI.Categorize(bmi, gender);

				string message = "BMI: " + bmi + "\nYou are " + category;
				MessageBox.Show(
					message,
					"Result",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);

				repeatPrompt = MessageBox.Show(
					"Do you want to calculate another BMI?",
					"Calculate Again?",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question
				);
			}
		}
	}
}
