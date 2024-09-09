namespace CreationalPatterns.Singleton
{
	/// <summary>
	/// This Singleton implementation is called "double check lock". It is safe
	/// in multithreaded environment and provides lazy initialization for the
	/// Singleton object.
	/// </summary>
	public sealed class ThreadSafeWithLockSingleton
	{
		// We'll use this property to prove that our Singleton really works.
		public string Value { get; set; }

		// The Singleton's instance is stored in a static field. There there are
		// multiple ways to initialize this field, all of them have various pros
		// and cons. In this example we'll show the simplest of these ways,
		// which, however, doesn't work really well in multithreaded program.
		private static ThreadSafeWithLockSingleton Instance;

		// We now have a lock object that will be used to synchronize threads
		// during first access to the Singleton.
		private static readonly object LockObject = new object();

		// The Singleton's constructor should always be private to prevent
		// direct construction calls with the `new` operator.
		private ThreadSafeWithLockSingleton() { }

		// This is the static method that controls the access to the singleton
		// instance. On the first run, it creates a singleton object and places
		// it into the static field. On subsequent runs, it returns the client
		// existing object stored in the static field.
		public static ThreadSafeWithLockSingleton GetInstance(string value)
		{
			// This conditional is needed to prevent threads stumbling over the
			// lock once the instance is ready.
			if (Instance is null)
			{
				// Now, imagine that the program has just been launched. Since
				// there's no Singleton instance yet, multiple threads can
				// simultaneously pass the previous conditional and reach this
				// point almost at the same time. The first of them will acquire
				// lock and will proceed further, while the rest will wait here.
				lock (LockObject)
				{
					// The first thread to acquire the lock, reaches this
					// conditional, goes inside and creates the Singleton
					// instance. Once it leaves the lock block, a thread that
					// might have been waiting for the lock release may then
					// enter this section. But since the Singleton field is
					// already initialized, the thread won't create a new
					// object.
					Instance ??= new ThreadSafeWithLockSingleton
					{
						Value = value
					};
				}
			}

			return Instance;
		}

		// Finally, any singleton should define some business logic, which can
		// be executed on its instance.
		public void SomeBusinessLogic()
		{
		}
	}
}