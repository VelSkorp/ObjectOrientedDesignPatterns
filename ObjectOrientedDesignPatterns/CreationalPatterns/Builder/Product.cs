using System.Text;

namespace CreationalPatterns.Builder
{
	/// <summary>
	/// It makes sense to use the Builder pattern only when your products are
	/// quite complex and require extensive configuration.
	/// Unlike in other creational patterns, different concrete builders can
	/// produce unrelated products. In other words, results of various builders
	/// may not always follow the same interface.
	/// </summary>
	public class Product
	{
		private List<object> _parts = new List<object>();

		public void Add(string part)
		{
			_parts.Add(part);
		}

		public string ListParts()
		{
			var str = new StringBuilder();

			for (var i = 0; i < _parts.Count; i++)
			{
				str.Append($"{_parts[i]}, ");
			}

			str.Remove(str.Length - 2, 2);

			return $"Product parts: {str}\n";
		}
	}
}