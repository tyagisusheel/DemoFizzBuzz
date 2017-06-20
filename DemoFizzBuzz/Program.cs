// ===============================
// AUTHOR           : Susheel Tyagi (tyagisusheel@gmail.com)
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
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*** FizzBuzz Started ****");

                while (true)
                {
                    int inputNumber;
                    string result = string.Empty;

                    Console.Write("\n Please enter any Number for find the multiple of '3' or '5' ");
                    Console.Write("\n otherwise Type 'quit' or 'Exit' for close  : ");

                    string inputString = Console.ReadLine();  // Read the command line input by the user.

                    if (inputString == "quit" || inputString == "exit")  // if user enter the "quit" or "exit" than abort from the application
                    {
                        break;
                    }
                    else
                    {
                        bool validNumber = int.TryParse(inputString, out inputNumber); // Parse the valid Numeric value.

                        if (validNumber == true) // If its a valid numeric value the procced for Find the valid number by FizzBuzz
                        {
                            // Call pass the input number to FindFizzBuzz() by FactoryFizzBuzz static class. This will return the string value.
                            result = FactoryFizzBuzz.FindFizzBuzz(inputNumber);

                            // if result is not null than print otherwise ignore. 
                            if (result.Length > 0)
                                Console.WriteLine("\n" + result);
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
