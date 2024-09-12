namespace BehavioralPatterns.State
{
	/// <summary>
	/// The Context defines the interface of interest to clients. It also
	/// maintains a reference to an instance of a State subclass, which
	/// represents the current state of the Context.
	/// </summary>
	public class Context
	{
		// A reference to the current state of the Context.
		private State _state = null;

		public Context(State state)
		{
			TransitionTo(state);
		}

		/// <summary>
		/// The Context allows changing the State object at runtime.
		/// </summary>
		public void TransitionTo(State state)
		{
			Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
			_state = state;
			_state.SetContext(this);
		}

		/// <summary>
		/// The Context delegates part of its behavior to the current State object.
		/// </summary>
		public void Handle1()
		{
			_state.Handle1();
		}

		/// <summary>
		/// The Context delegates part of its behavior to the current State object.
		/// </summary>
		public void Handle2()
		{
			_state.Handle2();
		}
	}
}
