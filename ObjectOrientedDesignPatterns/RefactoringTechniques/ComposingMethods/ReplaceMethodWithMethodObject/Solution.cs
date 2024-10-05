namespace RefactoringTechniques.ComposingMethods.ReplaceMethodWithMethodObject
{
	public class Solution
	{
		public class Order
		{
			public double BasePrice => 5.5;

			public double Price()
			{
				return new PriceCalculator(this).Compute();
			}
		}

		public class PriceCalculator
		{
			private readonly double primaryBasePrice;
			private readonly double secondaryBasePrice = 10.9;
			private readonly double tertiaryBasePrice = 30;

			public PriceCalculator(Order order)
			{
				// Copy relevant information from the
				// order object.
				primaryBasePrice = order.BasePrice;
			}

			public double Compute()
			{
				// Perform long computation.
				return primaryBasePrice + secondaryBasePrice + tertiaryBasePrice;
			}
		}
	}
}