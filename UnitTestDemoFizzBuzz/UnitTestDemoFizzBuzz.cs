// ===============================
// AUTHOR           : Susheel Tyagi (tyagisusheel@gmail.com)
// CREATE DATE      : 20/06/2017
// PURPOSE          : Demo Application for Test ability
// SPECIAL NOTES    : This is Test Project for testing the "FizzBuzz" for valid number is a multiple of 3 or 5 with 
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

         
        // Test case "FizzBuzzMultipleThree" Pass for any Valid input value (Multiple of 3), like 3,6,12,15 with update expected result 
        [TestMethod]
        public void TestMethod_MultipleOfThree()
        {
            string expected = " Fizz";
            string original = string.Empty;
            int value = 3;                     // Valid input like   3,6,12,15, 30, 35 etc

            original = objMultipleThree.ParseNumber(value, original);

            Assert.AreEqual(expected, original);
        }
         
        // Test case "FizzBuzzMultipleFive" Pass for any Valid input value (Multiple of 5), like 5,10,15,30,35 with update expected result 
        [TestMethod]
        public void TestMethod_MultipleOfFive()
        {
            string expected = " Buzz";
            string original = string.Empty;
            int value = 10;                   // Valid input like  5,10,15,30,35

            original = objMultipleFive.ParseNumber(value, original);

            Assert.AreEqual(expected, original);
        }

        // Test case "TestMethodMultipleThreeFive" Pass for any Valid input value (Multiple of 3 and 5), like 15,30 with update expected result 
        [TestMethod]
        public void TestMethodMultipleThreeFive()
        {
            string expected = " Fizz Buzz";
            string original = string.Empty;
            int value = 15;                      // Valid input like  15, 30

            original = objMultipleThree.ParseNumber(value, original);
            original = objMultipleFive.ParseNumber(value, original);

            Assert.AreEqual(expected, original);
        }
    }
}
