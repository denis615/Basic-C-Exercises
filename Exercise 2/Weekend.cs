using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_2
{
    public class Weekend
    {

        public static bool WeekendChecker(DateTime datetime)
        {

            if (datetime.DayOfWeek == DayOfWeek.Saturday || datetime.DayOfWeek == DayOfWeek.Sunday)
            {

                return true;


            }
            else
            {
                return false;
            }
        }
    }
}
