using System;
using System.Text;
using System.Threading;

//Syncd with Git

class EntryPoint
{
    static void Main()
    {
        //Premitive data types - called premetive because all other datatypes are derived from these types

        int number = 3;

        int myNum = 5;
        Console.WriteLine(myNum);

        string myString = "Hello World!";
        Console.WriteLine(myString);

        char myChar = 'A';
        Console.WriteLine(myChar);

        bool myVals = true;
        Console.WriteLine(myVals);

        number = number + 1;
        //Thread.Sleep(5000);

        float myFloat = 3.12F;
        Console.WriteLine(myFloat);

        //int type holds 32bit number
        int someInteger = 5;
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);

        //uint cant have negative number - usigned int

        uint someUInteger = 1;
        Console.WriteLine(uint.MinValue);
        Console.WriteLine(uint.MaxValue);

        //byte type can hold 8 bit numbers

        byte someByte = 255;

        //use sbyte for negative number

        sbyte someNegativeNum = -1; //Signed Byte -128 to 127

        Console.WriteLine(sbyte.MinValue);
        Console.WriteLine(sbyte.MaxValue);
        Console.WriteLine(sbyte.MinValue);


        //long datatype holds 64 bit number

        Console.WriteLine(long.MaxValue);


        //ulong UnsignedLong no -ve value



        //double data type is float

        double myDoubleNumber = 2.5d;

        Console.WriteLine(double.MaxValue);
        Console.WriteLine(double.MinValue);

        //decimal 128bits, 28 to 29 digits of precision

        decimal myDecimalNum = 2.0m;

        Console.WriteLine(decimal.MaxValue);

        //Boolean Datatype

        bool isAlive = false;
        bool notAlive = true;

        bool isEqual = (4 == 4);
        Console.WriteLine(isEqual);


        char someCharacter = 'A';
        char someSpecialCharacter = '\u0026';

        Console.WriteLine(someCharacter);
        Console.WriteLine(someSpecialCharacter);

        Console.WriteLine("æ");

        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("æ");

        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        string myFirstString = "C# Course";
        string mySecondString = "For Begineers";

        Console.WriteLine(myFirstString);
        Console.WriteLine(mySecondString);

        //Write on single line
        //first way is concatination

        Console.WriteLine(myFirstString + " " + mySecondString);


        //second way is using placeholders

        Console.WriteLine("I am taking {0} and {1} I am happy", myFirstString, mySecondString);


        object someObject = "SmartPhone";
        Console.WriteLine(someObject);
        someObject = true;
        Console.WriteLine(someObject);
        someObject = 'A';
        Console.WriteLine(someObject);

        var someVar = "SmarPhone";
        Console.WriteLine(someVar);

        string iAmArray = "Array"; //strings are immutable

        Console.WriteLine(iAmArray[3]);

        string[] myStringArray = new string[3];
        myStringArray[0] = "MyFirstItem";
        myStringArray[1] = "MySecondItem";
        myStringArray[2] = "MyThirdItem";

        string[] mySecondStringArray = { "First", "Second", "Third", "Fourth", "fifth" };
        Console.WriteLine(mySecondStringArray[4]);
        Console.WriteLine(mySecondStringArray.Length);


        int[] myIntArray = new int[3];

    }
}
