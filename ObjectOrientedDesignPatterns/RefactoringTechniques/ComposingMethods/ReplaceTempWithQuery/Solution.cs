namespace RefactoringTechniques.ComposingMethods.ReplaceTempWithQuery
{
	public class Solution
	{
		private double _quantity = 10;
		private double _itemPrice = 10;

		public double CalculateTotal()
		{
			if (BasePrice() > 1000)
			{
				return BasePrice() * 0.95;
			}
			else
			{
				return BasePrice() * 0.98;
			}
		}

		public double BasePrice()
		{
			return _quantity * _itemPrice;
		}
	}
}