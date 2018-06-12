using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastSundayOfEachMonth
{
    public class LastSunday
    {
        public string[] FindLastSunday(int year)
        {
            string[] dates = new string[12];

            for (var month = 1; month <= 12; month++)
            {
                DateTime date = GetLastDayOftheMonth(year, month);
                while (DayIsNotSunday(date))
                {
                    date = date.AddDays(-1);
                }

                dates[month - 1] = date.ToString("yyyy-MM-dd");
            }
            return dates;  
        }

        private static DateTime GetLastDayOftheMonth(int year, int month)
        {
            return new DateTime(year, month, 1).AddMonths(1).AddDays(-1);
        }

        private static bool DayIsNotSunday(DateTime date)
        {
            return date.DayOfWeek != DayOfWeek.Sunday;
        }
    }
}
