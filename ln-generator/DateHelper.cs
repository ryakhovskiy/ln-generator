using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ln_generator
{

    public class DateHelper
    {
        private static readonly Dictionary<string, int> monthsNum = new Dictionary<string, int>() {
            { "January", 1 },
            { "February", 2 },
            { "March", 3 },
            { "April", 4 },
            { "May", 5 },
            { "June", 6 },
            { "July", 7 },
            { "August", 8 },
            { "September", 9 },
            { "October", 10 },
            { "November", 11 },
            { "December", 12 }
        };

        private static readonly Dictionary<int, string> monthNames = new Dictionary<int, string>() {
            { 1, "January" },
            { 2, "February" },
            { 3, "March" },
            { 4, "April" },
            { 5, "May" },
            { 6, "June" },
            { 7, "July" },
            { 8, "August" },
            { 9, "September" },
            { 10, "October" },
            { 11, "November" },
            { 12, "December" }
        };

        public static int GetMonthNumber(string month)
        {
            return monthsNum[month];
        }

        public static string GetMonthName(int number)
        {
            return monthNames[number];
        }

    }
}
