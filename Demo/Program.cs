namespace Demo

{
    // step 0
    // public delegate int StringFunDelegate(string str);
    // new class [Delegate]
    // any reference to a method that has the same signature as the delegate can be assigned to the delegate
    // function or pointer to a function
    // this function may be static or non static 
    // this function may be in the same class or in another class

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate

            #region Ex 01 & 02

            // Delegate is a type that represents references to methods with a particular parameter list and return type.
            // Delegate is a C# Language feature
            // has 2 usages:
            // 1. Pointer to a function
            // 2. Event handling (event driving programming)

            //int X = 5;

            ////int Y = StringFunctions.GetCountOfUpperChars; // invalid

            //// step 1 Declare reference from delegate

            //StringFunDelegate fun;

            //// step 2 Assign the reference to a method

            ////fun = new StringFunDelegate(StringFunctions.GetCountOfUpperChars);
            //fun = StringFunctions.GetCountOfUpperChars;

            //// step 3 Call the method using the reference

            //int Y = fun.Invoke("Ahmed");

            //fun = StringFunctions.GetCountOfLowerChars;
            //// StringFunDelegate => GetCountOfLowerChars Only;

            //int Z = fun.Invoke("Ahmed");

            //int[] Numbers = { 5, 3, 7, 1, 9, 2, 8, 4, 6 };
            //SortingAlgorithms.BubbleSort(Numbers, CompareFunctions.CompareGreater);

            //foreach (int item in Numbers)
            //{
            //    System.Console.WriteLine(item);
            //}

            //SortingAlgorithms.BubbleSort(Numbers, CompareFunctions.CompareLess);

            //foreach (int item in Numbers)
            //{
            //    System.Console.WriteLine(item);
            //} 
            #endregion

            #region Ex 03

            //List<int> Numbers = Enumerable.Range(1, 100).ToList();

            //ConditionalFunctionDelegate IsOdd = ConditionalFunctions.IsOdd;

            //List<int> OddNumbers = Helper.GetNumbersByPassedFunc(Numbers, IsOdd);

            //foreach (int item in OddNumbers)
            //{
            //    System.Console.WriteLine(item);
            //}

            //ConditionalFunctionDelegate IsEven = ConditionalFunctions.IsEven;

            //List<int> EvenNumbers = Helper.GetNumbersByPassedFunc(Numbers, IsEven);

            //foreach (int item in EvenNumbers)
            //{
            //    System.Console.WriteLine(item);
            //}

            //ConditionalFunctionDelegate IsDivisibleBy7 = ConditionalFunctions.IsDivisibleBy7;

            //List<int> Divisble7 = Helper.GetNumbersByPassedFunc(Numbers, ConditionalFunctions.IsDivisibleBy7); 
            #endregion

            #region Delegate with Generics

            List<string> list = new List<string>() { "Ahmed", "Omar", "Mai", "Kareem", "Manar" };
            
            List<string> Result = Helper.GetElementsBasedOnPassedFunction(list, ConditionalFunctions.CheckStringLength);

            foreach (string item in Result)
            {
                System.Console.WriteLine(item);
            }
            #endregion

            #endregion
        }
    }
}
