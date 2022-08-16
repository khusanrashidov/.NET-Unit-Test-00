using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorClass;
namespace CalcUnitTest
{
	[TestClass]
	public class UnitTest
	{
		[TestMethod]
		public void CalcTestMethod()
		{
			var testInstance1 = new CalcClass();
			var testResult1 = testInstance1.AdditionMethod(8, 8);
			Assert.AreEqual(16, testResult1, "8+8 must be 16");
			var testInstance2 = new CalcClass();
			var testResult2 = testInstance2.SubtractionMethod(8, 8);
			Assert.AreEqual(0, testResult2, "8-8 must be 0");
			var testInstance3 = new CalcClass();
			var testResult3 = testInstance3.MultiplicationMethod(8, 8);
			Assert.AreEqual(64, testResult3, "8*8 must be 64");
			var testInstance4 = new CalcClass();
			var testResult4 = testInstance4.DivisionMethod(8, 8);
			Assert.AreEqual(1, testResult4, "8/8 must be 1");
		}
	}
}