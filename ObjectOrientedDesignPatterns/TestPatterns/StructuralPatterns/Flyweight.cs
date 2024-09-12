using StructuralPatterns.Flyweight;

namespace TestPatterns
{
	[TestFixture]
	public class FlyweightTests
	{
		[Test]
		public void FlyweightTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				// The client code usually creates a bunch of pre-populated
				// flyweights in the initialization stage of the application.
				var factory = new FlyweightFactory(
					new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
					new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
					new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
					new Car { Company = "BMW", Model = "M5", Color = "red" },
					new Car { Company = "BMW", Model = "X6", Color = "white" }
				);
				factory.ListFlyweights();

				AddCarToPoliceDatabase(factory, new Car
				{
					Number = "CL234IR",
					Owner = "James Doe",
					Company = "BMW",
					Model = "M5",
					Color = "red"
				});

				AddCarToPoliceDatabase(factory, new Car
				{
					Number = "CL234IR",
					Owner = "James Doe",
					Company = "BMW",
					Model = "X1",
					Color = "red"
				});

				factory.ListFlyweights();

				Assert.That(stringWriter.ToString(), Is.EqualTo("\nFlyweightFactory: I have 5 flyweights:\r\nCamaro2018_Chevrolet_pink\r\nblack_C300_Mercedes Benz\r\nC500_Mercedes Benz_red\r\nBMW_M5_red\r\nBMW_white_X6\r\n\nClient: Adding a car to database.\r\nFlyweightFactory: Reusing existing flyweight.\r\nFlyweight: Displaying shared {\"Owner\":null,\"Number\":null,\"Company\":\"BMW\",\"Model\":\"M5\",\"Color\":\"red\"} and unique {\"Owner\":\"James Doe\",\"Number\":\"CL234IR\",\"Company\":\"BMW\",\"Model\":\"M5\",\"Color\":\"red\"} state.\r\n\nClient: Adding a car to database.\r\nFlyweightFactory: Can't find a flyweight, creating new one.\r\nFlyweight: Displaying shared {\"Owner\":null,\"Number\":null,\"Company\":\"BMW\",\"Model\":\"X1\",\"Color\":\"red\"} and unique {\"Owner\":\"James Doe\",\"Number\":\"CL234IR\",\"Company\":\"BMW\",\"Model\":\"X1\",\"Color\":\"red\"} state.\r\n\nFlyweightFactory: I have 6 flyweights:\r\nCamaro2018_Chevrolet_pink\r\nblack_C300_Mercedes Benz\r\nC500_Mercedes Benz_red\r\nBMW_M5_red\r\nBMW_white_X6\r\nBMW_red_X1\r\n"));
			}
		}

		public static void AddCarToPoliceDatabase(FlyweightFactory factory, Car car)
		{
			Console.WriteLine("\nClient: Adding a car to database.");

			var flyweight = factory.GetFlyweight(new Car
			{
				Color = car.Color,
				Model = car.Model,
				Company = car.Company
			});

			// The client code either stores or calculates extrinsic state and
			// passes it to the flyweight's methods.
			flyweight.Operation(car);
		}
	}
}