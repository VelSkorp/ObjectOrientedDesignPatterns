namespace BehavioralPatterns.Command
{
	/// <summary>
	/// Some commands can implement simple operations on their own
	/// </summary>
	public class SimpleCommand : ICommand
	{
		private string _payload = string.Empty;

		public SimpleCommand(string payload)
		{
			_payload = payload;
		}

		public void Execute()
		{
			Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({_payload})");
		}
	}
}