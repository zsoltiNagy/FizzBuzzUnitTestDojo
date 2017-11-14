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
            string result;
            if (number > 0 && number % 3 == 0)
            {
                result = "Fizz";
            } else if (number > 0 && number % 5 == 0){
                result = "Buzz";
            }
            else {
                result = number.ToString();
            }
            return result;
        }
    }
}
