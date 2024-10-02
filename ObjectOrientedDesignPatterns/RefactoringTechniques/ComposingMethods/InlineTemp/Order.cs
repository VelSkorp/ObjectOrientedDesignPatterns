namespace RefactoringTechniques.ComposingMethods.InlineTemp
{
	public class Order
	{
		public double BasePrice()
		{
			return new Random().NextDouble();
		}
	}
}