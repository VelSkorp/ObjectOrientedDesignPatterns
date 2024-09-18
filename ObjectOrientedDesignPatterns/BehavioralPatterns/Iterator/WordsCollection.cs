using System.Collections;

namespace BehavioralPatterns.Iterator
{
	/// <summary>
	/// Concrete Collections provide one or several methods for retrieving fresh
	/// iterator instances, compatible with the collection class.
	/// </summary>
	public class WordsCollection : IteratorAggregate
	{
		private List<string> _collection = new List<string>();
		private bool _direction = false;

		public void ReverseDirection()
		{
			_direction = !_direction;
		}

		public List<string> GetItems()
		{
			return _collection;
		}

		public void AddItem(string item)
		{
			_collection.Add(item);
		}

		public override IEnumerator GetEnumerator()
		{
			return new AlphabeticalOrderIterator(this, _direction);
		}
	}
}