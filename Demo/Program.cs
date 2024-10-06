namespace Demo

{
    // step 0
    // public delegate int StringFunDelegate(string str);
    // new class [Delegate]
    // any reference to a method that has the same signature as the delegate can be assigned to the delegate
    // function or pointer to a function
    // this function may be static or non static 
    // this function may be in the same class or in another class

    #region Built-in Delegate
    // 1. Predicate
    // can refer to a function that takes one parameter (of any datatype because it is generic) and returns a boolean

    // 2. Func
    // can refer to a function that takes 0-16 parameters and returns a value

    // 3. Action
    // can refer to a function that takes 0-16 parameters and returns void

    #endregion

    internal class Program
    {

        //public static List<T> GetElementsbasedOnPassedFunction<T>(List<T> list, Predicate<T> func)
        //{
        //    List<T> Result = new List<T>();

        //    foreach (T item in list)
        //    {
        //        if (func.Invoke(item))
        //        {
        //            Result.Add(item);
        //        }
        //    }

        //    return Result;
        //}
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


            //List<int> OddNumbers = GetElementsbasedOnPassedFunction(Numbers, ConditionalFunctions.IsOdd);

            //foreach (int item in OddNumbers)
            //{
            //    System.Console.WriteLine(item);
            //}

            //List<int> EvenNumbers = GetElementsbasedOnPassedFunction(Numbers, ConditionalFunctions.IsEven);

            //foreach (int item in EvenNumbers)
            //{
            //    System.Console.WriteLine(item);
            //}

            //Predicate<int> IsDivisibleBy7 = delegate (int num)
            //{
            //    return num % 7 == 0;
            //};
            //List<int> Divisble7 = GetElementsbasedOnPassedFunction(Numbers, ConditionalFunctions.IsDivisibleBy7);
            #endregion

            #region Delegate with Generics

            //List<string> list = new List<string>() { "Ahmed", "Omar", "Mai", "Kareem", "Manar" };

            //Predicate<string> CheckStringLength = delegate (string str)
            //{
            //    return str.Length > 4;
            //};

            //List<string> Result = GetElementsbasedOnPassedFunction(list, ConditionalFunctions.CheckStringLength);

            //foreach (string item in Result)
            //{
            //    System.Console.WriteLine(item);
            //}
            #endregion

            #region Built in Delegate

            #region Predicate

            //Predicate<int> predicate; // Ref => Method that takes one parameter and returns a boolean

            //predicate = TestingFunctions.Test01;

            //bool Result = predicate(5);

            //System.Console.WriteLine(Result);
            #endregion

            #region Func

            //Func<int, string> Func; // Ref => Method that takes one parameter and returns a value

            ////Func = delegate (int x)
            ////{
            ////    return x.ToString();
            ////};

            //Func = TestingFunctions.Test02;

            //string Result2 = Func(5);
            #endregion

            #region Action

            //Action action; // Ref => Method that takes 0 parameters and returns void

            //action = TestingFunctions.Test03;

            //action();
            //action = delegate ()
            //{
            //    System.Console.WriteLine("Hello");
            //};

            //Action<string> action; // Ref => Method that takes 1-16 parameters and returns void

            //action = TestingFunctions.Test04;

            //action("Ahmed");

            #endregion

            #endregion

            #region Annonymos Methods and Lambda Expressions

            #region Annonyomos Method

            #region Predicate
            //Predicate<int> predicate; // Ref => Method that takes one parameter and returns a boolean

            //predicate = delegate (int x) { return x > 0; }; // Annonymous Method

            //bool Result = predicate(5);

            //System.Console.WriteLine(Result);
            #endregion

            #region Func
            //Func<int, string> Func; // Ref => Method that takes one parameter and returns a value

            //Func = delegate (int x)
            //{
            //    return x.ToString();
            //}; 
            #endregion

            #region Action

            //Action action; // Ref => Method that takes 0 parameters and returns void

            //action = TestingFunctions.Test03;

            //action();

            //action = delegate ()
            //{
            //    System.Console.WriteLine("Hello");
            //};

            //Action<string> action1; // Ref => Method that takes 1-16 parameters and returns void

            //action1 = delegate (string Name)
            //{ Console.WriteLine($"Hello {Name}"); };

            //action1("Ahmed");
            #endregion

            #endregion

            #region Lambda Expression

            #region Predicate
            //Predicate<int> predicate; // Ref => Method that takes one parameter and returns a boolean

            //predicate = (x) => x > 0; // Lambda Expression

            //bool Result = predicate(5);

            //System.Console.WriteLine(Result);

            #endregion

            #region Func

            //Func<int, string> Func; // Ref => Method that takes one parameter and returns a value

            //Func = (x) => x.ToString(); // Lambda Expression

            //string Result2 = Func(5);

            #endregion

            #region Action

            //Action action; // Ref => Method that takes 0 parameters and returns void

            //action = () => Console.WriteLine("Hello"); // Lambda Expression

            //action();

            //Action<string> action1; // Ref => Method that takes 1-16 parameters and returns void

            //action1 = (Name) => Console.WriteLine($"Hello {Name}"); 

            //action1("Ahmed");
            #endregion

            #endregion

            #endregion

            #endregion
        }
    }

    class TestingFunctions
    {
        public static bool Test01(int x)
        {
            return x > 0;
        }

        public static string Test02(int x)
        {
            return x.ToString();
        }

        public static void Test03()
        {
            System.Console.WriteLine("Hello");
        }

        public static void Test04(string Name) {
            System.Console.WriteLine($"Hello {Name}");
        }
    }
}
