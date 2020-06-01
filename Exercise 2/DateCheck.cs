using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_2
{
   public   class DateCheck
    {
        public static DateTime isITDate()
        {

            while (true)
            {
                Console.WriteLine("Please input a day in MM/DD/YYYY format?");
                string inputDate = Console.ReadLine();

                DateTime ourDate;

                bool isItOk = DateTime.TryParse(inputDate, out ourDate);


                if (isItOk == true)
                {
                    return ourDate;
                  
                    
                }
                else
                {
                    Console.WriteLine("Please follow the MM/DD/YYYY format");
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                    continue;
                }



            }

        }
    }
}
