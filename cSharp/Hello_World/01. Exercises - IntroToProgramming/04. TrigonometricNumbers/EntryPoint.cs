using System;

//4. Print sin(200), cos(100), tan(pi/4)

class CalculateTrigFunctions
{
    static void Main()
    {
        double theSinFunction = Math.Sin(200);              // using Sin, Cos and Tan methods to calculate their values at different angles
        double theCosFunction = Math.Cos(100);              //
        double theTanFunction = Math.Tan(Math.PI/4);        // using PI property to get the Pi number 3.1415......

        Console.WriteLine("Sin(200) = {0}\nCos(100) = {1}\nTan(Pi/4) = {2}", theSinFunction, theCosFunction, theTanFunction);

    }
}

