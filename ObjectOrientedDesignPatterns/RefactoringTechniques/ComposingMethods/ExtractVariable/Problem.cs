namespace RefactoringTechniques.ComposingMethods.ExtractVariable
{
	public class Problem
	{
		public void RenderBanner()
		{
			var platform = string.Empty;
			var browser = string.Empty;
			var resize = 0;

			if ((platform.ToUpper().IndexOf("MAC") > -1) &&
				 (browser.ToUpper().IndexOf("IE") > -1) &&
				  WasInitialized() && resize > 0)
			{
				// do something
			}
		}

		public bool WasInitialized()
		{
			// Logic
			return true;
		}
	}
}