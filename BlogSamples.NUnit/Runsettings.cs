using NUnit.Framework;

namespace BlogSamples.NUnit
{
	[TestFixture]
	public class Runsettings
	{
		[Test]
		public void VerifyWebAppUrlParameter()
		{
			Assert.That(Configuration.WebAppUrl.Equals("http://localhost"));
		}
	}
}