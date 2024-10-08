﻿namespace BehavioralPatterns.Memento
{
	/// <summary>
	/// The Memento interface provides a way to retrieve the memento's metadata,
	/// such as creation date or name. However, it doesn't expose the
	/// Originator's state.
	/// </summary>
	public interface IMemento
	{
		string GetName();
		string GetState();
		DateTime GetDate();
	}
}