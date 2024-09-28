namespace CreationalPatterns.FactoryMethod
{
	/// <summary>
	/// Concrete Products provide various implementations of the Product interface.
	/// </summary>
	public class ConcreteProduct1 : IProduct
	{
		public string Operation()
		{
			return "{Result of ConcreteProduct1}";
		}
	}
}