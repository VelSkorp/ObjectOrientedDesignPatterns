namespace RefactoringTechniques.ComposingMethods.ExtractMethod
{
	public class Solution
	{
		public void PrintOwing()
		{
			PrintBanner();
			PrintDetails();
		}

		public void PrintDetails()
		{
			Console.WriteLine("name: " + name);
			Console.WriteLine("amount: " + GetOutstanding());
		}
	}
}