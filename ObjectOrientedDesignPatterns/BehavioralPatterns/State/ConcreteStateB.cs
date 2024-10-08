﻿namespace BehavioralPatterns.State
{
	/// <summary>
	/// Concrete States implement various behaviors, associated with a state of
	/// the Context.
	/// </summary>
	public class ConcreteStateB : State
	{
		public override void Handle1()
		{
			Console.WriteLine("ConcreteStateB handles request1.");
		}

		public override void Handle2()
		{
			Console.WriteLine("ConcreteStateB handles request2.");
			Console.WriteLine("ConcreteStateB wants to change the state of the context.");
			_context.TransitionTo(new ConcreteStateA());
		}
	}
}