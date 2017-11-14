using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static void Main(string[] args)
        {
        }

        public string Generate(int number)
        {
            Boolean fizz = number > 0 && number % 3 == 0;
            Boolean buzz = number > 0 && number % 5 == 0;
            string result;
            if (fizz && buzz)
            {
                result = "FizzBuzz";
            } else if (fizz)
            {
                result = "Fizz";
            } else if (buzz)
            {
                result = "Buzz";
            } else
            {
                result = number.ToString();
            }
            return result;
        }
    }
}
