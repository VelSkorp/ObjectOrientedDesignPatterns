namespace CreationalPatterns.Singleton
{
	/// <summary>
	/// This Singleton implementation is called "double check lock". It is safe
	/// in multithreaded environment and provides lazy initialization for the
	/// Singleton object.
	/// </summary>
	public sealed class ThreadSafeSingleton
	{
		// The Singleton's instance is stored in a static field. There there are
		// multiple ways to initialize this field, all of them have various pros
		// and cons. In this example we'll show the simplest of these ways,
		// which, however, doesn't work really well in multithreaded program.
		private static readonly ThreadSafeSingleton Instance = new ThreadSafeSingleton();

		// Explicit static constructor to tell C# compiler
		// not to mark type as beforefieldinit
		static ThreadSafeSingleton() { }

		// The Singleton's constructor should always be private to prevent
		// direct construction calls with the `new` operator.
		private ThreadSafeSingleton() { }

		public static ThreadSafeSingleton GetInstance()
		{
			return Instance;
		}

		// Finally, any singleton should define some business logic, which can
		// be executed on its instance.
		public void SomeBusinessLogic()
		{
		}
	}
}