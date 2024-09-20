namespace BehavioralPatterns.ChainOfResponsibility
{
	public class MonkeyHandler : AbstractHandler
	{
		public override object Handle(object request)
		{
			if ((request as string).Equals("Banana"))
			{
				return $"Monkey: I'll eat the {request}.\n";
			}

			return base.Handle(request);
		}
	}
}