using System.Linq;

namespace BehavioralPatterns.Iterator
{
	/// <summary>
	/// Concrete Iterators implement various traversal algorithms. These classes
	/// store the current traversal position at all times.
	/// </summary>
	public class AlphabeticalOrderIterator : Iterator
	{
		private WordsCollection _collection;

		// Stores the current traversal position. An iterator may have a lot of
		// other fields for storing iteration state, especially when it is
		// supposed to work with a particular kind of collection.
		private int _position = -1;
		private bool _reverse = false;

		public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
		{
			_collection = collection;
			_reverse = reverse;

			if (_reverse)
			{
				_position = _collection.GetItems().Count;
			}
		}

		public override object GetCurrent()
		{
			return _collection.GetItems().ElementAt(_position);
		}

		public override int Key()
		{
			return _position;
		}

		public override bool MoveNext()
		{
			var updatedPosition = _position + (_reverse ? -1 : 1);

			if (updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count)
			{
				_position = updatedPosition;
				return true;
			}
			return false;
		}

		public override void Reset()
		{
			_position = _reverse ? _collection.GetItems().Count - 1 : 0;
		}
	}
}