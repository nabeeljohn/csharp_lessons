class EntryPoint
{
    static void Main()
    {
        //Convert other data types to String

        int someCrazyNumber = 4536334;
        System.Console.WriteLine(someCrazyNumber);
        System.Console.WriteLine(someCrazyNumber.GetType());

        string theNumberWasStringed = someCrazyNumber.ToString();
        System.Console.WriteLine(theNumberWasStringed);
        System.Console.WriteLine(theNumberWasStringed.GetType());

        //confirm another way 
        System.Console.WriteLine(theNumberWasStringed[4]);

        bool theTruth = true;
        System.Console.WriteLine(theTruth.ToString()[2]);

    }
}
