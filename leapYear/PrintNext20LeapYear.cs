using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LearpYearAssignment
{
    public class LeapYear
    {


        public static void Main(string[] args)
        {
            int year;

            Console.WriteLine("The Next 20 Leap Years Are");
            for (year = 2024; year <= 2100; year = year + 4)
            {
                Console.WriteLine(year);
            }

        }

    }
}