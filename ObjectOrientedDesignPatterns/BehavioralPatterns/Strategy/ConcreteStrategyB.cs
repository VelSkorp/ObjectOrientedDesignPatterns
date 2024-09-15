namespace BehavioralPatterns.Strategy
{
	/// <summary>
	/// Concrete Strategies implement the algorithm while following the base
	/// Strategy interface. The interface makes them interchangeable in the
	/// Context.
	/// </summary>
	public class ConcreteStrategyB : IStrategy
	{
		public List<char> DoAlgorithm(List<char> data)
		{
			data.Sort();
			data.Reverse();
			return data;
		}
	}
}