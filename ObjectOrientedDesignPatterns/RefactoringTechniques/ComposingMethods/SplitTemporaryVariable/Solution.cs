namespace RefactoringTechniques.ComposingMethods.SplitTemporaryVariable
{
	public class Solution
	{
		private double _height = 10;
		private double _width = 10;

		public void Method()
		{
			var perimeter = 2 * (_height + _width);
			Console.WriteLine(perimeter);
			var area = _height * _width;
			Console.WriteLine(area);
		}
	}
}