using StructuralPatterns.Adapter;

namespace TestPatterns.StructuralPatterns
{
	[TestFixture]
	public class AdapterTests
	{
		[Test]
		public void AdapterTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				var adaptee = new Adaptee();
				ITarget target = new Adapter(adaptee);

				Console.WriteLine("Adaptee interface is incompatible with the client.");
				Console.WriteLine("But with adapter client can call it's method.");

				Console.WriteLine(target.GetRequest());

				Assert.That(stringWriter.ToString(), Is.EqualTo("Adaptee interface is incompatible with the client.\r\nBut with adapter client can call it's method.\r\nThis is 'Specific request.'\r\n"));
			}
		}
	}
}