namespace CreationalPatterns.Prototype
{
	public class Circle : Shape
	{
		public int Radius { get; set; }

		public Circle() { }

		public Circle(Circle circle)
			: base(circle)
		{
			Radius = circle.Radius;
		}

		public override Shape Clone()
		{
			return new Circle(this);
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"Radius: {Radius}");
		}
	}
}