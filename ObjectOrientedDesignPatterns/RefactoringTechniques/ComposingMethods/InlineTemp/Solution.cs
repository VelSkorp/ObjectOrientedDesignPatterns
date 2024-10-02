namespace RefactoringTechniques.ComposingMethods.InlineTemp
{
	public class Solution
	{
		public bool HasDiscount(Order order)
		{
			return order.BasePrice() > 1000;
		}
	}
}