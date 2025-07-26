// Import the System namespace to access built-in classes like Console
using System;

// Declare the Program class
class Program
{
    // Main method - the entry point of the application
    static void Main()
    {
        // Ask the user to enter their first name
        Console.WriteLine("Please Enter your First name :");

        // Read the first name input from the user and store it in the Firstname variable
        string Firstname = Console.ReadLine();

        // Ask the user to enter their last name
        Console.WriteLine("Please Enter your Last name :");

        // Read the last name input from the user and store it in the Lastname variable
        string Lastname = Console.ReadLine();

        // Display a greeting message with the user's full name
        // The placeholders {0} and {1} are replaced by Firstname and Lastname respectively
        Console.WriteLine("Hello {0} {1}", Firstname, Lastname);

        // Alternative ways to display greeting (commented out)
        // Console.WriteLine("Hello " + Firstname + " " + Lastname);
        // Console.WriteLine($"Hello {Firstname} {Lastname}"); // string interpolation
    }
}







