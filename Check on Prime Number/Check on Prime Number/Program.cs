using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_on_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number");
            int num01 = Convert.ToInt32(Console.ReadLine());
            int num02 = Convert.ToInt32(Console.ReadLine());
            for (int i = num01; i < num02; i++)
            {
                if (num02 % i == 0)
                {
                    Console.WriteLine(num01 + " is not a Prime number");
                }
            }
        }
    }
}
