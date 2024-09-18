using System.Collections;

namespace BehavioralPatterns.Iterator
{
	public abstract class Iterator : IEnumerator
	{
		public object Current => GetCurrent();

		/// <summary>
		/// Returns the key of the current element
		/// </summary>
		public abstract int Key();

		/// <summary>
		/// Returns the current element
		/// </summary>
		public abstract object GetCurrent();

		/// <summary>
		/// Move forward to next element
		/// </summary>
		public abstract bool MoveNext();

		/// <summary>
		/// Rewinds the Iterator to the first element
		/// </summary>
		public abstract void Reset();
	}
}