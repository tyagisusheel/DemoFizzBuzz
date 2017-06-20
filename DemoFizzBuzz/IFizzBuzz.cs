// ===============================
// AUTHOR           : Susheel Tyagi
// CREATE DATE      : 20/06/2017
// PURPOSE          : Demo Application for Test ability
// SPECIAL NOTES    : This is Console Based Application for FizzBuzz with Dot.Net best practices, Software Development 
//                    best practices, Test Driven Development Best Practices and Source Control Best Practices.
// ===============================
// Change History: 1.0
//
//==================================

namespace DemoFizzBuzz
{

    // Interface for parsing the number for FizzBuzz
    public interface IFizzBuzz
    {
        /// <summary>
        /// Defination ParseNumber method for parse the number for  FizzBuzz
        /// </summary>
        /// <param name="number"> Valid numeric value for parset </param>
        /// <param name="result"> String input as a return type. Default is empty </param>
        string ParseNumber(int number, string result = "");
    }
}
