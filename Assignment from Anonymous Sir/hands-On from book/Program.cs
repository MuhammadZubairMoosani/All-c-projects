 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hands_On_from_book
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q-01
            /*
            Console.WriteLine("Please Enter the First Number!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Second Number!");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine(num1 + " and " + num2 + " Number Are Equal.");
            }
            else
            {
                Console.WriteLine(num1 + " and " + num2 + " Number Are not Equal.");
            }
            */


            // Q-02
            /*
            Console.WriteLine("Please Enter the Number!");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine(number + " Number is Positive!");
            }
            else
            {
                Console.WriteLine(number + " Number is Negative!");
            }
            */


            // Q-03
            /*
            Console.WriteLine("Please Enter your Age for verification!");
            int Age = Convert.ToInt32(Console.ReadLine());
            if (Age >= 18)
            {
                Console.WriteLine("Welcome for Vote Casting!");
            }
            else
            {
                Console.WriteLine("Your age is not for Vote casting!");
            }
            */

            // Q-04
            /*
            Console.WriteLine("Please Enter you'r Obtained Marks in Math Subject");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter you'r Obtained Marks in Phy Subject");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter you'r Obtained Marks in Chem Subject");
            int chem = Convert.ToInt32(Console.ReadLine());
            double totalObtainedMarks = math + phy + chem;
            if (totalObtainedMarks >= 180)
            {
                Console.WriteLine("You'r Selected for Professional Course");
            }
            else
            {
                Console.WriteLine("You'r Marks is not Approved for This Course");
            }
            */


            // Q-05
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            // Q-06
            /*
            Console.WriteLine("Enter the Number for Calculate in fectorial");
            int number = Convert.ToInt32(Console.ReadLine());
            int fect = 1;
            for (int i = 1; i <= number; i++)
            {
                fect = fect * i;
            }
            Console.WriteLine(fect);
            */
        }
    }
}
