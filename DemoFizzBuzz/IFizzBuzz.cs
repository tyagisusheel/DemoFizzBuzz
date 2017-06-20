using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
