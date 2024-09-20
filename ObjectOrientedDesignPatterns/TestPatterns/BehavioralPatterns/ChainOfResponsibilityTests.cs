using BehavioralPatterns.ChainOfResponsibility;

namespace TestPatterns.BehavioralPatterns
{
	[TestFixture]
	public class ChainOfResponsibilityTests
	{
		[Test]
		public void ChainOfResponsibilityTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				// The other part of the client code constructs the actual chain.
				var monkey = new MonkeyHandler();
				var squirrel = new SquirrelHandler();
				var dog = new DogHandler();

				monkey.SetNext(squirrel).SetNext(dog);

				// The client should be able to send a request to any handler, not
				// just the first one in the chain.
				Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
				Client.ClientCode(monkey);

				Console.WriteLine("\nSubchain: Squirrel > Dog\n");
				Client.ClientCode(squirrel);

				Assert.That(stringWriter.ToString(), Is.EqualTo("Chain: Monkey > Squirrel > Dog\n\r\nClient: Who wants a Nut?\r\n   Squirrel: I'll eat the Nut.\nClient: Who wants a Banana?\r\n   Monkey: I'll eat the Banana.\nClient: Who wants a Cup of coffee?\r\n   Cup of coffee was left untouched.\r\n\nSubchain: Squirrel > Dog\n\r\nClient: Who wants a Nut?\r\n   Squirrel: I'll eat the Nut.\nClient: Who wants a Banana?\r\n   Banana was left untouched.\r\nClient: Who wants a Cup of coffee?\r\n   Cup of coffee was left untouched.\r\n"));
			}
		}
	}
}