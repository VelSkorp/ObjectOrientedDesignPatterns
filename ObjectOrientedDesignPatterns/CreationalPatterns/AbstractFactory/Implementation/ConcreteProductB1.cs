namespace CreationalPatterns.AbstractFactory
{
	/// <summary>
	/// Concrete Products are created by corresponding Concrete Factories.
	/// </summary>
	public class ConcreteProductB1 : IAbstractProductB
	{
		public string UsefulFunctionB()
		{
			return "The result of the product B1.";
		}

		public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
		{
			var result = collaborator.UsefulFunctionA();

			return $"The result of the B1 collaborating with the ({result})";
		}
	}
}