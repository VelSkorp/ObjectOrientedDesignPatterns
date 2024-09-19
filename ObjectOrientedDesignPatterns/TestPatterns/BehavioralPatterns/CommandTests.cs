using BehavioralPatterns.Command;

namespace TestPatterns.BehavioralPatterns
{
	[TestFixture]
	public class CommandTests
	{
		[Test]
		public void CommandTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				// The client code can parameterize an invoker with any commands.
				var invoker = new Invoker();
				invoker.SetOnStart(new SimpleCommand("Say Hi!"));
				var receiver = new Receiver();
				invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

				invoker.DoSomethingImportant();

				Assert.That(stringWriter.ToString(), Is.EqualTo("Invoker: Does anybody want something done before I begin?\r\nSimpleCommand: See, I can do simple things like printing (Say Hi!)\r\nInvoker: ...doing something really important...\r\nInvoker: Does anybody want something done after I finish?\r\nComplexCommand: Complex stuff should be done by a receiver object.\r\nReceiver: Working on (Send email.)\r\nReceiver: Also working on (Save report.)\r\n"));
			}
		}
	}
}