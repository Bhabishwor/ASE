using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			MessageBox.Show(
				"Hello, World!",
				"lab01",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}
	}
}
