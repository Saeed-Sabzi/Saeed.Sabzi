using System;

namespace Exercise9_RecursiveMirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Input = Console.ReadLine().ToLower();
            Console.WriteLine(Madam(Input));
        }


        public static bool Madam(string input)
        {
            if (input.Length == 1)
            {
                return true;
            }
            else if (input.Length == 2 && input[0] == input[1])
            {
                return true;
            }
            else
            {
                if (input[0] == input[input.Length - 1])
                {
                    return Madam(input.Substring(1, input.Length - 2));
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
