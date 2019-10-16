using System;
using System.Collections.Generic;
using Tama;

namespace dagens_demo
{
	class TestClass {
		public int numberToChange;
	}
	
    class PassByReferenceDemo
    {
		static int ChangeTheNumber(int numberToChange) {
			numberToChange = numberToChange - 10;
			return numberToChange;
		}
		static int ChangeTheNumberOfTestClass(TestClass testteste) {
			testteste.numberToChange = testteste.numberToChange - 10;
			return testteste.numberToChange;
		}
        public static void RunTest()
        {
			// int numberIWantToChange = 20;
			// numberIWantToChange = ChangeTheNumber(numberIWantToChange);
			// Console.WriteLine(numberIWantToChange);

			TestClass tester = new TestClass();
			tester.numberToChange = 20;
			ChangeTheNumberOfTestClass(tester);
			Console.WriteLine(tester.numberToChange);
        }
    }
}
