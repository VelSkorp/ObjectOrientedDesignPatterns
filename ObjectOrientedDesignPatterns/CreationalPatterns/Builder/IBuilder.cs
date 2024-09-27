namespace CreationalPatterns.Builder
{
	/// <summary>
	/// The Builder interface specifies methods for creating the different parts of the Product objects.
	/// </summary>
	public interface IBuilder
	{
		void BuildPartA();
		void BuildPartB();
		void BuildPartC();
	}
}