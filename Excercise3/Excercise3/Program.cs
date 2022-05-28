using System;

namespace Excercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //دریافت متن از کاربر
            string a = Console.ReadLine().ToLower();
            string b = Console.ReadLine().ToLower();
            //جدا کردن کلمات وارد شده از هم
            string[] S1 = a.Split(" ");
            string[] S2 = b.Split(" ");
            Console.WriteLine("=====================================================================");

            //بررسی تک تک کلمات با همدیگر
            foreach (var item in S1)
            {
                for (int i = 0; i < S2.Length; i++)
                {
                    if (item == S2[i])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\"{item}\" and \"{S2[i]}\" are same in both string 1 and string 2.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\"{item}\" and \"{S2[i]}\" aren't same in both string 1 and string 2!!! ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
