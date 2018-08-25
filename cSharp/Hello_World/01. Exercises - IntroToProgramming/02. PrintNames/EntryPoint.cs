using System;

// 2. Create a console application to print your name, email, age and gender.

class PrintMultipleLines
{
    static void Main()
    {
        string name = "Tod";                 
        string email = "tod@somemail.com";
        string gender = "Male";
        int age = 23;

        // First Way
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Age: " + age);

        // Second Way
        //Console.WriteLine("Name: " + name + "\nEmail: " + email + "\nGender: " + gender + "\nAge: " + age);

        // Third Way
        //Console.WriteLine("Name: {0}\nEmail: {1}\nGender: {2}\nAge: {3}", name, email, gender, age);
    }
}

