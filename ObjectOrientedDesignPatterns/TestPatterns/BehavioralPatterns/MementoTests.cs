using BehavioralPatterns.Memento;

namespace TestPatterns.BehavioralPatterns
{
	[TestFixture]
	public class MementoTests
	{
		[Test]
		public void MementoTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				var originator = new Originator("Super-duper-super-puper-super.");
				var caretaker = new Caretaker(originator);

				caretaker.Backup();
				originator.DoSomething();

				caretaker.Backup();
				originator.DoSomething();

				caretaker.Backup();
				originator.DoSomething();

				Console.WriteLine();
				caretaker.ShowHistory();

				Console.WriteLine("\nClient: Now, let's rollback!\n");
				caretaker.Undo();

				Console.WriteLine("\n\nClient: Once more!\n");
				caretaker.Undo();

				Console.WriteLine();

				Assert.That(stringWriter.ToString(), Is.Not.Empty);
			}
		}
	}
}