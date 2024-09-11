using Newtonsoft.Json;

namespace StructuralPatterns.Flyweight
{
	/// <summary>
	/// The Flyweight stores a common portion of the state (also called intrinsic
	/// state) that belongs to multiple real business entities. The Flyweight
	/// accepts the rest of the state (extrinsic state, unique for each entity)
	/// via its method parameters.
	/// </summary>
	public class Flyweight
	{
		private Car _sharedState;

		public Flyweight(Car car)
		{
			_sharedState = car;
		}

		public void Operation(Car uniqueState)
		{
			var s = JsonConvert.SerializeObject(_sharedState);
			var u = JsonConvert.SerializeObject(uniqueState);
			Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
		}
	}
}