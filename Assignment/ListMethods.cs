using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ListMethods
    {
        static bool Exists<T>(List<T> list, Predicate<T> predicate)
        {
            foreach (T item in list)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }

        static T find<T>(List<T> list, Predicate<T> predicate)
        {
            foreach (T item in list)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default(T);
        }

        static List<T> FindAll<T>(List<T> list, Predicate<T> predicate)
        {
            List<T> result = new List<T>();
            foreach (T item in list)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        static int FindIndex<T>(List<T> list, Predicate<T> predicate)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (predicate(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        static T FindLast<T>(List<T> list, Predicate<T> predicate)
        {
            T result = default(T);
            foreach (T item in list)
            {
                if (predicate(item))
                {
                    result = item;
                }
            }
            return result;
        }

        static int FindLastIndex<T>(List<T> list, Predicate<T> predicate)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (predicate(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        static void ForEach<T>(List<T> list, Action<T> action)
        {
            foreach (T item in list)
            {
                action(item);
            }
        }

        static bool TrueForAll<T>(List<T> list, Predicate<T> predicate)
        {
            foreach (T item in list)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
