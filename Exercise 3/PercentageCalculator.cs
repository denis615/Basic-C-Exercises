using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3
{
   public static class PercentageCalculator
    {
        public static int CalculPercentage(int PlayerWins,int TotalGames)
        {
            try
            {
                int percentage =(int)Math.Round( ((double)PlayerWins / TotalGames) * 100);
                return percentage;
            }
            catch(DivideByZeroException x)
            {
                return 0;
            }
            
        }
    }
}
