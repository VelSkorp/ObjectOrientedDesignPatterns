namespace CreationalPatterns.FactoryMethod
{
	public class Client
	{
		/// <summary>
		/// The client code works with an instance of a concrete creator, albeit
		/// through its base interface. As long as the client keeps working with
		/// the creator via the base interface, you can pass it any creator's
		/// subclass.
		/// </summary>
		public void ClientCode(Creator creator)
		{
			Console.WriteLine($"Client: I'm not aware of the creator's class, but it still works.\n{creator.SomeOperation()}");
		}
	}
}