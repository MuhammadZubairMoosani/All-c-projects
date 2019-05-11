using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Please enter your First name!");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your Last name!");
            string lastName = Console.ReadLine();

            // Console.WriteLine("Your full name is " + firstName + " " + lastName);

            // Console.WriteLine("Your full name is {0} {1}", firstName, lastName);
            */

            /*
            int original = 10;
            int resutl;
            resutl = ++original;
            Console.WriteLine("After Prefix {0}, {1}", original, resutl);
            resutl = original++;
            Console.WriteLine("After Prefix {0}, {1}", original, resutl);
            */

            for (int i = 10; i <= 60; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);

                }
            }

        }
    }
}
