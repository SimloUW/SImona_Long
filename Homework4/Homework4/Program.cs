using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
//Create a Project in your github directory named Homework4
//I will check your github account for Homework4
//The factorial of an integer n, written n!, is the product of the consecutive integers 1 through n.
//For example, 5 factorial is calculated as: 5! = 5 x 4 x 3 x 2 x 1 = 120.
//Write a program that allows the user to enter the number of factorials to display. (10 points)

{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter a number to find the factorials: ");
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;
            int loopcount = 1;

            do
            {
                factorial *= loopcount;

                Console.WriteLine("\n{0}! = {1}", loopcount, factorial);

                loopcount++;
            } while (loopcount <= n);

            Console.ReadLine();
        }
    }

}






