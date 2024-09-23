namespace StructuralPatterns.Decorator
{
	/// <summary>
	/// Decorators can execute their behavior either before or after the call to
	/// a wrapped object.
	/// </summary>
	public class ConcreteDecoratorB : Decorator
	{
		public ConcreteDecoratorB(Component component)
			: base(component)
		{
		}

		public override string Operation()
		{
			return $"ConcreteDecoratorB({base.Operation()})";
		}
	}
}