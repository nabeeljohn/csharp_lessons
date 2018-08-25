using System;


class EntryPoint
{
    static void Main()
    {
        //Convert other data types to String

        int someCrazyNumber = 4536334;
        Console.WriteLine(someCrazyNumber);
        Console.WriteLine(someCrazyNumber.GetType());

        string theNumberWasStringed = someCrazyNumber.ToString();
        Console.WriteLine(theNumberWasStringed);
        Console.WriteLine(theNumberWasStringed.GetType());

        //confirm another way 
        Console.WriteLine(theNumberWasStringed[4]);

        bool theTruth = true;
        Console.WriteLine(theTruth.ToString()[3]);

    }
}