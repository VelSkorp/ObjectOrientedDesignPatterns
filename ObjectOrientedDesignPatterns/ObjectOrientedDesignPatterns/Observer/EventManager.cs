namespace BehavioralPatterns.Observer
{
	public class EventManager
	{
		private Dictionary<string, HashSet<IEventListener>> _listeners = new Dictionary<string, HashSet<IEventListener>>();

		public void Subscribe(string eventName, IEventListener listener)
		{
			if (_listeners[eventName] is not null)
			{
				_listeners[eventName].Add(listener);
				return;
			}

			var listeners = new HashSet<IEventListener>
				{
					listener
				};
			_listeners.Add(eventName, listeners);
		}

		public void Unsubscribe(string eventName, IEventListener listener)
		{
			_listeners[eventName].Remove(listener);
		}

		public void Notify(string eventName, string data)
		{
			foreach (var listener in _listeners[eventName])
			{
				listener.Update(data);
			}
		}
	}
}