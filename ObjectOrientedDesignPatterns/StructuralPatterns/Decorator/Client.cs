namespace StructuralPatterns.Decorator
{
	public class Client
	{
		/// <summary>
		/// The client code works with all objects using the Component interface.
		/// This way it can stay independent of the concrete classes of
		/// components it works with.
		/// </summary>
		public void ClientCode(Component component)
		{
			Console.WriteLine("RESULT: " + component.Operation());
		}
	}
}