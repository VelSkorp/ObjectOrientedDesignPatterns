namespace StructuralPatterns.Flyweight
{
	/// <summary>
	/// The Flyweight Factory creates and manages the Flyweight objects. It
	/// ensures that flyweights are shared correctly. When the client requests a
	/// flyweight, the factory either returns an existing instance or creates a
	/// new one, if it doesn't exist yet.
	/// </summary>
	public class FlyweightFactory
	{
		private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

		public FlyweightFactory(params Car[] args)
		{
			foreach (var elem in args)
			{
				flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), GetKey(elem)));
			}
		}

		/// <summary>
		/// Returns a Flyweight's string hash for a given state.
		/// </summary>
		public string GetKey(Car key)
		{
			var elements = new List<string>
			{
				key.Model,
				key.Color,
				key.Company
			};

			if (key.Owner is not null && key.Number is not null)
			{
				elements.Add(key.Owner);
				elements.Add(key.Number);
			}
			elements.Sort();
			return string.Join("_", elements);
		}

		/// <summary>
		/// Returns an existing Flyweight with a given state or creates a new one.
		/// </summary>
		public Flyweight GetFlyweight(Car sharedState)
		{
			var key = GetKey(sharedState);

			if (flyweights.Where(t => t.Item2.Equals(key)).Count() == 0)
			{
				Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
				flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
			}
			else
			{
				Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
			}

			return flyweights.FirstOrDefault(t => t.Item2 == key).Item1;
		}

		public void ListFlyweights()
		{
			var count = flyweights.Count;
			Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
			foreach (var flyweight in flyweights)
			{
				Console.WriteLine(flyweight.Item2);
			}
		}
	}
}