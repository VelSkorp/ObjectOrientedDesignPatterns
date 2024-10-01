namespace RefactoringTechniques.ComposingMethods.ExtractMethod
{
	public class Problem
	{
		private string _name = "Problem";

		public void PrintOwing()
		{
			PrintBanner();

			// Print details.
			Console.WriteLine("name: " + _name);
			Console.WriteLine("amount: " + GetOutstanding());
		}

		public void PrintBanner()
		{
			// Some print logic
		}

		public decimal GetOutstanding()
		{
			// Some calculations
			return 0;
		}
	}
}