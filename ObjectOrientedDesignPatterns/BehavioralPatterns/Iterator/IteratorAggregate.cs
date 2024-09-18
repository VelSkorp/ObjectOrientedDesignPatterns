using System.Collections;

namespace BehavioralPatterns.Iterator
{
	public abstract class IteratorAggregate : IEnumerable
	{
		/// <summary>
		/// Returns an Iterator or another IteratorAggregate for the implementing object.
		/// </summary>
		public abstract IEnumerator GetEnumerator();
	}
}