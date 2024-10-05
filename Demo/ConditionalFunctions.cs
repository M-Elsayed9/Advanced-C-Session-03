using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class ConditionalFunctions
    {
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsDivisibleBy7(int number)
        {
            return number % 7 == 0;
        }

        public static bool IsDivisibleBy10(int number)
        {
            return number % 10 == 0;
        }
    }
}
