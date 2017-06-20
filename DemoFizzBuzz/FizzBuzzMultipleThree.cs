using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFizzBuzz
{
    public class FizzBuzzMultipleThree : IFizzBuzz
    {

        /// <summary>
        /// If the entered number is a multiple of "3" there will be a response of Fizz
        /// Implementation of ParseNumber() method as per defined in "IFizzBuzz" for
        /// find the number is valid multiple of 3 
        /// </summary>
        /// <param name="number"> Valid numeric value for parset </param>
        /// <param name="result"> String input as a return type. Default is empty </param>
        /// 
        public string ParseNumber(int number, string result = "")
        {
            try
            {
                if (number % 3 == 0)
                {
                    result = result + " Fizz";
                }             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
            return result;
        }
    }
}
