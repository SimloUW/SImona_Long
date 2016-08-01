//HOMEWORK ASSIGNMENT #3
//Write a program that takes seconds and converts it into days, hours, minutes, 
//and seconds. (Hint: Have a variable that has the number seconds per day, 
//the number seconds per hour, and the number seconds per minute.)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //HOMEWORK ASSIGNMENT #3
            //Write a program that takes seconds and converts it into days, hours, minutes, 
            //and seconds. (Hint: Have a variable that has the number seconds per day, 
            //the number seconds per hour, and the number seconds per minute.)

            Console.Write(" Please type in seconds as x, an integer value that you would like converted into Days, Hours, Minutes :");

            string str;
            str = Console.ReadLine();
            int numOfSeconds = int.Parse(str);

            int days = (int)(numOfSeconds) / 86400;
            int hours = (int)(numOfSeconds / 3600);
            int minutes = (int)(numOfSeconds / 60) % 60;
            int seconds = (int)numOfSeconds % 60;
            string res = hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();

            Console.WriteLine("Seconds entered As Days: {0}, As Hours: {1}, As Minutes: {2}, As Seconds {3}", days, hours, minutes, seconds);
            Console.ReadLine(); //Hold or pause of console to allow resutls to be viewed.

        }
    }

}