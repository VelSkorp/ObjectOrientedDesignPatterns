using BehavioralPatterns.Observer;

namespace TestPatterns.BehavioralPatterns
{
	[TestFixture]
	public class ObserverTests
	{
		[Test]
		public void ObserverTest()
		{
			var editor = new Editor();
			var logger = new LoggingListener("/path/to/log.txt", "Someone has opened the file: %s");
			editor.Events.Subscribe("open", logger);

			var stream = editor.OpenFile("/path/to/file.txt");
			stream.Close();

			Assert.That(File.Exists("/path/to/log.txt"), Is.True);
		}
	}
}