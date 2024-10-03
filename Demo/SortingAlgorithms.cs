using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate bool CompareDelegate(int x, int y);
    internal class SortingAlgorithms
    {
        public static void BubbleSort(int[] arr, CompareDelegate compareFunc  )
        {
            if (arr is null)
                throw new ArgumentNullException(nameof(arr));

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    //if (arr[j] > arr[j + 1])
                    //if (CompareFunctions.CompareGreater(arr[j], arr[j+1]))
                    if (compareFunc.Invoke(arr[j], arr[j + 1]))
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

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
