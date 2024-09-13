using CreationalPatterns.Singleton;

namespace TestPatterns.CreationalPatterns
{
	[TestFixture]
	public class SingletonTests
	{
		[Test]
		public void SloppySingletonTest()
		{
			var s1 = SloppySingleton.GetInstance();
			var s2 = SloppySingleton.GetInstance();

			Assert.That(s2 ,Is.EqualTo(s1));
		}

		[Test]
		public void ThreadSafeSingletonTest()
		{
			var s1 = ThreadSafeSingleton.GetInstance();
			var s2 = ThreadSafeSingleton.GetInstance();

			Assert.That(s2, Is.EqualTo(s1));
		}

		[Test]
		public void LazySingletonTest()
		{
			var s1 = LazySingleton.Instance;
			var s2 = LazySingleton.Instance;

			Assert.That(s2, Is.EqualTo(s1));
		}

		[Test]
		public void NewLazySingletonTest()
		{
			var s1 = NewLazySingleton.Instance;
			var s2 = NewLazySingleton.Instance;

			Assert.That(s2, Is.EqualTo(s1));
		}

		[Test]
		public void ThreadSafeWithLockSingletonTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				var process1 = new Thread(() =>
				{
					var singleton = ThreadSafeWithLockSingleton.GetInstance("FOO");
					Console.WriteLine(singleton.Value);
				});

				var process2 = new Thread(() =>
				{
					var singleton = ThreadSafeWithLockSingleton.GetInstance("BAR");
					Console.WriteLine(singleton.Value);
				});

				process1.Start();
				process2.Start();

				process1.Join();
				process2.Join();

				Assert.That(stringWriter.ToString(), Is.EqualTo("FOO\r\nFOO\r\n"));
			}
		}
	}
}