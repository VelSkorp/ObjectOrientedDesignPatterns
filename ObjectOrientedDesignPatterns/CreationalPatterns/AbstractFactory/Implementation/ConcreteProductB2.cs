namespace CreationalPatterns.AbstractFactory
{
	/// <summary>
	/// Concrete Products are created by corresponding Concrete Factories.
	/// </summary>
	public class ConcreteProductB2 : IAbstractProductB
	{
		public string UsefulFunctionB()
		{
			return "The result of the product B2.";
		}

		/// <summary>
		/// The variant, Product B2, is only able to work correctly with the
		/// variant, Product A2. Nevertheless, it accepts any instance of
		/// AbstractProductA as an argument.
		/// </summary>
		public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
		{
			var result = collaborator.UsefulFunctionA();

			return $"The result of the B2 collaborating with the ({result})";
		}
	}
}