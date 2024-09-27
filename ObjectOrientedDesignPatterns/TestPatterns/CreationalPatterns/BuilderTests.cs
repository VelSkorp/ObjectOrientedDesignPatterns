using CreationalPatterns.Builder;

namespace TestPatterns.CreationalPatterns
{
	[TestFixture]
	public class BuilderTests
	{
		[Test]
		public void BuilderTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				// The client code creates a builder object, passes it to the
				// director and then initiates the construction process. The end
				// result is retrieved from the builder object.
				var director = new Director();
				var builder = new ConcreteBuilder();
				director.Builder = builder;

				Console.WriteLine("Standard basic product:");
				director.BuildMinimalViableProduct();
				Console.WriteLine(builder.GetProduct().ListParts());

				Console.WriteLine("Standard full featured product:");
				director.BuildFullFeaturedProduct();
				Console.WriteLine(builder.GetProduct().ListParts());

				// Remember, the Builder pattern can be used without a Director
				// class.
				Console.WriteLine("Custom product:");
				builder.BuildPartA();
				builder.BuildPartC();
				Console.Write(builder.GetProduct().ListParts());

				Assert.That(stringWriter.ToString(), Is.EqualTo("Standard basic product:\r\nProduct parts: PartA1\n\r\nStandard full featured product:\r\nProduct parts: PartA1, PartB1, PartC1\n\r\nCustom product:\r\nProduct parts: PartA1, PartC1\n"));
			}
		}
	}
}