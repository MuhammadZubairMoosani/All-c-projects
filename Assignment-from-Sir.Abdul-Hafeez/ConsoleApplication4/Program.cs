using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment-01 from Sir.Abdul Hafeez

            Console.Write("Please enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("{0} is Positive Number", num);
            }
            else
            {
                Console.WriteLine("{0} is Negative Number", num);
            }


            // Assignment-02 from Sir.Abdul Hafeez

            Console.WriteLine("Please Enter Your Name in Capital form");
            string strUpper = Console.ReadLine();
            string strLower = strUpper.ToLower();
            Console.WriteLine("Lower case of {0} is {1}", strUpper, strLower);
            //          

            // Assignment-03 from Sir.Abdul Hafeez
            // Circle

            Console.Write("Calculate Circle of Area!\nPlease Enter value of Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double afterCalculate = radius * radius * Math.PI;
            var circle = afterCalculate.ToString("N2");
            Console.WriteLine("Area of Circle is " + circle);


            // Triangle

            Console.Write("Calculate Triangle of Area!\nPlease Enter value of Height: ");
            double valueOfHeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter value of Base: ");
            double valueOfBase = Convert.ToDouble(Console.ReadLine());
            double triangle = valueOfBase * valueOfHeight / 2;
            Console.WriteLine("Area of Triangle is " + triangle);
        }
    }
}
