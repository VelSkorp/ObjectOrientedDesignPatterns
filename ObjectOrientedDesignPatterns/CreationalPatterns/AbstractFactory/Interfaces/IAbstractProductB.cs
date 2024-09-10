namespace CreationalPatterns.AbstractFactory
{
	/// <summary>
	/// Here's the the base interface of another product. All products can
	/// interact with each other, but proper interaction is possible only between
	/// products of the same concrete variant.
	/// </summary>
	public interface IAbstractProductB
	{

		/// <summary>
		/// Product B is able to do its own thing...
		/// </summary>
		string UsefulFunctionB();


		/// <summary>
		/// ...but it also can collaborate with the ProductA.
		///
		/// The Abstract Factory makes sure that all products it creates are of
		/// the same variant and thus, compatible.
		/// </summary>
		string AnotherUsefulFunctionB(IAbstractProductA collaborator);
	}
}