using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{

    public class Prog
    {
        static void Main(string[] args)
        {

        }

        public string FizzBuzz(int num)
        {
            if (num % 3 == 0)
            {
                return "Fizz";
            }
            return num.ToString();
        }
    }
}
