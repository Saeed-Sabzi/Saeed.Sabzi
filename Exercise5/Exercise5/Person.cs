using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Person
    {
        public string Fullname { get; set; }
        public int PerHour { get; set; }
        public int Hours { get; set; }
        public int DaysInMonth { get; set; }


        public Person(string fullname, int perHour, int hours, int days)
        {
            Fullname = fullname;
            PerHour = perHour;
            Hours = hours;
            DaysInMonth = days;
        }
        // Method
        public int Result()
        {
            int result = Hours * PerHour * DaysInMonth;
            return result;
        }
    }
}
