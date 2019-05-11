using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTestSection_M
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q-01
            /*
            Console.WriteLine("hello world");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is the leap year");
            }
            else { Console.WriteLine(year + " is not leap year"); }
            */

            // Q-02
            Console.WriteLine("Enter the Value!");
            int userValue = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                int c = 1;
                int result = 1;
                result = result * c++;
                Console.WriteLine(result);
            }
        }
    }
}
