namespace RefactoringTechniques.ComposingMethods.ExtractMethod
{
	public class Solution
	{
		private string _name = "Solution";

		public void PrintOwing()
		{
			PrintBanner();
			PrintDetails();
		}

		public void PrintDetails()
		{
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