namespace RefactoringTechniques.ComposingMethods.SplitTemporaryVariable
{
	public class Problem
	{
		private double _height = 10;
		private double _width = 10;

		public void Method()
		{
			var temp = 2 * (_height + _width);
			Console.WriteLine(temp);
			temp = _height * _width;
			Console.WriteLine(temp);
		}
	}
}