using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedCodeTesting;
using System.Diagnostics;

namespace TestAutomatedCodeTesting {
	class Program {
		static void Main(string[] args) {
			new Program().Run();
		}
		void Run() {
			Fraction fraction = new Fraction();
			fraction.Numerator = 100;
			fraction.Denominator = -100;
			var aDecimal = fraction.ToDecimal();
			var Passed = (aDecimal == -1);
			Debug.WriteLine($"The test passed : {Passed}");

			fraction.Numerator = 0;
			try {
				Passed = false;
				fraction.Denominator = 0;
			} catch (DivideByZeroException) {
				Passed = true;
			}
			Debug.WriteLine($"The test passed : {Passed}");
			
		}
	}
}
