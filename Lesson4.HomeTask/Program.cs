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
            DateTime nextBirtday;

            if (DateTime.Now.DayOfYear < bithrday.DayOfYear)
            {
                nextBirtday = new DateTime(DateTime.Now.Year, bithrday.Month, bithrday.Day);
            }
            else
            {
                nextBirtday = new DateTime(DateTime.Now.Year + 1, bithrday.Month, bithrday.Day);
            }

            TimeSpan daysLeft = nextBirtday.Subtract(DateTime.Now);

            Console.WriteLine((int)daysLeft.TotalDays + " days left to next birthday.");
            Console.ReadLine();
        }
    }
}
