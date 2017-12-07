using NUnit.Framework;

namespace BlogSamples.NUnit
{
	public class Configuration
	{
		private static string _webAppUrl;
		public static string WebAppUrl
		{
			get
			{
				if (_webAppUrl == null && TestContext.Parameters.Exists("WebAppUrl"))
				{
					_webAppUrl = TestContext.Parameters["WebAppUrl"];
				}
				else
				{
					throw new System.ArgumentException($"The parameter 'WebAppUrl' was not found, please provide a value for this parameter.");
				}
				return _webAppUrl;
			}
		}
	}
}
