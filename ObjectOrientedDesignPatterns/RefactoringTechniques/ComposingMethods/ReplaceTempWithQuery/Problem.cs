namespace RefactoringTechniques.ComposingMethods.ReplaceTempWithQuery
{
	public class Problem
	{
		private double _quantity = 10;
		private double _itemPrice = 10;

		public double CalculateTotal()
		{
			double basePrice = _quantity * _itemPrice;

			if (basePrice > 1000)
			{
				return basePrice * 0.95;
			}
			else
			{
				return basePrice * 0.98;
			}
		}
	}
}