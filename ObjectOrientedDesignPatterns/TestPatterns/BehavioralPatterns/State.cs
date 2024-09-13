using BehavioralPatterns.State;

namespace TestPatterns.BehavioralPatterns
{
	[TestFixture]
	public class StateTests
	{
		[Test]
		public void StateTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				var context = new Context(new ConcreteStateA());
				context.Handle1();
				context.Handle2();

				Assert.That(stringWriter.ToString(), Is.EqualTo("Context: Transition to ConcreteStateA.\r\nConcreteStateA handles request1.\r\nConcreteStateA wants to change the state of the context.\r\nContext: Transition to ConcreteStateB.\r\nConcreteStateB handles request2.\r\nConcreteStateB wants to change the state of the context.\r\nContext: Transition to ConcreteStateA.\r\n"));
			}
		}
	}
}