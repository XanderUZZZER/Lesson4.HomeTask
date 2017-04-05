using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.HomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Days to birthday");
            Console.Write("Input your birthday date in format dd/mm/yyyy: ");

            DateTime bithrday = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            DateTime nextBirtday;

            if (today.DayOfYear < bithrday.DayOfYear)
            {
                nextBirtday = new DateTime(today.Year, bithrday.Month, bithrday.Day);
            }
            else
            {
                nextBirtday = new DateTime(today.Year + 1, bithrday.Month, bithrday.Day);
            }

            TimeSpan daysLeft = nextBirtday.Subtract(today);

            Console.WriteLine((int)daysLeft.TotalDays + " days left to next birthday.");
            Console.ReadLine();
        }
    }
}
