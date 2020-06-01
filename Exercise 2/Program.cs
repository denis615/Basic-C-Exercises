using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true) { 
            DateTime ourDate = DateCheck.isITDate();

           
            if (Holidays.CheckIfHoliday(ourDate) == true || Weekend.WeekendChecker(ourDate) == true)
            {
                Console.WriteLine("That Day Is a non Working Day");
                Console.ReadLine();
            };

            if (Holidays.CheckIfHoliday(ourDate) == false && Weekend.WeekendChecker(ourDate) == false)
            {
                Console.WriteLine("Unfortunately That Day is a Working Day");
            }
                while (true) { 
                Console.WriteLine("Press 1 to try again or Press 2 to Exit the App");
                string userChoosing = Console.ReadLine();

                    if (userChoosing == "1")
                    {
                        break;
                    }
                    if (userChoosing == "2")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Please either Choose 1 or 2");
                       
                        continue;
                    }
                    continue;
                }
            }
        }
    }
}
