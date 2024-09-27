using CreationalPatterns.Prototype;

namespace TestPatterns.CreationalPatterns
{
	[TestFixture]
	public class PrototypeTests
	{
		[Test]
		public void PersonPrototypeTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				var p1 = new Person
				{
					Age = 42,
					BirthDate = Convert.ToDateTime("1977-01-01"),
					Name = "Jack Daniels",
					IdInfo = new IdInfo(666)
				};

				// Perform a shallow copy of p1 and assign it to p2.
				var p2 = p1.ShallowCopy();
				// Make a deep copy of p1 and assign it to p3.
				var p3 = p1.DeepCopy();

				// Display values of p1, p2 and p3.
				Console.WriteLine("Original values of p1, p2, p3:");
				Console.WriteLine("   p1 instance values:");
				DisplayPersonValues(p1);
				Console.WriteLine("   p2 instance values:");
				DisplayPersonValues(p2);
				Console.WriteLine("   p3 instance values:");
				DisplayPersonValues(p3);

				// Change the value of p1 properties and display the values of p1,
				// p2 and p3.
				p1.Age = 32;
				p1.BirthDate = Convert.ToDateTime("1900-01-01");
				p1.Name = "Frank";
				p1.IdInfo.IdNumber = 7878;
				Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
				Console.WriteLine("   p1 instance values:");
				DisplayPersonValues(p1);
				Console.WriteLine("   p2 instance values (reference values have changed):");
				DisplayPersonValues(p2);
				Console.WriteLine("   p3 instance values (everything was kept the same):");
				DisplayPersonValues(p3);

				Assert.That(stringWriter.ToString(), Is.EqualTo("Original values of p1, p2, p3:\r\n   p1 instance values:\r\n      Name: Jack Daniels, Age: 42, BirthDate: 01/01/77\r\n      ID#: 666\r\n   p2 instance values:\r\n      Name: Jack Daniels, Age: 42, BirthDate: 01/01/77\r\n      ID#: 666\r\n   p3 instance values:\r\n      Name: Jack Daniels, Age: 42, BirthDate: 01/01/77\r\n      ID#: 666\r\n\nValues of p1, p2 and p3 after changes to p1:\r\n   p1 instance values:\r\n      Name: Frank, Age: 32, BirthDate: 01/01/00\r\n      ID#: 7878\r\n   p2 instance values (reference values have changed):\r\n      Name: Jack Daniels, Age: 42, BirthDate: 01/01/77\r\n      ID#: 7878\r\n   p3 instance values (everything was kept the same):\r\n      Name: Jack Daniels, Age: 42, BirthDate: 01/01/77\r\n      ID#: 666\r\n"));
			}
		}

		[Test]
		public void ShapePrototypeTest()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);

				var shapes = new List<Shape>();
				var circle = new Circle
				{
					X = 10,
					Y = 10,
					Color = "Green",
					Radius = 20
				};
				shapes.Add(circle);

				var anotherCircle = (Circle)circle.Clone();
				anotherCircle.X = 0;
				anotherCircle.Y = 100;
				anotherCircle.Color = "Red";
				anotherCircle.Radius = 50;
				shapes.Add(anotherCircle);

				var rectangle = new Rectangle()
				{
					X = 5,
					Y = 5,
					Color = "Yellow",
					Width = 10,
					Height = 20
				};
				shapes.Add(rectangle);

				foreach (var shape in shapes)
				{
					shape.Print();
				}

				Assert.That(stringWriter.ToString(), Is.EqualTo("X: 10, Y: 10, Color: Green\r\nRadius: 20\r\nX: 0, Y: 100, Color: Red\r\nRadius: 50\r\nX: 5, Y: 5, Color: Yellow\r\nWidth: 10, Height: 20\r\n"));
			}
		}

		public static void DisplayPersonValues(Person p)
		{
			Console.WriteLine($"      Name: {p.Name:s}, Age: {p.Age:d}, BirthDate: {p.BirthDate:MM/dd/yy}");
			Console.WriteLine($"      ID#: {p.IdInfo.IdNumber:d}");
		}
	}
}