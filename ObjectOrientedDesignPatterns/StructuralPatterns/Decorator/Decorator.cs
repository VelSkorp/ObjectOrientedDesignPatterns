﻿namespace StructuralPatterns.Decorator
{
	/// <summary>
	/// The base Decorator class follows the same interface as the other
	/// components. The primary purpose of this class is to define the wrapping
	/// interface for all concrete decorators. The default implementation of the
	/// wrapping code might include a field for storing a wrapped component and
	/// the means to initialize it.
	/// </summary>
	public abstract class Decorator : Component
	{
		protected Component _component;

		public Decorator(Component component)
		{
			_component = component;
		}

		public void SetComponent(Component component)
		{
			_component = component;
		}

		/// <summary>
		/// The Decorator delegates all work to the wrapped component.
		/// </summary>
		public override string Operation()
		{
			if (_component is not null)
			{
				return _component.Operation();
			}

			return string.Empty;
		}
	}
}