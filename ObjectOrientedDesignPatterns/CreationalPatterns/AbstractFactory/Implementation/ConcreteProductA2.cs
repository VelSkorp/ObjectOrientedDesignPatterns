namespace CreationalPatterns.AbstractFactory
{
	/// <summary>
	/// Concrete Products are created by corresponding Concrete Factories.
	/// </summary>
	public class ConcreteProductA2 : IAbstractProductA
	{
		public string UsefulFunctionA()
		{
			return "The result of the product A2.";
		}
	}
}