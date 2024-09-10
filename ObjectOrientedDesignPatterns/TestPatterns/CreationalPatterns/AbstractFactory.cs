using CreationalPatterns.AbstractFactory;

namespace TestPatterns
{
	[TestFixture]
	public class AbstractFactory
	{
		[Test]
		public void ConcreteFactory1Test()
		{
			var expetedResult = ("The result of the product B1.", "The result of the B1 collaborating with the (The result of the product A1.)");
			var actualResult = ClientMethod(new ConcreteFactory1());

			Assert.That(actualResult, Is.EqualTo(expetedResult));
		}

		[Test]
		public void ConcreteFactory2Test()
		{
			var expetedResult = ("The result of the product B2.", "The result of the B2 collaborating with the (The result of the product A2.)");
			var actualResult = ClientMethod(new ConcreteFactory2());

			Assert.That(actualResult, Is.EqualTo(expetedResult));
		}

		private (string productA, string productB) ClientMethod(IAbstractFactory factory)
		{
			var productA = factory.CreateProductA();
			var productB = factory.CreateProductB();

			return (productB.UsefulFunctionB(), productB.AnotherUsefulFunctionB(productA));
		}
	}
}