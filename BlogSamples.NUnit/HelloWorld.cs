using NUnit.Framework;
using System;

namespace BlogSamples.NUnit
{
	[TestFixture, Property("Fixture", "Hello")]
	public class HelloWorld
	{
		//[OneTimeTearDown]
		//public void OnetimeTeardown()
		//{
		//	TestContext.WriteLine($"Message: {TestContext.CurrentContext.Result.Message}");
		//	TestContext.WriteLine($"StackTrace: {TestContext.CurrentContext.Result.StackTrace}");

		//	TestContext.WriteLine($"InconclusiveCount: {TestContext.CurrentContext.Result.InconclusiveCount}");
		//	TestContext.WriteLine($"PassCount: {TestContext.CurrentContext.Result.PassCount}");
		//	TestContext.WriteLine($"SkipCount: {TestContext.CurrentContext.Result.SkipCount}");
		//	TestContext.WriteLine($"WarningCount: {TestContext.CurrentContext.Result.WarningCount}");
		//	TestContext.WriteLine($"FailCount: {TestContext.CurrentContext.Result.FailCount}");
		//}


		//[TearDown]
		//public void Teardown()
		//{
		//	TestContext.WriteLine($"Message: {TestContext.CurrentContext.Result.Message}");
		//	TestContext.WriteLine($"StackTrace: {TestContext.CurrentContext.Result.StackTrace}");
		//}

		//[TestCase(TestName = "Hello, get-testy.",
		//	Description = "Verifying that we can get a properly formed message back from HelloWorld",
		//	Author = "James Penning")]
		//public void Hello()
		//{
		//	TestContext.WriteLine($"Current TestDirectory: {TestContext.CurrentContext.TestDirectory}");
		//	TestContext.WriteLine($"Current WorkDirectory: {TestContext.CurrentContext.WorkDirectory}");

		//	TestContext.WriteLine($"Current WorkDirectory: {TestContext.CurrentContext.WorkerId}");

		//	string greeting = BlogSamples.HelloWorld.Hello("get-testy");
		//	Assert.That(greeting.Equals("Hello, get-testy.", StringComparison.Ordinal));
		//	var context = TestContext.CurrentContext.Test;
		//	foreach (var keys in TestContext.CurrentContext.Test.Properties["Author"])
		//	{
		//		Console.WriteLine(keys);
		//	}
		//}

		//[Category("Functional"), Category("Release"), Repeat(1), Culture("")]
		//public void CategoriesPropertiesTest()
		//{
		//	foreach (var category in TestContext.CurrentContext.Test.Properties["Category"])
		//	{
		//		Console.WriteLine(category);
		//	}
		//}

		//[TestCase(Ignore = "Don't run this test.")]
		//public void Skip()
		//{

		//}

		//[TestCase()]
		//public void Warn()
		//{
		//	//var list = new List<int>();
		//	//var item = list[2];

		//	Assert.Warn("AHHH");
		//	if (true)
		//	{
		//		throw new Exception("Eat this");
		//	}
		//}

		[Test]
		public void Random()
		{
			string randomGreeting = TestContext.CurrentContext.Random.GetString();
			TestContext.WriteLine($"RandomGreeting: {randomGreeting}");

			string greeting = BlogSamples.HelloWorld.Hello(randomGreeting);
			Assert.That(greeting.Equals($"Hello, {randomGreeting}.", StringComparison.Ordinal));
		}
	}
}
