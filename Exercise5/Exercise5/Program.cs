using System;
using System.Collections.Generic;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            List<Person> persons = new List<Person>();

            Console.Write("How many person's income, you want to calculate? ");
            int personCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------");

            while (i < personCount)
            {
                Console.Write("Enter Fullname: ");
                string fullname = Console.ReadLine();
                Console.Write("How many Hours? ");
                int hours = Convert.ToInt32(Console.ReadLine());
                Console.Write("How much per hour? ");
                int perhour = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many days? ");
                int days = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------");
                Person obj = new Person(fullname, perhour, hours, days);
                persons.Add(obj);
                i++;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in persons)
            {
                Console.WriteLine($"Name: {item.Fullname}");
                Console.WriteLine($"Hourly Income: {item.PerHour}");
                Console.WriteLine($"Hours of per day: {item.Hours}");
                Console.WriteLine($"Salary: {item.Result()}");
                Console.WriteLine("===================");
            }
            Console.ReadKey();
        }
    }
}
