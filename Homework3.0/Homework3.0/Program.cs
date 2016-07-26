using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Homework3
{
    static void Main(string[] args)
    {
        
            Console.Write("Please Type an Integer value for Total Seconds to convert to Minutes, Hours and Days: ");
            string str; // declare a string variable
            str = Console.ReadLine(); //ReadOnlyCollection string input by user from console 
            int seconds = int.Parse(str); //convert string into integer
            int Minute = seconds / 60;
            int Hour = seconds / 3600;
            int Day = seconds / 86400;
            Console.WriteLine("The value for Total Seconds as Minutes, Days, hours  is {0} Per Minutes:{1} Hours:{2} day", Minute, Hour, Day);
            Console.ReadLine(); //Hold or pause of console to allow resutls to be viewed.
    }
    }

//}


