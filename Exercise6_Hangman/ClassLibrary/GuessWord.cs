using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class GuessWord
    {
        public void guessWord(string result, char[] args)
        {
            string[] res = new string[result.Length];
            for (int j = 0; j < result.Length; j++)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (result[j] == args[i])
                    {
                        res[j] = args[i].ToString();
                        break;
                    }
                    else
                    {
                        res[j] = "-";
                    }
                }
            }
            Console.Write("Hint: ");
            foreach (var item in res)
            {
                Console.Write(item);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
