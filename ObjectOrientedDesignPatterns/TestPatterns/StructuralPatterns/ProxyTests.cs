using StructuralPatterns.Proxy;

namespace TestPatterns.StructuralPatterns
{
	[TestFixture]
	public class ProxyTests
	{
		[Test]
		public void ProxyTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				var client = new Client();

				Console.WriteLine("Client: Executing the client code with a real subject:");
				var realSubject = new RealSubject();
				client.ClientCode(realSubject);

				Console.WriteLine("\nClient: Executing the same client code with a proxy:");
				var proxy = new Proxy(realSubject);
				client.ClientCode(proxy);

				Assert.That(stringWriter.ToString(), Is.EqualTo("Client: Executing the client code with a real subject:\r\nRealSubject: Handling Request.\r\n\nClient: Executing the same client code with a proxy:\r\nProxy: Checking access prior to firing a real request.\r\nRealSubject: Handling Request.\r\nProxy: Logging the time of request.\r\n"));
			}
		}
	}
}