namespace CreationalPatterns.Prototype
{
	/// <summary>
	/// Base prototype.
	/// </summary>
	public abstract class Shape
	{
		public int X { get; set; }
		public int Y { get; set; }
		public string Color { get; set; }

		/// <summary>
		/// A regular constructor.
		/// </summary>
		public Shape() { }

		/// <summary>
		/// The prototype constructor. A fresh object is initialized
		/// with values from the existing object.
		/// </summary>
		public Shape(Shape shape)
			: base()
		{
			X = shape.X;
			Y = shape.Y;
			Color = shape.Color;
		}

		/// <summary>
		/// The clone operation returns one of the Shape subclasses.
		/// </summary>
		public abstract Shape Clone();

		public virtual void Print()
		{
			Console.WriteLine($"X: {X}, Y: {Y}, Color: {Color}");
		}
	}
}