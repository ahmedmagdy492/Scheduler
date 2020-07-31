using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scheduler.Models
{
    public static class Utility
    {
        public static string GetDayInString(int dayInDigits, int month, int year)
        {
            return Convert.ToDateTime($"{month}/{dayInDigits}/{year}").ToString("ddd");
        }
    }
}
