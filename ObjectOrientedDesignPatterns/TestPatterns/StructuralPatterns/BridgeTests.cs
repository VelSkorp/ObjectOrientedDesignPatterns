using StructuralPatterns.Bridge;

namespace TestPatterns.StructuralPatterns
{
	[TestFixture]
	public class BridgeTests
	{
		[Test]
		public void BridgeTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				var client = new Client();

				Abstraction abstraction;
				// The client code should be able to work with any pre-configured
				// abstraction-implementation combination.
				abstraction = new Abstraction(new ConcreteImplementationA());
				client.ClientCode(abstraction);

				Console.WriteLine();

				abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
				client.ClientCode(abstraction);

				Assert.That(stringWriter.ToString(), Is.EqualTo("Abstract: Base operation with:\nConcreteImplementationA: The result in platform A.\n\r\nExtendedAbstraction: Extended operation with:\nConcreteImplementationB: The result in platform B.\n"));
			}
		}
	}
}