using System; // Required to use Console and other system-related functionality

class IntegralDemo
{
    static void Main()
    {
        // Signed 8-bit integer: range from -128 to 127
        sbyte a = -128;

        // Unsigned 8-bit integer: range from 0 to 255
        byte b = 255;

        // Signed 16-bit integer: range from -32,768 to 32,767
        short c = -32768;

        // Unsigned 16-bit integer: range from 0 to 65,535
        ushort d = 65535;

        // Signed 32-bit integer: typical range is -2,147,483,648 to 2,147,483,647
        int e = int.MaxValue; // Using predefined constant for max value

        // Unsigned 32-bit integer: range from 0 to 4,294,967,295
        uint f = uint.MaxValue; // Using predefined constant for max value

        // Signed 64-bit integer: typical range is -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        long g = long.MinValue; // Using predefined constant for min value

        // Unsigned 64-bit integer: range from 0 to 18,446,744,073,709,551,615
        ulong h = ulong.MaxValue; // Using predefined constant for max value

        // Character type: 16-bit Unicode character (UTF-16 code unit)
        char letter = 'A';

        // Display the values of all integral types
        Console.WriteLine($"sbyte: {a}");
        Console.WriteLine($"byte: {b}");
        Console.WriteLine($"short: {c}");
        Console.WriteLine($"ushort: {d}");
        Console.WriteLine($"int: {e} (Min: {int.MinValue}, Max: {int.MaxValue})");
        Console.WriteLine($"uint: {f}");
        Console.WriteLine($"long: {g} (Min: {long.MinValue}, Max: {long.MaxValue})");
        Console.WriteLine($"ulong: {h}");

        // Display the character and its corresponding Unicode code value
        Console.WriteLine($"char: '{letter}' -> {(int)letter} (UTF-16 code unit)");
    }
}



```

### Summary of Integral Types:

| Type     | Size   | Signed? | Range                           |
| -------- | ------ | ------- | ------------------------------- |
| `sbyte`  | 8-bit  | Yes     | -128 to 127                     |
| `byte`   | 8-bit  | No      | 0 to 255                        |
| `short`  | 16-bit | Yes     | -32,768 to 32,767               |
| `ushort` | 16-bit | No      | 0 to 65,535                     |
| `int`    | 32-bit | Yes     | -2,147,483,648 to 2,147,483,647 |
| `uint`   | 32-bit | No      | 0 to 4,294,967,295              |
| `long`   | 64-bit | Yes     | ±9.2×10¹⁸                       |
| `ulong`  | 64-bit | No      | 0 to 18,446,744,073,709,551,615 |
| `char`   | 16-bit | N/A     | Unicode character               |


