namespace BehavioralPatterns.Memento
{
	/// <summary>
	/// The Concrete Memento contains the infrastructure for storing the
	/// Originator's state.
	/// </summary>
	public class ConcreteMemento : IMemento
	{
		private string _state;
		private DateTime _date;

		public ConcreteMemento(string state)
		{
			_state = state;
			_date = DateTime.Now;
		}

		/// <summary>
		/// The Originator uses this method when restoring its state.
		/// </summary>
		public string GetState()
		{
			return _state;
		}

		/// <summary>
		/// The rest of the methods are used by the Caretaker to display metadata.
		/// </summary>
		public string GetName()
		{
			return $"{_date} / ({_state.Substring(0, 9)})...";
		}

		public DateTime GetDate()
		{
			return _date;
		}
	}
}