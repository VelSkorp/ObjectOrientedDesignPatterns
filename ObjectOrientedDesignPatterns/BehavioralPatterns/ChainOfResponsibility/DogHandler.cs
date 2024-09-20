namespace BehavioralPatterns.ChainOfResponsibility
{
	public class DogHandler : AbstractHandler
	{
		public override object Handle(object request)
		{
			if ((request as string).Equals("MeatBall"))
			{
				return $"Dog: I'll eat the {request}.\n";
			}

			return base.Handle(request);
		}
	}
}