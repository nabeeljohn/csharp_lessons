using System;

class EntryPoint
{
    static void Main()
    {
        int number = 5;

        int numberToThePowerTwo = Convert.ToInt32(Math.Pow(number, 2));

        Console.WriteLine(Math.Cos(Math.PI));

        Console.WriteLine(numberToThePowerTwo);

        Console.WriteLine(Math.Sqrt(9));

        Console.WriteLine(Math.Round(3.176, 1));

        Console.WriteLine(Math.Floor(3.2));
        Console.WriteLine(Math.Ceiling(3.2));
    }
}