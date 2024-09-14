using BehavioralPatterns.Visitor;

namespace TestPatterns.BehavioralPatterns
{
	[TestFixture]
	public class VisitorTests
	{
		[Test]
		public void VisitorTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				var components = new List<IComponent>
				{
					new ConcreteComponentA(),
					new ConcreteComponentB()
				};

				Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
				Client.ClientCode(components, new ConcreteVisitor1());

				Console.WriteLine("\nIt allows the same client code to work with different types of visitors:");
				Client.ClientCode(components, new ConcreteVisitor2());

				Assert.That(stringWriter.ToString(), Is.EqualTo("The client code works with all visitors via the base Visitor interface:\r\nA + ConcreteVisitor1\r\nB + ConcreteVisitor1\r\n\nIt allows the same client code to work with different types of visitors:\r\nA + ConcreteVisitor2\r\nB + ConcreteVisitor2\r\n"));
			}
		}
	}
}