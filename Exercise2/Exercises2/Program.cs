using System;

namespace Exercises2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------");
            int i, j = 0;
            for (i = 0; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    j += i ;
                }
            }
            Console.WriteLine(j);
        }
    }
}
