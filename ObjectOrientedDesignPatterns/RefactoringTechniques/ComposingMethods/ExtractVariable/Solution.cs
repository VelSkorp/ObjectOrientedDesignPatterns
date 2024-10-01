namespace RefactoringTechniques.ComposingMethods.ExtractVariable
{
	public class Solution
	{
		private string _platform = string.Empty;
		private string _browser = string.Empty;
		private int _resize = 0;

		private bool isMacOs => _platform.ToUpper().IndexOf("MAC") > -1;
		private bool isIE => _browser.ToUpper().IndexOf("IE") > -1;
		private bool wasResized => _resize > 0;

		void RenderBanner()
		{

			if (isMacOs && isIE && WasInitialized() && wasResized)
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