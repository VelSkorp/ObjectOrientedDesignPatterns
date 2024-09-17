using BehavioralPatterns.Mediator;

namespace TestPatterns.BehavioralPatterns
{
	[TestFixture]
	public class MediatorTests
	{
		[Test]
		public void MediatorTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				// The client code.
				var component1 = new Component1();
				var component2 = new Component2();
				new ConcreteMediator(component1, component2);

				Console.WriteLine("Client triggers operation A.");
				component1.DoA();

				Console.WriteLine("\nClient triggers operation D.");
				component2.DoD();

				Assert.That(stringWriter.ToString(), Is.EqualTo("Client triggers operation A.\r\nComponent 1 does A.\r\nMediator reacts on A and triggers following operations:\r\nComponent 2 does C.\r\n\nClient triggers operation D.\r\nComponent 2 does D.\r\nMediator reacts on D and triggers following operations:\r\nComponent 1 does B.\r\nComponent 2 does C.\r\n"));
			}
		}
	}
}