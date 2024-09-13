namespace BehavioralPatterns.TemplateMethod
{
	public class Client
	{
		/// <summary>
		/// The client code calls the template method to execute the algorithm.
		/// Client code does not have to know the concrete class of an object it
		/// works with, as long as it works with objects through the interface of
		/// their base class.
		/// </summary>
		public static void ClientCode(AbstractClass abstractClass)
		{
			abstractClass.TemplateMethod();
		}
	}
}