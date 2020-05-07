using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender.Lib
{
    public static class Calender
    {
        public static int GetMonthDayCount(string monthName)
        {
            return Convert.ToInt32(Enum.Parse(typeof(Months), monthName));
        }

        public static int GetMonthNumber(string name)
        {
            return Convert.ToInt32(Enum.Parse(typeof(MonthsDays), name));
        }

        public static void PrintMonth(int startDay, string monthName, int currentDay)
        {
            int counter = 1;
            int totalOfThatMonth = GetMonthDayCount(monthName);
            int leftDaysOfTheMonth = totalOfThatMonth - startDay;
            for (int i = 1; i <= totalOfThatMonth; i++)
            {
                if (i == currentDay)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write(i + " ");
                if (i == counter)
                {
                    Console.WriteLine();
                    counter += 10;
                }
            }
        }

        public static string GetMonthName(int monthNumber)
        {
            string monthName = string.Empty;
            switch (monthNumber)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                default:
                    monthName = "December";
                    break;
            }
            return monthName;
        }


        public static void PrintYearMonth(int currentDay)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(GetMonthName(i));
                PrintMonth(1, GetMonthName(i), currentDay);
                Console.WriteLine();
            }
        }

    }
}
