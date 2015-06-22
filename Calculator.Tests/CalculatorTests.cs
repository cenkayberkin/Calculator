using NUnit.Framework;
using System;
using Calculator;

namespace Calculator.Tests
{
	[TestFixture ()]
	public class CalculatorTests
	{
		[Test ()]
		public void AddSimple ()
		{
			// Arrange
			MyCalculator calc = new MyCalculator ();

			// Act
			var actual = calc.Add(1,2);
			var expected = 3;

			// Assert
			Assert.AreEqual(expected,actual);
		}
	}
}

