using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomatedCodeTesting {
	public class Fraction {
		public int Numerator { get; set; }

		public int _denominator;
		public int Denominator {
			get {
				return _denominator;
			}
			set {
				if(value == 0) {
					throw new DivideByZeroException("Why don't you just give up?");
				}
				_denominator = value;
			}
		}

		public double ToDecimal() {
			return (double)Numerator / (double)Denominator;
		}

		}
	}
