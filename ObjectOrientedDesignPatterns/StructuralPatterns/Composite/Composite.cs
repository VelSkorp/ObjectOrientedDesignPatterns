using System.Text;

namespace StructuralPatterns.Composite
{
	public class Composite : Component
	{
		protected List<Component> _children = new List<Component>();

		public override void Add(Component component)
		{
			_children.Add(component);
		}

		public override void Remove(Component component)
		{
			_children.Remove(component);
		}

		/// <summary>
		/// The Composite executes its primary logic in a particular way. It
		/// traverses recursively through all its children, collecting and
		/// summing their results. Since the composite's children pass these
		/// calls to their children and so forth, the whole object tree is
		/// traversed as a result.
		/// </summary>
		public override string Operation()
		{
			var result = new StringBuilder("Branch(");

			for (var i = 0; i < _children.Count; i++)
			{
				result.Append(_children[i].Operation());
				if (i != _children.Count - 1)
				{
					result.Append("+");
				}
			}
			result.Append(")");

			return result.ToString();
		}
	}
}