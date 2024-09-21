using StructuralPatterns.Composite;

namespace TestPatterns.StructuralPatterns
{
	[TestFixture]
	public class CompositeTests
	{
		[Test]
		public void CompositeTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				var client = new Client();

				// This way the client code can support the simple leaf
				// components...
				var leaf = new Leaf();
				Console.WriteLine("Client: I get a simple component:");
				client.ClientCode(leaf);

				// ...as well as the complex composites.
				var tree = new Composite();
				var branch1 = new Composite();
				branch1.Add(new Leaf());
				branch1.Add(new Leaf());
				var branch2 = new Composite();
				branch2.Add(new Leaf());
				tree.Add(branch1);
				tree.Add(branch2);
				Console.WriteLine("Client: Now I've got a composite tree:");
				client.ClientCode(tree);

				Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
				client.ClientCode2(tree, leaf);

				Assert.That(stringWriter.ToString(), Is.EqualTo("Client: I get a simple component:\r\nRESULT: Leaf\n\r\nClient: Now I've got a composite tree:\r\nRESULT: Branch(Branch(Leaf+Leaf)+Branch(Leaf))\n\r\nClient: I don't need to check the components classes even when managing the tree:\nRESULT: Branch(Branch(Leaf+Leaf)+Branch(Leaf)+Leaf)\r\n"));
			}
		}
	}
}