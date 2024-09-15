using System.Text;

namespace BehavioralPatterns.Strategy
{
	/// <summary>
	/// The Context defines the interface of interest to clients.
	/// </summary>
	public class Context
	{
		/// <summary>
		/// The Context maintains a reference to one of the Strategy objects. The
		/// Context does not know the concrete class of a strategy. It should
		/// work with all strategies via the Strategy interface.
		/// </summary>
		private IStrategy _strategy;

		public Context() { }

		/// <summary>
		/// Usually, the Context accepts a strategy through the constructor, but
		/// also provides a setter to change it at runtime.
		/// </summary>
		public Context(IStrategy strategy)
		{
			_strategy = strategy;
		}

		/// <summary>
		/// Usually, the Context allows replacing a Strategy object at runtime.
		/// </summary>
		public void SetStrategy(IStrategy strategy)
		{
			_strategy = strategy;
		}

		/// <summary>
		/// The Context delegates some work to the Strategy object instead of
		/// implementing multiple versions of the algorithm on its own.
		/// </summary>
		public void DoSomeBusinessLogic()
		{
			Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");

			var result = _strategy.DoAlgorithm(new List<char> { 'a', 'b', 'c', 'd', 'e' });
			var resultStr = new StringBuilder();

			foreach (var element in result)
			{
				resultStr.Append($"{element} ");
			}

			Console.WriteLine(resultStr.ToString());
		}
	}
}