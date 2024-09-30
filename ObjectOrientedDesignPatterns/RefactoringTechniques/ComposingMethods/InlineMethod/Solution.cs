namespace RefactoringTechniques.ComposingMethods.InlineMethod
{
	public class Solution
	{
		private int _numberOfLateDeliveries;

		public int GetRating()
		{
			return _numberOfLateDeliveries > 5 ? 2 : 1;
		}
	}
}