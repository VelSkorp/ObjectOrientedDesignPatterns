using System.Text;

namespace BehavioralPatterns.Memento
{
	/// <summary>
	/// The Originator holds some important state that may change over time. It
	/// also defines a method for saving the state inside a memento and another
	/// method for restoring the state from it.
	/// </summary>
	public class Originator
	{
		/// <summary>
		/// For the sake of simplicity, the originator's state is stored inside a
		/// single variable.
		/// </summary>
		private string _state;

		public Originator(string state)
		{
			_state = state;
			Console.WriteLine("Originator: My initial state is: " + state);
		}

		/// <summary>
		/// The Originator's business logic may affect its internal state.
		/// Therefore, the client should backup the state before launching
		/// methods of the business logic via the save() method.
		/// </summary>
		public void DoSomething()
		{
			Console.WriteLine("Originator: I'm doing something important.");
			_state = GenerateRandomString(30);
			Console.WriteLine($"Originator: and my state has changed to: {_state}");
		}

		/// <summary>
		/// Saves the current state inside a memento.
		/// </summary>
		public IMemento Save()
		{
			return new ConcreteMemento(_state);
		}

		/// <summary>
		/// Restores the Originator's state from a memento object.
		/// </summary>
		public void Restore(IMemento memento)
		{
			if (memento is not ConcreteMemento)
			{
				throw new Exception($"Unknown memento class {memento}");
			}

			_state = memento.GetState();
			Console.Write($"Originator: My state has changed to: {_state}");
		}

		private string GenerateRandomString(int length = 10)
		{
			var allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
			var result = new StringBuilder();

			while (length > 0)
			{
				result.Append(allowedSymbols[new Random().Next(0, allowedSymbols.Length)]);

				Thread.Sleep(12);

				length--;
			}

			return result.ToString();
		}
	}
}