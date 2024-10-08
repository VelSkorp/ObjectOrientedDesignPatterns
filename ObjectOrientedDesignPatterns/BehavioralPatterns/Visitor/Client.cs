﻿namespace BehavioralPatterns.Visitor
{
	public class Client
	{
		/// <summary>
		/// The client code can run visitor operations over any set of elements
		/// without figuring out their concrete classes. The accept operation
		/// directs a call to the appropriate operation in the visitor object.
		/// </summary>
		public static void ClientCode(List<IComponent> components, IVisitor visitor)
		{
			foreach (var component in components)
			{
				component.Accept(visitor);
			}
		}
	}
}