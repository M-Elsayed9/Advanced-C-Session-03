using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate bool ConditionalFunctionDelegate(int number);

    internal static class Helper
    {
        public static List<int> GetNumbersByPassedFunc (List<int> numbers, ConditionalFunctionDelegate Condition)
        {
            List<int> oddNumbers = new List<int>();
            

            if (numbers == null || Condition is null)
            {
                return oddNumbers;
            }
            
            foreach (int number in numbers)
            {
                //if(Condition.Invoke(number))
                if (Condition(number))
                {
                    oddNumbers.Add(number);
                }
            }
            
            return oddNumbers;
        }

        //public static List<int> GetEvenNumbers(List<int> numbers)
        //{
        //    List<int> evenNumbers = new List<int>();

        //    if (numbers == null)
        //    {
        //        return evenNumbers;
        //    }

        //    foreach (int number in numbers)
        //    {
        //        if (number % 2 == 0)
        //        {
        //            evenNumbers.Add(number);
        //        }
        //    }

        //    return evenNumbers;
        //}

        //public static List<int> GetNumbersDivisbleBy7(List<int> numbers)
        //{
        //    List<int> Result = new List<int>();
        //    if (numbers is null)
        //        return Result;

        //    foreach (int number in numbers)
        //    {
        //        if (number % 7 == 0)
        //            Result.Add(number);
        //    }

        //        return Result;
        //}
    }
}
