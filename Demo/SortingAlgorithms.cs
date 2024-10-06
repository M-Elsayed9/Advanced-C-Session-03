using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate TResult CompareDelegate<in T, out TResult>(T x, T y);
    public delegate bool CompareDelegate(int x, int y);
    internal class SortingAlgorithms<T>
    {
        public static void BubbleSort(T[] array, Func<T, T, bool> sort)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                    for (int j = 0; j < array.Length; j++)
                        if (sort.Invoke(array[j], array[j + 1]))
                        {
                            T temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
            }


            //public static void BubbleSort(int[] arr, CompareDelegate compareFunc  )
            //{
            //    if (arr is null)
            //        throw new ArgumentNullException(nameof(arr));

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        for (int j = 0; j < arr.Length - i - 1; j++)
            //        {
            //            //if (arr[j] > arr[j + 1])
            //            //if (CompareFunctions.CompareGreater(arr[j], arr[j+1]))
            //            if (compareFunc.Invoke(arr[j], arr[j + 1]))
            //            {
            //                int temp = arr[j];
            //                arr[j] = arr[j + 1];
            //                arr[j + 1] = temp;
            //            }
            //        }
            //    }
            //}

            //public static void BubbleSortDesc(int[] arr)
            //{
            //    if (arr is null)
            //        throw new ArgumentNullException(nameof(arr));

            //    for (int i = 0; i < arr.Length - 1; i++)
            //    {
            //        for (int j = 0; j < arr.Length - i - 1; j++)
            //        {
            //            if (arr[j] < arr[j + 1])
            //            {
            //                int temp = arr[j];
            //                arr[j] = arr[j + 1];
            //                arr[j + 1] = temp;
            //            }
            //        }
            //    }
            //}
        }


    }
}
