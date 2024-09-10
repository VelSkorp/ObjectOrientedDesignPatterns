namespace CreationalPatterns.AbstractFactory
{
	/// <summary>
	/// Each Concrete Factory has a corresponding product variant.
	/// </summary>
	public class ConcreteFactory2 : IAbstractFactory
	{
		public IAbstractProductA CreateProductA()
		{
			return new ConcreteProductA2();
		}

		public IAbstractProductB CreateProductB()
		{
			return new ConcreteProductB2();
		}
	}
}
