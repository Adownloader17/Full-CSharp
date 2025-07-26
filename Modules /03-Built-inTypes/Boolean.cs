using System; // Importing the System namespace to use Console and other core features

class BooleanDemo
{
    static void Main()
    {
        // Declaring a boolean variable indicating if the user is logged in
        bool isLoggedIn = true;

        // Declaring a boolean variable indicating if the user has made a payment
        bool hasPaid = false;

        // Displaying the value of isLoggedIn
        Console.WriteLine($"isLoggedIn: {isLoggedIn}");

        // Displaying the value of hasPaid
        Console.WriteLine($"hasPaid: {hasPaid}");

        // Using logical AND (&&) to check if user can access premium features
        // Both conditions must be true: logged in AND has paid
        Console.WriteLine($"Can access premium? {isLoggedIn && hasPaid}");

        // Using logical NOT (!) to check if the user is a guest (not logged in)
        Console.WriteLine($"Is guest? {!isLoggedIn}");
    }
}



```

### Explanation:

* `bool` is a built-in type representing **Boolean values** (`true` or `false`).
* `&&` is the **logical AND** operator.
* `!` is the **logical NOT** operator.
This example demonstrates how to work with Boolean logic to control access or state in programs.


