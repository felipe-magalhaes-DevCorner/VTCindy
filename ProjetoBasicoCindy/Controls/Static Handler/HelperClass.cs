using System;
using System.Collections.Generic;

namespace ProjetoBasicoCindy
{
    public static class HelperClass
    {
        public static int YearShown = DateTime.Now.Year;

        public static System.Windows.Forms.Control FindTag(System.Windows.Forms.Control.ControlCollection controls, string tag)
        {

            for (int i = 0; i < controls.Count; i++)
            {
                var c = controls[i];
                if (c.Tag != null)
                {
                    //logic
                    if (c.Tag.ToString() == tag)
                    {
                        return c;
                    }
                }

                if (c.HasChildren)
                {
                    var chiildren = FindTag(c.Controls, tag); //Recursively check all children controls as well; ie groupboxes or 
                    if (chiildren == null)
                    {
                        continue;
                    }
                    return chiildren;

                }

            }
            return null;

        }
        public static void ChangeYear(int change)
        {
            YearShown += change;
        }



        public static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }

        public static IEnumerable<DateTime> EachMonth(DateTime from, DateTime thru)
        {
            for (var month = from.Date; month.Date <= thru.Date || month.Month == thru.Month; month = month.AddMonths(1))
                yield return month;
        }

        public static IEnumerable<DateTime> EachDayTo(this DateTime dateFrom, DateTime dateTo)
        {
            return EachDay(dateFrom, dateTo);
        }

        public static IEnumerable<DateTime> EachMonthTo(this DateTime dateFrom, DateTime dateTo)
        {
            return EachMonth(dateFrom, dateTo);
        }







    }
}
