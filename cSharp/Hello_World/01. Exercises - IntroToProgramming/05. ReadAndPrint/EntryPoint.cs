using System;

// 5. Write a program to read your first and last names and print them on the console, separated by space.

class ReadAndPrint
{
    static void Main()
    {
        string firstName = Console.ReadLine();    // read variables from the console
        string secondName = Console.ReadLine();   //

        Console.WriteLine("My names are {0} {1}", firstName, secondName);
    }
}
