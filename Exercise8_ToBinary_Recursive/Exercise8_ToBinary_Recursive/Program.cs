using System;

namespace Exercise8_ToBinary_Recursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MethodClass.ToBinary(number));

            Console.ReadKey();
        }
    }
}
