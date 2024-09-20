namespace BehavioralPatterns.ChainOfResponsibility
{
	public class SquirrelHandler : AbstractHandler
	{
		public override object Handle(object request)
		{
			if ((request as string).Equals("Nut"))
			{
				return $"Squirrel: I'll eat the {request}.\n";
			}

			return base.Handle(request);
		}
	}
}