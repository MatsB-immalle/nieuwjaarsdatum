using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datum
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nieuwjaar = new DateTime(2017, 1, 1);

            while(nieuwjaar.Year <= 2027)
            {
                Console.Write(nieuwjaar.Year + ":");
                Console.WriteLine(nieuwjaar.DayOfWeek);
                
                nieuwjaar = nieuwjaar.AddYears(1);

            }

        }
    }
}
