using StructuralPatterns.Decorator;

namespace TestPatterns.StructuralPatterns
{
	[TestFixture]
	public class DecoratorTests
	{
		[Test]
		public void DecoratorTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				var client = new Client();
				var simple = new ConcreteComponent();
				Console.WriteLine("Client: I get a simple component:");
				client.ClientCode(simple);

				// ...as well as decorated ones.
				//
				// Note how decorators can wrap not only simple components but the
				// other decorators as well.
				var decorator1 = new ConcreteDecoratorA(simple);
				var decorator2 = new ConcreteDecoratorB(decorator1);
				Console.WriteLine("\nClient: Now I've got a decorated component:");
				client.ClientCode(decorator2);

				Assert.That(stringWriter.ToString(), Is.EqualTo("Client: I get a simple component:\r\nRESULT: ConcreteComponent\r\n\nClient: Now I've got a decorated component:\r\nRESULT: ConcreteDecoratorB(ConcreteDecoratorA(ConcreteComponent))\r\n"));
			}
		}
	}
}