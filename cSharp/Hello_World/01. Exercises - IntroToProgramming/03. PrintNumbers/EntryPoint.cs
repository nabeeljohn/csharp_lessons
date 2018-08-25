using System;

// 3. Print the numbers 0, 178, -21 and 12^20 on the console.

class PrintNumbers
{
    static void Main()
    {
        int firstNumber = 0;
        int secondNumber = 178;
        int thirdNumber = -21;

        double fourthNumber = Math.Pow(12, 20); // uses the Pow method to calculate the value of the number X raised to the power Y

        Console.WriteLine("First number: {0}\nSecond number: {1}\nThird number: {2}\nFourth number: {3}", firstNumber, secondNumber, thirdNumber, fourthNumber);
    }
}

