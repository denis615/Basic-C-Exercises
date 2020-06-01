using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Exercise_2
{
    class Holidays
    {

        public static bool CheckIfHoliday(DateTime dateTime)
        {
            List<DateTime> HolidaysAndWeekends = new List<DateTime>();
            DateTime JanuaryHoliday = new DateTime(2020,01,01);
            DateTime Christmas = new DateTime(2020,01,07);
            DateTime AprilHoliDay = new DateTime(2020, 04, 20);
            DateTime LabourDay = new DateTime(2020 ,05,01);
            DateTime MayHoliday = new DateTime(2020 , 05 , 25);
            DateTime AugustHoliday = new DateTime(2020 , 08 ,03);
            DateTime IndependenceDay = new DateTime(2020,  09 , 08);
            DateTime OctoberHoliday = new DateTime(2020 , 10 , 12);
            DateTime SecondOctober = new DateTime(2020 , 10 , 23);
            DateTime DecemberHoliday = new DateTime(2020, 12 ,08);


            HolidaysAndWeekends.Add(JanuaryHoliday);
            HolidaysAndWeekends.Add(Christmas);
            HolidaysAndWeekends.Add(AprilHoliDay);
            HolidaysAndWeekends.Add(LabourDay);
            HolidaysAndWeekends.Add(MayHoliday);
            HolidaysAndWeekends.Add(AugustHoliday);
            HolidaysAndWeekends.Add(IndependenceDay);
            HolidaysAndWeekends.Add(OctoberHoliday);
            HolidaysAndWeekends.Add(SecondOctober);
            HolidaysAndWeekends.Add(DecemberHoliday);





            foreach (DateTime n in HolidaysAndWeekends)
            {
                if (n == dateTime)
                {
                   
                    return true;
                }


               


            }
            return false;
        }
    }
}
