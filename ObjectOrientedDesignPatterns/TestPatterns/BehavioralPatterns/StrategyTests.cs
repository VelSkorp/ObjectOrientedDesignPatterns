using BehavioralPatterns.Strategy;

namespace TestPatterns.BehavioralPatterns
{
	[TestFixture]
	public class StrategyTests
	{
		[Test]
		public void StrategyTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				// The client code picks a concrete strategy and passes it to the
				// context. The client should be aware of the differences between
				// strategies in order to make the right choice.
				var context = new Context();

				Console.WriteLine("Client: Strategy is set to normal sorting.");
				context.SetStrategy(new ConcreteStrategyA());
				context.DoSomeBusinessLogic();

				Console.WriteLine("\nClient: Strategy is set to reverse sorting.");
				context.SetStrategy(new ConcreteStrategyB());
				context.DoSomeBusinessLogic();

				Assert.That(stringWriter.ToString(), Is.EqualTo("Client: Strategy is set to normal sorting.\r\nContext: Sorting data using the strategy (not sure how it'll do it)\r\na b c d e \r\n\nClient: Strategy is set to reverse sorting.\r\nContext: Sorting data using the strategy (not sure how it'll do it)\r\ne d c b a \r\n"));
			}
		}
	}
}