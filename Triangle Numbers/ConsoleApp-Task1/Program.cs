﻿using System;

namespace ConsoleApp_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("How many line do you want to set numbers?");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("-----------------------------------------");
            //Console.ForegroundColor = ConsoleColor.Green;
            //int i = 1;
            //int j = 1;
            //while (i <= num)
            //{
            //    for (int Null = 0; Null < num - i; Null++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    for (int k = j - 2; k >= 1; k--)
            //    {
            //        Console.Write(k);
            //    }
            //    for (int Null = 0; Null < num - i; Null++)
            //    {
            //        Console.Write(" ");
            //    }
            //    i++;
            //    Console.WriteLine();
            //}
            int rows = 5;
            for (int i = 0; i <= rows; i++)
            {

                for (int j = 0; j < rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int h = 1; h <= i; h++)
                {
                    Console.Write($"{h}");
                }

                for (int k = i - 1; k >= 1; k--)
                {
                    Console.Write($"{k}");
                }

                Console.WriteLine("");

            }
            Console.ReadKey();
        }
    }
}
