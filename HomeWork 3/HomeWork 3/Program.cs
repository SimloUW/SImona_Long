//HOMEWORK ASSIGNMENT #3
//Write a program that takes seconds and converts it into days, hours, minutes, 
//and seconds. (Hint: Have a variable that has the number seconds per day, 
//the number seconds per hour, and the number seconds per minute.)


using System;

class HomeWork_3
 {
    static void Main()
    {
        Console.Write(" Please type in seconds as an integer value that you would like converted into Days, Hours, Minutes X:");
        string str; 
        str = Console.ReadLine();
        int x = int.Parse(str);
        int iResult = (int)(x + 5);
        Console.WriteLine("The calculated value is { } seconds per Minute, {1} x seconds per Hour, {2}  seconds per Day"), iResult;
    Console.ReadLine();

    }   
}



