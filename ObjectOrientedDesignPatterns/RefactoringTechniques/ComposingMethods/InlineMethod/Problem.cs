namespace RefactoringTechniques.ComposingMethods.InlineMethod
{
	public class Problem
	{
		private int _numberOfLateDeliveries;

		public int GetRating()
		{
			return MoreThanFiveLateDeliveries() ? 2 : 1;
		}
		public bool MoreThanFiveLateDeliveries()
		{
			return _numberOfLateDeliveries > 5;
		}
	}
}