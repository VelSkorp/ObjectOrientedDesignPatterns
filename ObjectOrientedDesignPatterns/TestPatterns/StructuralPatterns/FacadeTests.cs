using StructuralPatterns.Facade;

namespace TestPatterns.StructuralPatterns
{
	[TestFixture]
	public class FacadeTests
	{
		[Test]
		public void FacadeTest()
		{
			// The client code may have some of the subsystem's objects already
			// created. In this case, it might be worthwhile to initialize the
			// Facade with these objects instead of letting the Facade create
			// new instances.
			var subsystem1 = new Subsystem1();
			var subsystem2 = new Subsystem2();
			var facade = new Facade(subsystem1, subsystem2);

			Assert.That(Client.ClientCode(facade), Is.EqualTo("Facade initializes subsystems:\nSubsystem1: Ready!\nSubsystem2: Get ready!\nFacade orders subsystems to perform the action:\nSubsystem1: Go!\nSubsystem2: Fire!\n"));
		}
	}
}