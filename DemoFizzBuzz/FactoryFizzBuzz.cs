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

namespace DemoFizzBuzz
{

    /// <summary>
    /// This Factory design pattern,an abstraction that isolates the logic for determining which type of class to create
    /// Define an interface for creating an object, but let subclasses decide which class to instantiate.     
    /// Factory Method lets a class defer instantiation to subclasses. 
    /// </summary> 

    public static class FactoryFizzBuzz
    {

        /// <summary>
        /// FindFizzBuzz() function used to instantiate the cubclass of Interface IFizzBuzz
        /// find the number is valid multiple of  3 and 5
        /// </summary>
        /// <param name="number"> Valid numeric value for parset </param>
        /// <param name="result"> String input as a return type. Default is empty </param>
        /// 

        public static string FindFizzBuzz(int number)
        {
            string result = string.Empty;                           // Create and initialize  the result string to null

            try
            {
                IFizzBuzz multipleOfThree = new FizzBuzzMultipleThree(); // Instantiate for number multiple three
                IFizzBuzz multipleOfFive = new FizzBuzzMultipleFive();   // Instantiate for number multiple five

                result = multipleOfThree.ParseNumber(number, result);  // Call the pass the number and result string to multipleOfThree.ParseNumber. This will update the result with return the updated string 
                result = multipleOfFive.ParseNumber(number, result);   // Call the pass the number and result string to multipleOfFive.ParseNumber. This will update the result with return the updated string 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return result;

        }
    }
}
