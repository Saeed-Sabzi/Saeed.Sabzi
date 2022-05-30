using System;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please enter a long number:");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Please enter a one-digit number:");
            char secondNumber = Convert.ToChar(Console.ReadLine());
            int i , counter = 0;
            for (i = 0; i < firstNumber.Length; i++)
            {
                if (firstNumber[i] == secondNumber)
                {
                    counter++;
                }
            }
            Console.WriteLine($"The number \'{secondNumber}\' is repeted \'{counter}\' times in long number.");
            Console.ReadKey();
        }
    }
}
