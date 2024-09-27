namespace CreationalPatterns.Builder
{
	/// <summary>
	/// The Director is only responsible for executing the building steps in a
	/// particular sequence. It is helpful when producing products according to a
	/// specific order or configuration. Strictly speaking, the Director class is
	/// optional, since the client can control builders directly.
	/// </summary>
	public class Director
	{
		private IBuilder _builder;

		public IBuilder Builder
		{
			set => _builder = value;
		}

		/// <summary>
		/// The Director can construct several product variations using the same building steps.
		/// </summary>
		public void BuildMinimalViableProduct()
		{
			_builder.BuildPartA();
		}

		public void BuildFullFeaturedProduct()
		{
			_builder.BuildPartA();
			_builder.BuildPartB();
			_builder.BuildPartC();
		}
	}
}