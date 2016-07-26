using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
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
