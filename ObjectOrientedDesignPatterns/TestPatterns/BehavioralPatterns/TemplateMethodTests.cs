using BehavioralPatterns.TemplateMethod;

namespace TestPatterns.BehavioralPatterns
{
	[TestFixture]
	public class TemplateMethodTests
	{
		[Test]
		public void TemplateMethodTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				Console.WriteLine("Same client code can work with different subclasses:");

				Client.ClientCode(new ConcreteClass1());

				Console.WriteLine("\nSame client code can work with different subclasses:");

				Client.ClientCode(new ConcreteClass2());

				Assert.That(stringWriter.ToString(), Is.EqualTo("Same client code can work with different subclasses:\r\nAbstractClass says: I am doing the bulk of the work\r\nConcreteClass1 says: Implemented Operation1\r\nAbstractClass says: But I let subclasses override some operations\r\nConcreteClass1 says: Implemented Operation2\r\nAbstractClass says: But I am doing the bulk of the work anyway\r\n\nSame client code can work with different subclasses:\r\nAbstractClass says: I am doing the bulk of the work\r\nConcreteClass2 says: Implemented Operation1\r\nAbstractClass says: But I let subclasses override some operations\r\nConcreteClass2 says: Overridden Hook1\r\nConcreteClass2 says: Implemented Operation2\r\nAbstractClass says: But I am doing the bulk of the work anyway\r\n"));
			}
		}
	}
}