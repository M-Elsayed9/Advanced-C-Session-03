using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class StringFunctions
    {
        public static int GetCountOfUpperChars(string Name)
        {
            int Count = 0;
            if (Name is not null)
            {
                for (int i = 0; i < Name.Length; i++)
                    if (char.IsUpper(Name[i]))
                        Count++;
            }
            return Count;
        }

        public static int GetCountOfLowerChars(string Name)
        {
            int Count = 0;
            if (Name is not null)
            {
                for (int i = 0; i < Name.Length; i++)
                    if (char.IsLower(Name[i]))
                        Count++;
            }
            return Count;
        }
    }
}
