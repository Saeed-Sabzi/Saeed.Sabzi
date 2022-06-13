using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_RecursiveFunction
{
    public class Class
    {
        
        public static string ReverseWord(string word)
        {
            if (word.Length == 0)
            {
                return word;
            }
            return ReverseWord(word.Substring(1)) + word[0];
        }


    }
}
