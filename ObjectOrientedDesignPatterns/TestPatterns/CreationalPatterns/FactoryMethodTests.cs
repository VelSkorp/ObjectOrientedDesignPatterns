using CreationalPatterns.FactoryMethod;

namespace TestPatterns.CreationalPatterns
{
	[TestFixture]
	public class FactoryMethodTests
	{
		[Test]
		public void FactoryMethodTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				var client = new Client();
				Console.WriteLine("App: Launched with the ConcreteCreator1.");
				client.ClientCode(new ConcreteCreator1());

				Console.WriteLine("\nApp: Launched with the ConcreteCreator2.");
				client.ClientCode(new ConcreteCreator2());

				Assert.That(stringWriter.ToString(), Is.EqualTo("App: Launched with the ConcreteCreator1.\r\nClient: I'm not aware of the creator's class, but it still works.\nCreator: The same creator's code has just worked with {Result of ConcreteProduct1}\r\n\nApp: Launched with the ConcreteCreator2.\r\nClient: I'm not aware of the creator's class, but it still works.\nCreator: The same creator's code has just worked with {Result of ConcreteProduct2}\r\n"));
			}
		}
	}
}