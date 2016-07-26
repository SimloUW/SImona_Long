using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Homework3
    {
        static void Main(string[] args)
        //60 seconds in an minute
        //3,600 seconds in an hour
        //86,400 seconds in a day
        {
            Console.Write("Please Type an Integer value for Total Seconds to convert to Minutes, Hours and Days: ");

            string str; // declare a string variable

            str = Console.ReadLine(); //ReadOnlyCollection string input by user from console 

            int Totalseconds = int.Parse(str);
            int iResult = (int)(Totalseconds / 60);
            Console.WriteLine("The value for Total Seconds as Minutes, Hour and Days {0}" iResult;
            Console.ReadLine(); //Hold or pause of console to allow resutls to be viewed.

                                 

        }
    }

}






