namespace CreationalPatterns.Singleton
{
	/// <summary>
	/// The Singleton class defines the `GetInstance` method that serves as an
	/// alternative to constructor and lets clients access the same instance of
	/// this class over and over.
	/// The Singleton should always be a 'sealed' class to prevent class
	/// inheritance through external classes and also through nested classes.
	/// </summary>
	public sealed class LazySingleton
	{
		// The Singleton's instance is stored in a static field. There there are
		// multiple ways to initialize this field, all of them have various pros
		// and cons. In this example we'll show the simplest of these ways,
		// which, however, doesn't work really well in multithreaded program.
		public static LazySingleton Instance => Nested.Instance;

		// The Singleton's constructor should always be private to prevent
		// direct construction calls with the `new` operator.
		private LazySingleton() { }

		private class Nested
		{
			// Explicit static constructor to tell C# compiler
			// not to mark type as beforefieldinit
			static Nested()
			{
			}

			internal static readonly LazySingleton Instance = new LazySingleton();
		} 

		// Finally, any singleton should define some business logic, which can
		// be executed on its instance.
		public void SomeBusinessLogic()
		{
		}
	}
}