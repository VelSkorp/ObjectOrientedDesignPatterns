
namespace RefactoringTechniques.ComposingMethods.InlineTemp
{
	public class Problem
	{
		public bool HasDiscount(Order order)
		{
			double basePrice = order.BasePrice();
			return basePrice > 1000;
		}
	}
}