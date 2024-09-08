using System.Text;

namespace BehavioralPatterns.Observer
{
	public class LoggingListener : IEventListener
	{
		private readonly FileInfo _log;
		private readonly string _message;

		public LoggingListener(string logFileName, string message)
		{
			_log = new FileInfo(logFileName);
			_message = message;
		}

		public void Update(string filename)
		{
			var stream = _log.OpenWrite();
			stream.Write(Encoding.ASCII.GetBytes(_message));
			stream.Close();
		}
	}
}