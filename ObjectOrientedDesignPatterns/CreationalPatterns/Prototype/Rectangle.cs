namespace CreationalPatterns.Prototype
{
	/// <summary>
	/// Concrete prototype. The cloning method creates a new object
	/// in one go by calling the constructor of the current class and
	/// passing the current object as the constructor's argument.
	/// Performing all the actual copying in the constructor helps to
	/// keep the result consistent: the constructor will not return a
	/// result until the new object is fully built; thus, no object
	/// can have a reference to a partially-built clone.
	/// </summary>
	public class Rectangle : Shape
	{
		public int Width { get; set; }
		public int Height { get; set; }

		public Rectangle() { }

		public Rectangle(Rectangle rectangle)
			: base(rectangle)
		{
			Width = rectangle.Width;
			Height = rectangle.Height;
		}

		public override Shape Clone()
		{
			return new Rectangle(this);
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"Width: {Width}, Height: {Height}");
		}
	}
}