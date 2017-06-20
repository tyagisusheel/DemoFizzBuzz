// ===============================
// AUTHOR           : Susheel Tyagi
// CREATE DATE      : 20/06/2017
// PURPOSE          : Demo Application for Test ability
// SPECIAL NOTES    : This is Console Based Application for "FizzBuzz" for valid number is a multiple of 3 or 5 with 
//                    Dot.Net best practices, Software Development best practices, Test Driven Development Best  
//                    Practices and Source Control Best Practices.
// ===============================
// Change History: 1.0
//
//==================================

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoFizzBuzz;

namespace UnitTestDemoFizzBuzz
{
    [TestClass]
    public class UnitTestDemoFizzBuzz
    {
        IFizzBuzz objMultipleThree = new FizzBuzzMultipleThree();
        IFizzBuzz objMultipleFive = new FizzBuzzMultipleFive();


        // Cretaed the test case for FizzBuzzMultipleThree. 
        // Test case Pass for any Valid input value (Multiple of 3), like 3,6,6,12,15 with update expected result 
        [TestMethod]
        public void TestMethod_MultipleOfThree()
        {
            string expected = " Fizz";
            string original = string.Empty;
            int value = 3;

            original = objMultipleThree.ParseNumber(value, original);

            Assert.AreEqual(expected, original);
        }

        // Cretaed the test case for FizzBuzzMultipleFive. 
        // Test case Pass for any Valid input value (Multiple of 5), like 5,10,15,30,35 with update expected result 
        [TestMethod]
        public void TestMethod_MultipleOfFive()
        {
            string expected = " Buzz";
            string original = string.Empty;
            int value = 10;

            original = objMultipleFive.ParseNumber(value, original);

            Assert.AreEqual(expected, original);
        }
    }
}
