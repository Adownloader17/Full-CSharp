using System;

class FloatingPointDemo
{
    static void Main()
    {
        // 32-bit floating-point number (single precision)
        float floatNumber = 3.14159f; // 'f' suffix is required for float literals

        // 64-bit floating-point number (double precision)
        double doubleNumber = 3.141592653589793; // Default type for decimals is double

        // 128-bit high-precision decimal type (for financial and monetary calculations)
        decimal decimalNumber = 3.1415926535897932384626433832m; // 'm' suffix is required for decimal literals

        // Display the values with their type names
        Console.WriteLine($"float: {floatNumber}");          // Approx. 6–9 digits precision
        Console.WriteLine($"double: {doubleNumber}");        // Approx. 15–17 digits of precision
        Console.WriteLine($"decimal: {decimalNumber}");      // Approx. 28–29 digits of precision
    }
}





---

### 📘 Summary Table:

| Type      | Size    | Precision      | Range (approx)            | Use Case                             |
| --------- | ------- | -------------- | ------------------------- | ------------------------------------ |
| `float`   | 32-bit  | \~6–9 digits   | ±1.5×10⁻⁴⁵ to ±3.4×10³⁸   | Low precision (e.g., graphics)       |
| `double`  | 64-bit  | \~15–17 digits | ±5.0×10⁻³²⁴ to ±1.7×10³⁰⁸ | Default for general-purpose decimals |
| `decimal` | 128-bit | \~28–29 digits | ±1.0×10⁻²⁸ to ±7.9×10²⁸   | Financial & monetary calculations    |

---

### 💡 Notes:

* Use `float` and `double` when **performance** is more important than precision.
* Use `decimal` when **precision matters** (e.g., banking apps, accounting systems).
* Always use suffixes: `f` for `float`, `m` for `decimal`.

