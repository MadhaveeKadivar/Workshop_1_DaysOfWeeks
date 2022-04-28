using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopQuestion
{
    internal class DaysOfWeeks
    {
        /// <summary>
        /// Displaying week days based on Given year month name and date
        /// </summary>
        public static void WeekDays()
        {
            int monthNo = 0, year, d;
            string month;
            Console.WriteLine("Enter Year : ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month name : ");
            month = Console.ReadLine();
            Console.WriteLine("Enter Date : ");
            d = Convert.ToInt32(Console.ReadLine());
            monthNo= DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month; // Converting the  Month name to Month number
           
            int y, x, m, day;
            // Applyting Formula to find day of week from Given month ,date and year
            y = year - (14 - monthNo)/ 12;
            x = y + y/4 - y/100 + y/400;
            m = monthNo + 12 * ((14 - monthNo) / 12) - 2;
            day = (d + x + (31*m)/12)%7; // Day is in form of digit 

            Console.WriteLine("\nDay number is : " + day);

            switch (day) // To find Day name from day number
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    break;
            }
        }
    }
}
