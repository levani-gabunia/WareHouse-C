using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTest
{

	[TestClass]
	public class MathUnitTest : TestBase
	{
		private MathHelper _mathHelper;

		public MathUnitTest()
		{
			_mathHelper = new MathHelper();
		}

		[TestMethod]
		public void TestSum()
		{
			double result = _mathHelper.Sum(5, 2);
			double expectedResult = 7;

			//Assert.IsTrue(result == expectedResult, "Sum is not working!");
			Assert.AreEqual(expectedResult, result, "Sum is not working!");
		}

		[TestMethod]
		public void TestSub()
		{
			double result = _mathHelper.Sub(5, 2);
			double expectedResult = 3;

			Assert.AreEqual(expectedResult, result, "Sub is not working!");
		}
	}
}
