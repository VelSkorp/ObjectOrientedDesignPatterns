namespace RefactoringTechniques.ComposingMethods.ReplaceMethodWithMethodObject
{
	public class Problem
	{
		public class Order
		{
			public double Price()
			{
				double primaryBasePrice = 5.5;
				double secondaryBasePrice = 10.9;
				double tertiaryBasePrice = 30;
				// Perform long computation.
				return primaryBasePrice + secondaryBasePrice + tertiaryBasePrice;
			}
		}
	}
}