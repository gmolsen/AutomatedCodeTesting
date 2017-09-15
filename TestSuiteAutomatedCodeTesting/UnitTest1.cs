using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomatedCodeTesting;

namespace TestSuiteAutomatedCodeTesting {
	//for testing
	[TestClass]
	public class UnitTest1 {
		[TestMethod]
		public void TestMethod1() {
			Fraction frac = new Fraction();
			frac.Numerator = 100;
			frac.Denominator = 100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(1, answer);
		}

		[TestMethod]
		public void TestMethod2() {
			Fraction frac = new Fraction();
			frac.Numerator = 100;
			frac.Denominator = 75;
			var answer = frac.ToDecimal();
			Assert.AreEqual(1.3333333333333333333333333333333333333333333333333333333333333, answer);
		}

		[TestMethod]
		public void TestMethod3() {
			Fraction frac = new Fraction();
			frac.Numerator = 100;
			frac.Denominator = 50;
			var answer = frac.ToDecimal();
			Assert.AreEqual(2, answer);
		}

		[TestMethod]
		public void TestMethod4() {
			Fraction frac = new Fraction();
			frac.Numerator = 100;
			frac.Denominator = 25;
			var answer = frac.ToDecimal();
			Assert.AreEqual(4, answer);
		}

		[TestMethod]
		public void TestMethod5() {
			Fraction frac = new Fraction();
			frac.Numerator = 100;
			frac.Denominator = 1;
			var answer = frac.ToDecimal();
			Assert.AreEqual(100, answer);
		}

		public void TestMethod6() {
			Fraction frac = new Fraction();
			frac.Numerator = 75;
			frac.Denominator = 100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(0.75, answer);
		}

		[TestMethod]
		public void TestMethod7() {
			Fraction frac = new Fraction();
			frac.Numerator = 50;
			frac.Denominator = 100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(0.5, answer);
		}

		[TestMethod]
		public void TestMethod8() {
			Fraction frac = new Fraction();
			frac.Numerator = 25;
			frac.Denominator = 100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(0.25, answer);
		}

		[TestMethod]
		public void TestMethod9() {
			Fraction frac = new Fraction();
			frac.Numerator = 1;
			frac.Denominator = 100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(0.01, answer);
		}

		[TestMethod]
		public void TestMethod10() {
			Fraction frac = new Fraction();
			frac.Numerator = -100;
			frac.Denominator = 100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(-1, answer);
		}

		public void TestMethod11() {
			Fraction frac = new Fraction();
			frac.Numerator = -75;
			frac.Denominator = 100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(-0.75, answer);
		}

		[TestMethod]
		public void TestMethod12() {
			Fraction frac = new Fraction();
			frac.Numerator = -50;
			frac.Denominator = 100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(-0.5, answer);
		}

		[TestMethod]
		public void TestMethod13() {
			Fraction frac = new Fraction();
			frac.Numerator = -25;
			frac.Denominator = 100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(-0.25, answer);
		}

		[TestMethod]
		public void TestMethod14() {
			Fraction frac = new Fraction();
			frac.Numerator = -1;
			frac.Denominator = 100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(-0.01, answer);
		}

		[TestMethod]
		public void TestMethod15() {
			Fraction frac = new Fraction();
			frac.Numerator = 100;
			frac.Denominator = -100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(-1, answer);
		}

		public void TestMethod16() {
			Fraction frac = new Fraction();
			frac.Numerator = 75;
			frac.Denominator = -100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(-0.75, answer);
		}

		[TestMethod]
		public void TestMethod17() {
			Fraction frac = new Fraction();
			frac.Numerator = 50;
			frac.Denominator = -100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(-0.5, answer);
		}

		[TestMethod]
		public void TestMethod18() {
			Fraction frac = new Fraction();
			frac.Numerator = 25;
			frac.Denominator = -100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(-0.25, answer);
		}

		[TestMethod]
		public void TestMethod19() {
			Fraction frac = new Fraction();
			frac.Numerator = 1;
			frac.Denominator = -100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(-0.01, answer);
		}

		[TestMethod]
		public void TestMethod20() {
			Fraction frac = new Fraction();
			frac.Numerator = -100;
			frac.Denominator = -100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(1, answer);
		}

		public void TestMethod21() {
			Fraction frac = new Fraction();
			frac.Numerator = -75;
			frac.Denominator = -100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(0.75, answer);
		}

		[TestMethod]
		public void TestMethod22() {
			Fraction frac = new Fraction();
			frac.Numerator = -50;
			frac.Denominator = -100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(0.5, answer);
		}

		[TestMethod]
		public void TestMethod23() {
			Fraction frac = new Fraction();
			frac.Numerator = -25;
			frac.Denominator = -100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(0.25, answer);
		}

		[TestMethod]
		public void TestMethod24() {
			Fraction frac = new Fraction();
			frac.Numerator = -1;
			frac.Denominator = -100;
			var answer = frac.ToDecimal();
			Assert.AreEqual(0.01, answer);
		}


		[TestMethod]
		public void TestMethod25() {
			Squared squar = new Squared();
			var answer = squar.Calculate(233);
			Assert.AreEqual(54289, answer);
		}
		[TestMethod]
		public void TestMethod26() {
			Squared squar = new Squared();
			var answer = squar.Calculate(1);
			Assert.AreEqual(1, answer);
		}
		[TestMethod]
		public void TestMethod27() {
			Squared squar = new Squared();
			var answer = squar.Calculate(0);
			Assert.AreEqual(0, answer);
		}
		[TestMethod]
		public void TestMethod28() {
			Squared squar = new Squared();
			var answer = squar.Calculate(100);
			Assert.AreEqual(10000, answer);
		}
		[TestMethod]
		public void TestMethod29() {
			Squared squar = new Squared();
			var answer = squar.Calculate(3569);
			Assert.AreEqual(12737761, answer);
		}
		[TestMethod]
		public void TestMethod30() {
			Squared squar = new Squared();
			var answer = squar.Calculate(-82812);
			Assert.AreEqual(6857827344, answer);
		}
	}
}
