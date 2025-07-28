using System;

class StringDemo
{
    static void Main()
    {
        // Declaring string variables using double quotes
        string name = "Ani";
        string city = "Mumbai";

        // Concatenation: Joining strings using + operator
        string message = "Hello, " + name + "! Welcome to " + city + ".";

        // String interpolation (recommended): Cleaner way to format strings
        string interpolated = $"Hi {name}, you are from {city}.";

        // Multiline string using verbatim string literal (@)
        string multiline = @"This is a
multiline string,
preserved as written.";

        // Accessing characters using index (0-based)
        char firstChar = name[0]; // 'A'

        // String length property
        int length = name.Length;

        // Displaying all outputs
        Console.WriteLine($"Concatenated: {message}");
        Console.WriteLine($"Interpolated: {interpolated}");
        Console.WriteLine("Multiline:\n" + multiline);
        Console.WriteLine($"First character of name: {firstChar}");
        Console.WriteLine($"Length of name: {length}");
    }
}






---

### 📘 `string` Summary in C#:

| Feature           | Description                                        |
| ----------------- | -------------------------------------------------- |
| Type              | `string` (alias for `System.String`)               |
| Immutable?        | ✅ Yes – cannot be changed after creation           |
| Supports Indexing | ✅ Yes – like `name[0]`                             |
| Length Property   | ✅ Yes – `name.Length` returns number of characters |
| Concatenation     | ✅ Use `+` or `string.Concat()`                     |
| Interpolation     | ✅ Use `$"Hello {name}"`                            |
| Multiline         | ✅ Use `@` for verbatim string literals             |

---

### 💡 Tips:

* Use **interpolation** (`$"..."`) instead of concatenation for better readability.
* Use `string.IsNullOrEmpty(str)` to safely check if a string is empty or null.
* For string formatting, prefer `string.Format(...)` or `$"..."`.


