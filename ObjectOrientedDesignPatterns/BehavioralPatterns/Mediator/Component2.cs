namespace BehavioralPatterns.Mediator
{
	/// <summary>
	/// Concrete Components implement various functionality. They don't depend on
	/// other components. They also don't depend on any concrete mediator
	/// classes.
	/// </summary>
	public class Component2 : BaseComponent
	{
		public void DoC()
		{
			Console.WriteLine("Component 2 does C.");

			_mediator.Notify(this, "C");
		}

		public void DoD()
		{
			Console.WriteLine("Component 2 does D.");

			_mediator.Notify(this, "D");
		}
	}
}