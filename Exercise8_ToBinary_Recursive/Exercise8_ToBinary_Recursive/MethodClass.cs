using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_ToBinary_Recursive
{
    public class MethodClass
    {
        public static long ToBinary(int number)
        {
            if (number / 2 == 0)
            {
                return number % 2;
            }
            return number % 2 + 10 * (ToBinary(number / 2));
        }
    }
}
