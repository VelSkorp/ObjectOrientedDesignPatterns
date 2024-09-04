namespace BehavioralPatterns.Observer
{
	public class Editor
	{
		public EventManager Events;
		private FileInfo _file;

		public Editor()
		{
			Events = new EventManager();
		}

		public FileStream OpenFile(string path)
		{
			_file = new FileInfo(path);
			Events.Notify("open", _file.Name);
			return _file.Open(FileMode.OpenOrCreate);
		}
	}
}