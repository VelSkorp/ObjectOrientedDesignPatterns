namespace BehavioralPatterns.Visitor
{
	public class ConcreteComponentB : IComponent
	{
		/// <summary>
		/// Same here: VisitConcreteComponentB => ConcreteComponentB
		/// </summary>
		/// <param name="visitor"></param>
		public void Accept(IVisitor visitor)
		{
			visitor.VisitConcreteComponentB(this);
		}

		public string SpecialMethodOfConcreteComponentB()
		{
			return "B";
		}
	}
}