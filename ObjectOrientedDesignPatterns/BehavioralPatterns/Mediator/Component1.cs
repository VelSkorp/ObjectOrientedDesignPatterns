﻿namespace BehavioralPatterns.Mediator
{
	/// <summary>
	/// Concrete Components implement various functionality. They don't depend on
	/// other components. They also don't depend on any concrete mediator
	/// classes.
	/// </summary>
	public class Component1 : BaseComponent
	{
		public void DoA()
		{
			Console.WriteLine("Component 1 does A.");

			_mediator.Notify(this, "A");
		}

		public void DoB()
		{
			Console.WriteLine("Component 1 does B.");

			_mediator.Notify(this, "B");
		}
	}
}