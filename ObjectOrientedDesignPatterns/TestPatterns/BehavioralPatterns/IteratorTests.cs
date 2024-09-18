using BehavioralPatterns.Iterator;

namespace TestPatterns.BehavioralPatterns
{
	[TestFixture]
	public class IteratorTests
	{
		[Test]
		public void IteratorTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				// The client code may or may not know about the Concrete Iterator
				// or Collection classes, depending on the level of indirection you
				// want to keep in your program.
				var collection = new WordsCollection();
				collection.AddItem("First");
				collection.AddItem("Second");
				collection.AddItem("Third");

				Console.WriteLine("Straight traversal:");

				foreach (var element in collection)
				{
					Console.WriteLine(element);
				}

				Console.WriteLine("\nReverse traversal:");

				collection.ReverseDirection();

				foreach (var element in collection)
				{
					Console.WriteLine(element);
				}

				Assert.That(stringWriter.ToString(), Is.EqualTo("Straight traversal:\r\nFirst\r\nSecond\r\nThird\r\n\nReverse traversal:\r\nThird\r\nSecond\r\nFirst\r\n"));
			}
		}
	}
}